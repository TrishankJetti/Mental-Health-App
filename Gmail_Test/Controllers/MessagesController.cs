// Controllers/MessagesController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MentalHealthApp.Data;
using MentalHealthApp.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;


[Authorize]
public class MessagesController : Controller
{
    private readonly MentalHealthContext _context;
    private readonly UserManager<CustomUser> _userManager;

    public MessagesController(MentalHealthContext context, UserManager<CustomUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }



    // GET: Chat with friend action 
    public async Task<IActionResult> Chat(string friendId)
    {
        var currentUser = await _userManager.GetUserAsync(User);
     
        // Verify friendship exists make sure they are in the accepted status and also that the user id matches with the sender and receiver ids.
        var friendship = await _context.Friendships
            .FirstOrDefaultAsync(f =>
                ((f.RequesterId == currentUser.Id && f.AddresseeId == friendId) ||
                 (f.RequesterId == friendId && f.AddresseeId == currentUser.Id)) &&
                f.Status == FriendshipStatus.Accepted);

        if (friendship == null) return NotFound(); // Returns null if the friendship is null. Just as a page to reduce errors and scaring users.

        var friend = await _userManager.FindByIdAsync(friendId);
        if (friend == null) return NotFound();

        // Get messages
        var messages = await _context.Messages
            .Where(m => (m.SenderId == currentUser.Id && m.ReceiverId == friendId) ||
                       (m.SenderId == friendId && m.ReceiverId == currentUser.Id))
            .OrderBy(m => m.SentAt)  //Order by sending date.
            .Include(m => m.Sender)
            .Include(m => m.Receiver) // INclude these two fields to appear in the chat.
            .ToListAsync(); //Forms into a list for the view.

        ViewBag.Friend = friend;
        return View(messages);
    }

    // POST: Send message
    [HttpPost]
    // In MessagesController.cs
    [HttpPost]
    public async Task<IActionResult> SendMessage(string receiverId, string content)
    {
        var currentUser = await _userManager.GetUserAsync(User);
    

        if (string.IsNullOrWhiteSpace(content))
        {
            TempData["Error"] = "Message cannot be empty.";
     
        }


        //New message with the details.
        var message = new Message
        {
            SenderId = currentUser.Id,
            ReceiverId = receiverId,
            Content = content.Trim(), // Trim removes spaces at the edge of the text. This makes sure that the space is used properly.
            SentAt = DateTime.Now,
            IsRead = false
        };

        _context.Messages.Add(message);
        await _context.SaveChangesAsync();

        //Creates notification for the Action whenever user sends message.
        var notification = new Notification
        {
            UserId = receiverId,
            SenderId = currentUser.Id,
            Message = $"New message from {currentUser.UserName}",
            ConversationId = currentUser.Id, // Using sender's ID as conversation identifier
            MessageId = message.Id,
            CreatedAt = DateTime.UtcNow,
            IsRead = false
        };

        _context.Notifications.Add(notification);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Chat), new { friendId = receiverId });
    }
}