using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MentalHealthApp.Data;
using MentalHealthApp.Models;

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
        // GET: MoodEntries
        public async Task<IActionResult> Index(MoodType? moodFilter)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var allEntries = await _context.MoodEntries
                .Where(m => m.UserId == userId)
                .OrderByDescending(m => m.Date)
                .ToListAsync();

            ViewData["HasAnyEntries"] = allEntries.Any();

            // Apply filter if selected
            var filteredEntries = allEntries.AsQueryable();
            if (moodFilter.HasValue)
            {
                filteredEntries = filteredEntries.Where(m => m.Mood == moodFilter.Value);
            }

            ViewData["CurrentMoodFilter"] = moodFilter;

            return View(filteredEntries.ToList());
        }




        // GET: MoodEntries/Create
        public IActionResult Create()
        {
            ViewData["MoodList"] = new SelectList(Enum.GetValues(typeof(MoodType)));
            return View();
        }

        // POST: MoodEntries/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Mood,Date,Notes")] MoodEntry moodEntry)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null) return Unauthorized();

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return Unauthorized();

            moodEntry.UserId = userId;
            moodEntry.Date = DateTime.UtcNow;

            if (!ModelState.IsValid)
            {
                _context.Add(moodEntry);
                await _context.SaveChangesAsync();

                
                if (user.LastMoodCheckIn.HasValue)
                {
                    if (user.LastMoodCheckIn.Value.Date == DateTime.Today.AddDays(-1))
                        user.CurrentStreak++;
                    else if (user.LastMoodCheckIn.Value.Date != DateTime.Today)
                        user.CurrentStreak = 1;
                }
                else
                {
                    user.CurrentStreak = 1;
                }

                if (user.CurrentStreak > user.LongestStreak)
                    user.LongestStreak = user.CurrentStreak;

                user.LastMoodCheckIn = DateTime.Today;

                if (user.CurrentStreak >= 30)
                    user.Badge = "Gold";
                else if (user.CurrentStreak >= 14)
                    user.Badge = "Silver";
                else if (user.CurrentStreak >= 7)
                    user.Badge = "Bronze";
                else
                    user.Badge = "None";

                await _userManager.UpdateAsync(user);

                TempData["SuccessToast"] = "Mood entry added successfully!";
                return RedirectToAction(nameof(Index));
            }

            ViewData["MoodList"] = new SelectList(Enum.GetValues(typeof(MoodType)), moodEntry.Mood);
            TempData["FailedToast"] = "Failed to add mood entry. Please try again.";
            return View(moodEntry);
        }


        // GET: MoodEntries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var moodEntry = await _context.MoodEntries.FindAsync(id);
            if (moodEntry == null) return NotFound();

            ViewData["MoodList"] = new SelectList(Enum.GetValues(typeof(MoodType)), moodEntry.Mood);
            return View(moodEntry);
        }

        // POST: MoodEntries/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Mood,Date,Notes")] MoodEntry moodEntry)
        {
            if (id != moodEntry.Id) return NotFound();

            var existingEntry = await _context.MoodEntries.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id);
            if (existingEntry == null) return NotFound();

            moodEntry.UserId = existingEntry.UserId; // keep user ID safe

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

            ViewData["MoodList"] = new SelectList(Enum.GetValues(typeof(MoodType)), moodEntry.Mood);
            TempData["FailedToast"] = "Update failed. Please try again.";
            return View(moodEntry);
        }

        // GET: MoodEntries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var moodEntry = await _context.MoodEntries.FirstOrDefaultAsync(m => m.Id == id);
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

        public async Task<IActionResult> MoodChart() // MoodChart action 
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Grabs user's ID. 
 

            var entries = await _context.MoodEntries //Gathers all users moodentries. 
                .Where(m => m.UserId == userId)
                .ToListAsync();

            // Make sure we always have all moods, even if count is 0
            var allMoods = Enum.GetValues(typeof(MoodType)).Cast<MoodType>().ToList(); // Gathers all Moods as an ENum list for the view to use them. Chart JS will put them into a list then hjandle them into the graph.

            var moodCounts = allMoods // Counts all moods for the moodentries 
                .Select(m => new
                {
                    Mood = m.ToString(),
                    Count = entries.Count(e => e.Mood == m)
                }).ToList();

            ViewBag.MoodLabels = moodCounts.Select(m => m.Mood).ToList();
            ViewBag.MoodData = moodCounts.Select(m => m.Count).ToList();

            return View();
        }


        public async Task<IActionResult> Stats() // This is the stats method that calculates all the stats of the user 
            //. This includes there longest login streak. And based on that streak there is a hardcoded rank that is assigned to the users.
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Grab User's Id.
           

            var user = await _userManager.FindByIdAsync(userId);
       

            var entries = await _context.MoodEntries // All entries that belong to user.
                .Where(m => m.UserId == userId)
                .OrderByDescending(m => m.Date)
                .ToListAsync();

            var model = new MoodEntriesViewModel // Creates a new viewmodel with the currentStreak and best streak of the user. This then accumlutes in the front end.
            {
                Entries = entries,
                CurrentStreak = user.CurrentStreak,
                BestStreak = user.LongestStreak,
                Badge = user.Badge
            };

            return View(model);
        }



        // GET: MoodEntries/Details/5
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

    }
}
