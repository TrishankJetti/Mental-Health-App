using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MentalHealthApp.Data;
using MentalHealthApp.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace MentalHealthApp.Controllers
{

    [Authorize(Roles ="Admin")]
    public class TherapistsController : Controller
    {
        private readonly MentalHealthContext _context;
        private readonly UserManager<CustomUser> _userManager;
        public TherapistsController(MentalHealthContext context, UserManager<CustomUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Therapists
        public async Task<IActionResult> Index()
        {
            return View(await _context.Therapists.ToListAsync());
        }

        // GET: Therapists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var therapist = await _context.Therapists
                .FirstOrDefaultAsync(m => m.TherapistId == id);
            if (therapist == null)
            {
                return NotFound();
            }

            return View(therapist);
        }

        [Authorize(Roles = "Admin")]
        // GET: Therapists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Therapists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([Bind("TherapistId,UserId,FirstName,LastName,Specialization,Email,PhoneNumber")] Therapist therapist)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Grabs UserID from IDentity.

            if (userId == null)
            {
                return Unauthorized();
            }

           therapist.UserId = userId;
            if (ModelState.IsValid)
            {
                _context.Add(therapist);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(therapist);
        }

        // GET: Therapists/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var therapist = await _context.Therapists.FindAsync(id);
            if (therapist == null)
            {
                return NotFound();
            }
            return View(therapist);
        }

        // POST: Therapists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, [Bind("TherapistId,UserId,FirstName,LastName,Specialization,Email,PhoneNumber")] Therapist therapist)
        {
            if (id != therapist.TherapistId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
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
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var therapist = await _context.Therapists
                .FirstOrDefaultAsync(m => m.TherapistId == id);
            if (therapist == null)
            {
                return NotFound();
            }

            return View(therapist);
        }

        // POST: Therapists/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Admin")]
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
