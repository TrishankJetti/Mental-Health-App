
using MentalHealthApp.Data;
using MentalHealthApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Authorize]
public class PlannerController : Controller
{
    private readonly MentalHealthContext _context;
    private readonly UserManager<CustomUser> _userManager;

    public PlannerController(MentalHealthContext context, UserManager<CustomUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    // GET: Daily view
    public async Task<IActionResult> Index(string selectedDate = null)
    {
        var user = await _userManager.GetUserAsync(User);
        DateTime date;

        if (!string.IsNullOrEmpty(selectedDate) && DateTime.TryParse(selectedDate, out var parsedDate))
        {
            date = parsedDate.Date;
        }
        else
        {
            date = DateTime.Today;
        }

        var events = await _context.PlannerEvents
           .Where(e => e.UserId == user.Id &&
                      e.StartTime.Date <= date &&
                      e.EndTime.Date >= date) // include events that span this date
           .OrderBy(e => e.StartTime)
           .ToListAsync();

        ViewBag.SelectedDate = date;
        return View(events);
    }




    // GET: Create
    public IActionResult Create() => View();

    // POST: Create
    [HttpPost]
    public async Task<IActionResult> Create(PlannerEvent plannerEvent)
    {
        if (!ModelState.IsValid)
        {
            var user = await _userManager.GetUserAsync(User);
            plannerEvent.UserId = user.Id;
            plannerEvent.CreatedAt = DateTime.Now;

            _context.PlannerEvents.Add(plannerEvent);
            await _context.SaveChangesAsync();

            TempData["Success"] = "Event added!";
            return RedirectToAction(nameof(Index));
        }
        return View(plannerEvent);
    }

    // GET: Edit
    public async Task<IActionResult> Edit(int id)
    {
        var user = await _userManager.GetUserAsync(User);
        var plannerEvent = await _context.PlannerEvents
            .FirstOrDefaultAsync(e => e.Id == id && e.UserId == user.Id);

        if (plannerEvent == null) return NotFound();
        return View(plannerEvent);
    }

    [Authorize]
    public async Task<IActionResult> AllEvents() // All Events page that selects all events that belong to the user.
    {
        var user = await _userManager.GetUserAsync(User);
        var events = await _context.PlannerEvents
            .Where(e => e.UserId == user.Id) 
            .OrderBy(e => e.StartTime)
            .ToListAsync();

        return View(events);
    }


    // POST: Edit
    [HttpPost]
    public async Task<IActionResult> Edit(int id, PlannerEvent plannerEvent)
    {
        if (!ModelState.IsValid)
        {
            var user = await _userManager.GetUserAsync(User);
            var existingEvent = await _context.PlannerEvents
                .FirstOrDefaultAsync(e => e.Id == id && e.UserId == user.Id);

            if (existingEvent == null) return NotFound();

            existingEvent.Title = plannerEvent.Title;
            existingEvent.Description = plannerEvent.Description;
            existingEvent.StartTime = plannerEvent.StartTime;
            existingEvent.EndTime = plannerEvent.EndTime;
            existingEvent.EventType = plannerEvent.EventType;
            existingEvent.Priority = plannerEvent.Priority;
            existingEvent.UpdatedAt = DateTime.Now;

            await _context.SaveChangesAsync();
            TempData["Success"] = "Event updated!";
            return RedirectToAction(nameof(Index));
        }
        return View(plannerEvent);
    }

    // POST: Delete
    [HttpPost]
    public async Task<IActionResult> Delete(int id)
    {
        var user = await _userManager.GetUserAsync(User);
        var plannerEvent = await _context.PlannerEvents
            .FirstOrDefaultAsync(e => e.Id == id && e.UserId == user.Id);

        if (plannerEvent != null)
        {
            _context.PlannerEvents.Remove(plannerEvent);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Event deleted!";
        }
        return RedirectToAction(nameof(Index));
    }


    [HttpPost]
    public async Task<IActionResult> ToggleComplete(int id, string selectedDate)
    {
        var user = await _userManager.GetUserAsync(User);
        var plannerEvent = await _context.PlannerEvents
            .FirstOrDefaultAsync(e => e.Id == id && e.UserId == user.Id);

        if (plannerEvent == null) return NotFound();

        plannerEvent.IsCompleted = !plannerEvent.IsCompleted;
        plannerEvent.UpdatedAt = DateTime.Now;

        await _context.SaveChangesAsync();

        // Redirect back to the same date
        return RedirectToAction(nameof(Index), new { selectedDate });
    }

    [HttpPost]
    public async Task<IActionResult> ToggleCompleteFilter(int id, string selectedDate)
    {
        var user = await _userManager.GetUserAsync(User);
        var plannerEvent = await _context.PlannerEvents
            .FirstOrDefaultAsync(e => e.Id == id && e.UserId == user.Id);

        if (plannerEvent == null) return NotFound();

        plannerEvent.IsCompleted = !plannerEvent.IsCompleted;
        plannerEvent.UpdatedAt = DateTime.Now;

        await _context.SaveChangesAsync();

        // Redirect to AllEvents action
        return RedirectToAction("AllEvents");
    }



}
