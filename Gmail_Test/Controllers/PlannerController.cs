
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

    public async Task<IActionResult> AllEvents(string search, DateTime? startDate, DateTime? endDate, EventType? eventType, bool? isCompleted)
    {
        var user = await _userManager.GetUserAsync(User);

        var query = _context.PlannerEvents
            .Where(e => e.UserId == user.Id)
            .AsQueryable();

        bool hasFilters = !string.IsNullOrEmpty(search) || startDate.HasValue || endDate.HasValue || eventType.HasValue || isCompleted.HasValue;

        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(e => e.Title.Contains(search) || e.Description.Contains(search));
        }
        if (startDate.HasValue)
        {
            query = query.Where(e => e.StartTime.Date >= startDate.Value.Date);
        }
        if (endDate.HasValue)
        {
            query = query.Where(e => e.EndTime.Date <= endDate.Value.Date);
        }
        if (eventType.HasValue)
        {
            query = query.Where(e => e.EventType == eventType.Value);
        }
        if (isCompleted.HasValue)
        {
            query = query.Where(e => e.IsCompleted == isCompleted.Value);
        }

        var events = await query.OrderBy(e => e.StartTime).ToListAsync();

        ViewBag.HasFilters = hasFilters;
        return View(events);
    }


    // CREATE
    public IActionResult Create() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
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
            return RedirectToAction(nameof(AllEvents));
        }
        return View(plannerEvent);
    }

    // EDIT
    public async Task<IActionResult> Edit(int id)
    {
        var user = await _userManager.GetUserAsync(User);
        var plannerEvent = await _context.PlannerEvents.FirstOrDefaultAsync(e => e.Id == id && e.UserId == user.Id);

        if (plannerEvent == null) return NotFound();
        return View(plannerEvent);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, PlannerEvent plannerEvent)
    {
        if (!ModelState.IsValid)
        {
            var user = await _userManager.GetUserAsync(User);
            var existingEvent = await _context.PlannerEvents.FirstOrDefaultAsync(e => e.Id == id && e.UserId == user.Id);

            if (existingEvent == null) return NotFound();

            existingEvent.Title = plannerEvent.Title;
            existingEvent.Description = plannerEvent.Description;
            existingEvent.StartTime = plannerEvent.StartTime;
            existingEvent.EndTime = plannerEvent.EndTime;
            existingEvent.EventType = plannerEvent.EventType;
            existingEvent.Priority = plannerEvent.Priority;
            existingEvent.IsCompleted = plannerEvent.IsCompleted;
            existingEvent.UpdatedAt = DateTime.Now;

            await _context.SaveChangesAsync();
            TempData["Success"] = "Event updated!";
            return RedirectToAction(nameof(AllEvents));
        }
        return View(plannerEvent);
    }

    // DELETE
    [HttpPost]
    public async Task<IActionResult> Delete(int id)
    {
        var user = await _userManager.GetUserAsync(User);
        var plannerEvent = await _context.PlannerEvents.FirstOrDefaultAsync(e => e.Id == id && e.UserId == user.Id);

        if (plannerEvent != null)
        {
            _context.PlannerEvents.Remove(plannerEvent);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Event deleted!";
        }
        return RedirectToAction(nameof(AllEvents));
    }

    // TOGGLE COMPLETE
    [HttpPost]
    public async Task<IActionResult> ToggleComplete(int id)
    {
        var user = await _userManager.GetUserAsync(User);
        var plannerEvent = await _context.PlannerEvents.FirstOrDefaultAsync(e => e.Id == id && e.UserId == user.Id);

        if (plannerEvent == null) return NotFound();

        plannerEvent.IsCompleted = !plannerEvent.IsCompleted;
        plannerEvent.UpdatedAt = DateTime.Now;

        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(AllEvents));
    }
}
