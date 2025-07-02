using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MentalHealthApp.Data;
using MentalHealthApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace MentalHealthApp.Controllers
{
    [Authorize]
    public class MoodEntriesController : Controller
    {
        private readonly MentalHealthContext _context;
        private readonly UserManager<CustomUser> _userManager;

        public MoodEntriesController(MentalHealthContext context, UserManager<CustomUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: MoodEntries
        public async Task<IActionResult> Index(int? patientId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var query = _context.MoodEntries
                .Where(m => m.UserId == userId)
                .Include(m => m.Mood)
                .Include(m => m.Patient)
                .AsQueryable();

            var patients = await _context.Patients
                .Where(p => _context.MoodEntries.Any(m => m.PatientId == p.PatientId && m.UserId == userId))
                .ToListAsync();

            if (patientId.HasValue)
            {
                query = query.Where(m => m.PatientId == patientId);
            }

            ViewData["Patients"] = new SelectList(patients, "PatientId", "FirstName");

            // Check-in reminder logic
            var user = await _userManager.GetUserAsync(User);
            var lastCheck = user?.LastMoodCheckIn?.Date ?? DateTime.MinValue;
            ViewBag.LastCheckIn = user?.LastMoodCheckIn;
            ViewData["ShowCheckInReminder"] = lastCheck.AddDays(2) < DateTime.UtcNow.Date;

            return View(await query.ToListAsync());
        }

        // GET: MoodEntries/Create
        public IActionResult Create()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var patients = _context.Patients
                .Where(p => p.UserId == userId)
                .ToList();

            ViewData["PatientId"] = new SelectList(patients, "PatientId", "FirstName");
            ViewData["MoodId"] = new SelectList(_context.MoodTypes, "MoodTypeId", "Name");

            return View();
        }

        // POST: MoodEntries/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MoodId,Date,Notes,PatientId")] MoodEntry moodEntry)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null) return Unauthorized();

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return Unauthorized();

            moodEntry.UserId = userId;
            moodEntry.Date = DateTime.UtcNow;

            if (ModelState.IsValid)
            {
                _context.Add(moodEntry);

                user.LastMoodCheckIn = DateTime.UtcNow;
                await _userManager.UpdateAsync(user);

                await _context.SaveChangesAsync();
                TempData["SuccessToast"] = "Mood entry added successfully!";
                return RedirectToAction(nameof(Index));
            }

            var patients = _context.Patients.Where(p => p.UserId == userId).ToList();
            ViewData["PatientId"] = new SelectList(patients, "PatientId", "FirstName", moodEntry.PatientId);
            ViewData["MoodId"] = new SelectList(_context.MoodTypes, "MoodTypeId", "Name", moodEntry.MoodId);
            TempData["FailedToast"] = "Failed to add mood entry. Please check your inputs.";
            return View(moodEntry);
        }

        // GET: MoodEntries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var moodEntry = await _context.MoodEntries.FindAsync(id);
            if (moodEntry == null) return NotFound();

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var patients = _context.Patients.Where(p => p.UserId == userId).ToList();

            ViewData["MoodId"] = new SelectList(_context.MoodTypes, "MoodTypeId", "Name", moodEntry.MoodId);
            ViewData["PatientId"] = new SelectList(patients, "PatientId", "FirstName", moodEntry.PatientId);
            return View(moodEntry);
        }

        // POST: MoodEntries/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MoodId,Date,Notes,PatientId")] MoodEntry moodEntry)
        {
            if (id != moodEntry.Id) return NotFound();

            var existingEntry = await _context.MoodEntries.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id);
            if (existingEntry == null) return NotFound();

            moodEntry.UserId = existingEntry.UserId;

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(moodEntry);
                    await _context.SaveChangesAsync();
                    TempData["SuccessToast"] = "Mood entry updated!";
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoodEntryExists(moodEntry.Id)) return NotFound();
                    else throw;
                }
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var patients = _context.Patients.Where(p => p.UserId == userId).ToList();

            ViewData["MoodId"] = new SelectList(_context.MoodTypes, "MoodTypeId", "Name", moodEntry.MoodId);
            ViewData["PatientId"] = new SelectList(patients, "PatientId", "FirstName", moodEntry.PatientId);
            TempData["FailedToast"] = "Update failed. Please try again.";
            return View(moodEntry);
        }

        // GET: MoodEntries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var moodEntry = await _context.MoodEntries
                .Include(m => m.Mood)
                .Include(m => m.Patient)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (moodEntry == null) return NotFound();

            return View(moodEntry);
        }

        // POST: MoodEntries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var moodEntry = await _context.MoodEntries.FindAsync(id);
            if (moodEntry != null)
            {
                _context.MoodEntries.Remove(moodEntry);
                await _context.SaveChangesAsync();
                TempData["SuccessToast"] = "Mood entry deleted.";
            }

            return RedirectToAction(nameof(Index));
        }

        private bool MoodEntryExists(int id)
        {
            return _context.MoodEntries.Any(e => e.Id == id);
        }
    }
}
