using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MentalHealthApp.Data;
using MentalHealthApp.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using MentalHealthApp.Models;

namespace MentalHealthApp.Controllers
{
    [Authorize]
    public class MoodEntriesController : Controller
    {
        private readonly MentalHealthContext _context;

        public MoodEntriesController(MentalHealthContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userMoodEntries = _context.MoodEntries
                .Include(m => m.Mood)
                .Where(m => m.UserId == userId);
            return View(await userMoodEntries.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var moodEntry = await _context.MoodEntries
                .Include(m => m.Mood)
                .FirstOrDefaultAsync(m => m.Id == id && m.UserId == userId);

            if (moodEntry == null) return NotFound();
            return View(moodEntry);
        }

        public IActionResult Create()
        {
            ViewData["MoodId"] = new SelectList(_context.MoodType, "Id", "Name" ,"ImageFile");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,MoodId,Date,Notes")] MoodEntry moodEntry)
        {
            if (!ModelState.IsValid)
            {
                moodEntry.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var selectedMood = await _context.MoodType.FindAsync(moodEntry.MoodId);


                _context.Add(moodEntry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["MoodId"] = new SelectList(_context.MoodType, "Id", "Name", moodEntry.MoodId);
            return View(moodEntry);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var moodEntry = await _context.MoodEntries.FindAsync(id);
            if (moodEntry == null) return NotFound();

            ViewData["MoodId"] = new SelectList(_context.MoodType, "Id", "Name", moodEntry.MoodId);
            return View(moodEntry);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,MoodId,Date,Notes")] MoodEntry moodEntry)
        {
            if (id != moodEntry.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(moodEntry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.MoodEntries.Any(e => e.Id == moodEntry.Id)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }

            ViewData["MoodId"] = new SelectList(_context.MoodType, "Id", "Name", moodEntry.MoodId);
            return View(moodEntry);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var moodEntry = await _context.MoodEntries.Include(m => m.Mood).FirstOrDefaultAsync(m => m.Id == id);
            if (moodEntry == null) return NotFound();

            return View(moodEntry);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var moodEntry = await _context.MoodEntries.FindAsync(id);
            if (moodEntry != null)
            {
                _context.MoodEntries.Remove(moodEntry);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
