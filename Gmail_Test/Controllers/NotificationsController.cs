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

        public async Task<IActionResult> HandleNotification(int id)
        {
            var notification = await _context.Notifications.FindAsync(id);
            if (notification == null) return NotFound();

            // Mark as read
            notification.IsRead = true;
            _context.Notifications.Update(notification);
            await _context.SaveChangesAsync();

            // Redirect based on notification type
            if (notification.Message.Contains("friend request"))
            {
                return RedirectToAction("Index", "Friends"); // Go to friends page
            }
            else if (notification.Message.Contains("message"))
            {
                return RedirectToAction("Chat", "Messages", new { friendId = notification.SenderId });
            }

            return RedirectToAction("Index", "Home");
        }


    }
}
