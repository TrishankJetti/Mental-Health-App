using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MentalHealthApp.Data;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace MentalHealthApp.Controllers
{
    [Authorize]
    public class NotificationsController : Controller
    {
        private readonly MentalHealthContext _context;

        public NotificationsController(MentalHealthContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> MarkAllAsRead()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var unread = await _context.Notifications
                .Where(n => n.UserId == userId && !n.IsRead)
                .ToListAsync();

            foreach (var n in unread)
                n.IsRead = true;

            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
