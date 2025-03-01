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

        // GET: MoodTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.MoodType.ToListAsync());
        }

        // GET: MoodTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moodType = await _context.MoodType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moodType == null)
            {
                return NotFound();
            }

            return View(moodType);
        }

        // GET: MoodTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ImageFile")] MoodType moodType)
        {
            if (ModelState.IsValid)
            {
                if (moodType.ImageFile != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(moodType.ImageFile.FileName);
                    string extension = Path.GetExtension(moodType.ImageFile.FileName);
                    moodType.MoodImage = fileName + "_" + Guid.NewGuid().ToString() + extension;

                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", moodType.MoodImage);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await moodType.ImageFile.CopyToAsync(fileStream);
                    }
                }

                _context.Add(moodType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(moodType);
        }

        // GET: MoodTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moodType = await _context.MoodType.FindAsync(id);
            if (moodType == null)
            {
                return NotFound();
            }

            return View(moodType);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ImageFile")] MoodType moodType)
        {
            if (id != moodType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var existingMoodType = await _context.MoodType.FindAsync(id);
                    if (existingMoodType == null)
                    {
                        return NotFound();
                    }

                    existingMoodType.Name = moodType.Name;

                    if (moodType.ImageFile != null)
                    {
                        string fileName = Path.GetFileNameWithoutExtension(moodType.ImageFile.FileName);
                        string extension = Path.GetExtension(moodType.ImageFile.FileName);
                        existingMoodType.MoodImage = fileName + "_" + Guid.NewGuid().ToString() + extension;

                        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", existingMoodType.MoodImage);
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await moodType.ImageFile.CopyToAsync(fileStream);
                        }
                    }

                    _context.Update(existingMoodType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoodTypeExists(moodType.Id))
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


        // GET: MoodTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moodType = await _context.MoodType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moodType == null)
            {
                return NotFound();
            }

            return View(moodType);
        }

        // POST: MoodTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var moodType = await _context.MoodType.FindAsync(id);
            if (moodType != null)
            {
                _context.MoodType.Remove(moodType);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MoodTypeExists(int id)
        {
            return _context.MoodType.Any(e => e.Id == id);
        }
    }
}
