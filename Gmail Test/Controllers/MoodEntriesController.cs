using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gmail_Test.Data;
using Gmail_Test.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Gmail_Test.Controllers
{
    [Authorize]
    public class MoodEntriesController : Controller
    {
        private readonly Gmail_TestContext _context;

        public MoodEntriesController(Gmail_TestContext context)
        {
            _context = context;
        }

        // GET: MoodEntries
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); //Initilizes the userID variable by grabbing the Identity Claim : 
                                                                         //Name Identifier from the Identity User.
            var userMoodEntries = _context.MoodEntries.Where(m => m.UserId == userId);
            return View(await userMoodEntries.ToListAsync());
        }
        // Only allow access to details of entries belonging to the logged-in user
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var moodEntry = await _context.MoodEntries
                .FirstOrDefaultAsync(m => m.Id == id && m.UserId == userId);

            if (moodEntry == null)
            {
                return NotFound();
            }

            return View(moodEntry);
        }

        // GET: MoodEntries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MoodEntries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,Mood,Date,Notes")] MoodEntry moodEntry)
        {
            if (!ModelState.IsValid)
            {
                moodEntry.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier); //If the record is a valid record it will make sure to set the user ID to the userID variable defined above.
                _context.Add(moodEntry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(moodEntry);
        }

        // GET: MoodEntries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moodEntry = await _context.MoodEntries.FindAsync(id);
            if (moodEntry == null)
            {
                return NotFound();
            }
            return View(moodEntry);
        }

        // POST: MoodEntries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,Mood,Date,Notes")] MoodEntry moodEntry)
        {
            if (id != moodEntry.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(moodEntry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoodEntryExists(moodEntry.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(moodEntry);
        }

        // GET: MoodEntries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moodEntry = await _context.MoodEntries
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moodEntry == null)
            {
                return NotFound();
            }

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
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MoodEntryExists(int id)
        {
            return _context.MoodEntries.Any(e => e.Id == id);
        }
    }
}
