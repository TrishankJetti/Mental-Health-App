using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MentalHealthApp.Data;
using MentalHealthApp.Models;

namespace MentalHealthApp.Controllers
{

    public class TherapistsController : Controller
    {
        private readonly MentalHealthContext _context;
        private readonly UserManager<CustomUser> _userManager;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public TherapistsController(MentalHealthContext context, UserManager<CustomUser> userManager, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _userManager = userManager;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Therapists
        public async Task<IActionResult> Index()
        {
            return View(await _context.Therapists.ToListAsync());
        }

        // GET: Therapists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var therapist = await _context.Therapists.FirstOrDefaultAsync(m => m.TherapistId == id);
            if (therapist == null) return NotFound();

            return View(therapist);
        }

        // GET: Therapists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Therapists/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Therapist therapist)

        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null)
            {
                return Unauthorized();
            }

            therapist.UserId = userId;

            if (ModelState.IsValid)
            {
                // Handle image upload
                if (therapist.ImageFile != null && therapist.ImageFile.Length > 0)
                {
                    string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "img");
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + therapist.ImageFile.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await therapist.ImageFile.CopyToAsync(fileStream);
                    }

                    therapist.ImageFileName = uniqueFileName;
                }
                else
                {
                    therapist.ImageFileName = "default-therapist.jpg";

                }

                _context.Add(therapist);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(therapist);
        }

        // GET: Therapists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var therapist = await _context.Therapists.FindAsync(id);
            if (therapist == null) return NotFound();

            return View(therapist);
        }

        // POST: Therapists/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TherapistId,UserId,FirstName,LastName,Specialization,Bio,ImageFile,ImageFileName,Email,PhoneNumber")] Therapist therapist)
        {
            if (id != therapist.TherapistId) return NotFound();

            if (!ModelState.IsValid)
            {
                try
                {
                    if (therapist.ImageFile != null && therapist.ImageFile.Length > 0)
                    {
                        string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "img");
                        string uniqueFileName = Guid.NewGuid().ToString() + "_" + therapist.ImageFile.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await therapist.ImageFile.CopyToAsync(fileStream);
                        }

                        therapist.ImageFileName = uniqueFileName;
                    }
                    else if (string.IsNullOrEmpty(therapist.ImageFileName))
                    {
                        therapist.ImageFileName = "default-therapist.jpg";

                    }

                    _context.Update(therapist);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TherapistExists(therapist.TherapistId))
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
            return View(therapist);
        }

        // GET: Therapists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var therapist = await _context.Therapists.FirstOrDefaultAsync(m => m.TherapistId == id);
            if (therapist == null) return NotFound();

            return View(therapist);
        }

        // POST: Therapists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var therapist = await _context.Therapists.FindAsync(id);
            if (therapist != null)
            {
                _context.Therapists.Remove(therapist);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TherapistExists(int id)
        {
            return _context.Therapists.Any(e => e.TherapistId == id);
        }
    }
}
