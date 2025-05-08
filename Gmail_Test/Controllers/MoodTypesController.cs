using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MentalHealthApp.Data;
using MentalHealthApp.Models;

namespace MentalHealthApp.Controllers
{
    public class MoodTypesController : Controller
    {
        private readonly MentalHealthContext _context;

        public MoodTypesController(MentalHealthContext context)
        {
            _context = context;
        }


        // GET: MoodTypes1
        public async Task<IActionResult> Index()
        {
            return View(await _context.MoodTypes.ToListAsync());
        }

        // GET: MoodTypes1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moodType = await _context.MoodTypes
                .FirstOrDefaultAsync(m => m.MoodTypeId == id);
            if (moodType == null)
            {
                return NotFound();
            }

            return View(moodType);
        }

        // GET: MoodTypes1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MoodTypes1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MoodTypeId,Name")] MoodType moodType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(moodType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(moodType);
        }

        // GET: MoodTypes1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moodType = await _context.MoodTypes.FindAsync(id);
            if (moodType == null)
            {
                return NotFound();
            }
            return View(moodType);
        }

        // POST: MoodTypes1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MoodTypeId,Name")] MoodType moodType)
        {
            if (id != moodType.MoodTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(moodType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoodTypeExists(moodType.MoodTypeId))
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
            return View(moodType);
        }

        // GET: MoodTypes1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moodType = await _context.MoodTypes
                .FirstOrDefaultAsync(m => m.MoodTypeId == id);
            if (moodType == null)
            {
                return NotFound();
            }

            return View(moodType);
        }

        // POST: MoodTypes1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var moodType = await _context.MoodTypes.FindAsync(id);
            if (moodType != null)
            {
                _context.MoodTypes.Remove(moodType);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MoodTypeExists(int id)
        {
            return _context.MoodTypes.Any(e => e.MoodTypeId == id);
        }
    }
}
