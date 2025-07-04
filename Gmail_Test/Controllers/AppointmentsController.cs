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

namespace MentalHealthApp.Controllers
{
    [Authorize
        ]
    public class AppointmentsController : Controller
    {
        private readonly MentalHealthContext _context;

        public AppointmentsController(MentalHealthContext context)
        {
            _context = context;
        }

        // GET: Appointments
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (User.IsInRole("Therapist"))
            {
                var therapist = await _context.Therapists
                    .FirstOrDefaultAsync(t => t.UserId == userId);

                if (therapist == null)
                    return Unauthorized();

                var appointments = await _context.Appointments
                    .Include(a => a.Patient).ThenInclude(p => p.User)
                    .Include(a => a.Therapist)
                    .Where(a => a.TherapistId == therapist.TherapistId)
                    .ToListAsync();

                return View(appointments);
            }
            else if (User.IsInRole("Patient"))
            {
                var appointments = await _context.Appointments
                    .Include(a => a.Patient).ThenInclude(p => p.User)
                    .Include(a => a.Therapist)
                    .Where(a => a.Patient.UserId == userId)
                    .ToListAsync();

                return View(appointments);
            }
            else if (User.IsInRole("Admin"))
            {
                var appointments = await _context.Appointments
                    .Include(a => a.Patient).ThenInclude(p => p.User)
                    .Include(a => a.Therapist)
                    .ToListAsync();

                return View(appointments);
            }

            return Unauthorized(); // restrict access for other roles
        }


        // GET: Appointments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var appointment = await _context.Appointments
                .Include(a => a.Patient)
                .Include(a => a.Therapist)
                .FirstOrDefaultAsync(m => m.AppointmentId == id);

            if (appointment == null) return NotFound();

            return View(appointment);
        }

        // GET: Appointments/Create
        public IActionResult Create()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (User.IsInRole("Patient"))
            {
                var userPatients = _context.Patients
                    .Where(p => p.UserId == userId)
                    .ToList();
                ViewData["PatientId"] = new SelectList(userPatients, "PatientId", "FirstName");
            }
            else
            {
                ViewData["PatientId"] = new SelectList(_context.Patients, "PatientId", "FirstName");
            }

            ViewData["TherapistId"] = new SelectList(_context.Therapists, "TherapistId", "FirstName");
            return View();
        }

        // POST: Appointments/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AppointmentId,TherapistId,PatientId,AppointmentDate,DurationMinutes,Notes")] Appointment appointment)
        {
            if (!ModelState.IsValid)
            {
                appointment.Status = AppointmentStatus.Scheduled;
                appointment.CreatedAt = DateTime.Now;
                appointment.UpdatedAt = DateTime.Now;

                _context.Add(appointment);
                await _context.SaveChangesAsync();

                var therapistUserId = await _context.Therapists
                    .Where(t => t.TherapistId == appointment.TherapistId)
                    .Select(t => t.UserId)
                    .FirstOrDefaultAsync();

                if (therapistUserId != null)
                {
                    var notification = new Notification
                    {
                        UserId = therapistUserId,
                        Message = "A new appointment has been booked by a patient.",
                        IsRead = false,
                        CreatedAt = DateTime.Now
                    };

                    _context.Notifications.Add(notification);
                    await _context.SaveChangesAsync();
                }

                return RedirectToAction(nameof(Index));
            }

            ViewData["PatientId"] = new SelectList(_context.Patients, "PatientId", "FirstName", appointment.PatientId);
            ViewData["TherapistId"] = new SelectList(_context.Therapists, "TherapistId", "FirstName", appointment.TherapistId);
            return View(appointment);
        }

        // GET: Appointments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment == null) return NotFound();

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userPatients = _context.Patients
                .Where(p => p.UserId == userId)
                .ToList();

            ViewData["PatientId"] = new SelectList(userPatients, "PatientId", "FirstName", appointment.PatientId);
            ViewData["TherapistId"] = new SelectList(_context.Therapists, "TherapistId", "FirstName", appointment.TherapistId);

            return View(appointment);
        }

        // POST: Appointments/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AppointmentId,TherapistId,PatientId,AppointmentDate,DurationMinutes,Status,Notes")] Appointment appointment)
        {
            if (id != appointment.AppointmentId) return NotFound();

            if (!ModelState.IsValid)
            {


                // Only send notification if patient is editing
                if (User.IsInRole("Therapist"))
                {
                    var therapistUserId = await _context.Therapists
                        .Where(t => t.TherapistId == appointment.TherapistId)
                        .Select(t => t.UserId)
                        .FirstOrDefaultAsync();

                    if (therapistUserId != null)
                    {
                        var notification = new Notification
                        {
                            UserId = therapistUserId,
                            Message = "An appointment has been updated by your patient.",
                            IsRead = false,
                            CreatedAt = DateTime.Now
                        };
                        _context.Notifications.Add(notification);
                        await _context.SaveChangesAsync(); // Save the notification
                    }
                }


                try
                {
                    var existing = await _context.Appointments.AsNoTracking().FirstOrDefaultAsync(a => a.AppointmentId == id);
                    if (existing == null) return NotFound();

                    // Prevent non-therapists from editing the status
                    if (!User.IsInRole("Therapist"))
                    {
                        appointment.Status = existing.Status;
                    }

                    appointment.CreatedAt = existing.CreatedAt;
                    appointment.UpdatedAt = DateTime.Now;

                    _context.Update(appointment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppointmentExists(appointment.AppointmentId))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }

            ViewData["PatientId"] = new SelectList(_context.Patients, "PatientId", "FirstName", appointment.PatientId);
            ViewData["TherapistId"] = new SelectList(_context.Therapists, "TherapistId", "FirstName", appointment.TherapistId);
            return View(appointment);
        }

        // GET: Appointments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var appointment = await _context.Appointments
                .Include(a => a.Patient)
                .Include(a => a.Therapist)
                .FirstOrDefaultAsync(m => m.AppointmentId == id);

            if (appointment == null) return NotFound();

            return View(appointment);
        }

        // POST: Appointments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment != null)
            {
                _context.Appointments.Remove(appointment);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool AppointmentExists(int id)
        {
            return _context.Appointments.Any(e => e.AppointmentId == id);
        }
    }
}
