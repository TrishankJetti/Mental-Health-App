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
                n.IsRead = true;      // Sets all unread notificaitons to true for the IsRead variable.

            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home"); // Return to home
        }

        public async Task<IActionResult> HandleNotification(int id) // Notificaiotns with freind requests and etc. 
        {
            var notification = await _context.Notifications.FindAsync(id);
            if (notification == null) return NotFound();

            // Mark as read
            notification.IsRead = true;
            _context.Notifications.Update(notification);
            await _context.SaveChangesAsync();

            // Redirect based on notification type
            if (notification.Message.Contains("friend request")) // if it is a friend request , it will contain the friend request strings.
            {
                return RedirectToAction("PendingRequests", "Friends"); // Go to pending reqs page.
            }
            else if (notification.Message.Contains("message")) // Message type notifciation. 
            {
                return RedirectToAction("Chat", "Messages", new { friendId = notification.SenderId });
            }

            return RedirectToAction("Index", "Home");
        }


    }
}
