// Controllers/FriendsController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MentalHealthApp.Data;
using MentalHealthApp.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;


[Authorize]
public class FriendsController : Controller
{
    private readonly MentalHealthContext _context;
    private readonly UserManager<CustomUser> _userManager;

    public FriendsController(MentalHealthContext context, UserManager<CustomUser> userManager)
    {
        _context = context;
        _userManager = userManager;  // COntext and identity injection into the controller.
    }

    // GET: My Friends for the index view. 
    public async Task<IActionResult> Index()
    {
        var currentUser = await _userManager.GetUserAsync(User); // Grabs the current User Id 

        // Get accepted friends
        var friendships = await _context.Friendships //Grabs all friendships within the context.
            .Where(f => (f.RequesterId == currentUser.Id || f.AddresseeId == currentUser.Id) // THe requester Id has to match the userid or the address Id.
                     && f.Status == FriendshipStatus.Accepted) // Additonally the status has to be Accepted inorder for the friendship to show on the index page.
            .Include(f => f.Requester)  // This here is for the fields to appear in controller for the front end to show the fields
            .Include(f => f.Addressee)   
            .ToListAsync();

        var friendList = new List<CustomUser>(); // Creates a variable to create a list for the friendships the user has.
        foreach (var friendship in friendships) // Foor loop for each friendship within the model.
        {
            if (friendship.RequesterId == currentUser.Id)
            {
                friendList.Add(friendship.Addressee); // Current user sent request since the requester id matches the user's id.
            }
            else
            {
                friendList.Add(friendship.Requester); // Current user received request since the id matches the user's id.
            }
        }

        // Gathers all Pending Requests to show on the index page so users can reject or accept.
        var pendingRequests = await _context.Friendships
            .Where(f => f.AddresseeId == currentUser.Id && f.Status == FriendshipStatus.Pending)
            .Include(f => f.Requester)  //Include so that the Index can view this field in the front end. 
            .ToListAsync();

        // Pass both to view
        ViewBag.PendingRequests = pendingRequests;
        return View(friendList); // Returns friends lsit to tthe view.
    }

    // GET: Find users to add
    [HttpGet]
    public async Task<IActionResult> Find(string searchString) //FInd method that allows users to conenct with other people who signed up to the site.
    {
        var currentUser = await _userManager.GetUserAsync(User); //Gathers the user Id again/
  

        // Make sure all admin Ids are gathered so that the Users cant add admins as friends.
        var adminUsers = await _userManager.GetUsersInRoleAsync("Admin"); // GetUserInRoleAsync gathers all users within the certain role wihtin the parenthesis.
        var adminUserIds = adminUsers.Select(a => a.Id).ToList(); //Selects Id field of these users. 

        // Get existing relationships 
        var existingRelationships = await _context.Friendships // The await over here asynchronously gathers all the friendships the user has from the context.
                                                               // Await acts as helping hand in running tasks in the background without disturbing the Websites load times and performeances etc. In other words it runs in the background and helps the asynchronous methods.
            .Where(f => f.RequesterId == currentUser.Id || f.AddresseeId == currentUser.Id)
            .Select(f => f.RequesterId == currentUser.Id ? f.AddresseeId : f.RequesterId)
            .ToListAsync();  // All conditions of the frien

        // Combine excluded IDs from the admins.
        var excludedIds = adminUserIds
            .Concat(new[] { currentUser.Id }) //Concatinates the Current user ids of the admin users into an array. 
            .Concat(existingRelationships)
            .Distinct() //removes duplicates within an array.
            .ToList();

        // Get users to show
        var users = await _userManager.Users   // Gathers all users and assigns it to the users variable as a var. It is a var because we cant pin point the exact data type.
            .Where(u => !excludedIds.Contains(u.Id)) //Users mustnt be on the list of admin ids hence the exclude id list.
            .ToListAsync();

        // Apply search filter if provided
        if (!string.IsNullOrEmpty(searchString))
        {
            searchString = searchString.ToLower();
            users = users.Where(u =>
                u.UserName.ToLower().Contains(searchString) ||
                u.Email.ToLower().Contains(searchString) ||
                (u.FirstName != null && u.FirstName.ToLower().Contains(searchString)) ||
                (u.LastName != null && u.LastName.ToLower().Contains(searchString))
            ).ToList();
        }

        ViewBag.SearchString = searchString;
        return View(users); // Returns the users to the View.
    }

    public async Task<IActionResult> PendingRequests() // Pending Reqs view.
    {
        var currentUser = await _userManager.GetUserAsync(User);
    

        var pendingRequests = await _context.Friendships // Gathers all pending requests from the context. 
            .Where(f => f.AddresseeId == currentUser.Id && f.Status == FriendshipStatus.Pending) // The enum vlaue has to be set to pending.
            .Include(f => f.Requester) 
            .ToListAsync();

        return View(pendingRequests); //Passes the info to the view.
    }


  
    [HttpPost]
    public async Task<IActionResult> SendRequest(string userId)
    {
        var currentUser = await _userManager.GetUserAsync(User);
      

        // Check if request already exists withi nthe database
        var existingRequest = await _context.Friendships
            .FirstOrDefaultAsync(f =>
                (f.RequesterId == currentUser.Id && f.AddresseeId == userId) ||
                (f.RequesterId == userId && f.AddresseeId == currentUser.Id));

        if (existingRequest != null)
        {
            TempData["Message"] = "Friend request already exists."; //Error message occurs. 
            return RedirectToAction(nameof(Find));
        }

        var friendship = new Friendship // Creates a new friendship record ion the database, and the status is pedning wwaitin to be viewed and modified.
        {
            RequesterId = currentUser.Id,
            AddresseeId = userId,
            Status = FriendshipStatus.Pending,
            CreatedAt = DateTime.Now
        };

        _context.Friendships.Add(friendship); // adds to database
        await _context.SaveChangesAsync();

        
        var notification = new Notification // Creates a new notification to be added to the database.
        {
            UserId = userId, // The user who received the request
            SenderId = currentUser.Id, // The user who sent the request
            Message = $"{currentUser.UserName} sent you a friend request",
            ConversationId = currentUser.Id, // Link to the user's profile
            CreatedAt = DateTime.UtcNow,
            IsRead = false // False by default since user hasnt read it. 
        };

        _context.Notifications.Add(notification);
        await _context.SaveChangesAsync();

        TempData["Message"] = "Friend request sent!";// Temp data for the toast. 
        return RedirectToAction(nameof(Find));
    }

    // POST: Accept friend request
    [HttpPost]
    public async Task<IActionResult> AcceptRequest(int friendshipId)
    {
        var currentUser = await _userManager.GetUserAsync(User);
        var friendship = await _context.Friendships
            .Include(f => f.Requester) // Include the requester to get their info
            .FirstOrDefaultAsync(f => f.Id == friendshipId);

        if (friendship == null || friendship.AddresseeId != currentUser.Id) // Friend request is null if the AdresseeId isnt the same as current user id. It acts liek a security measure.
        {
            TempData["Error"] = "Friend request not found.";
            return RedirectToAction(nameof(Index));
        }

        friendship.Status = FriendshipStatus.Accepted; // Since the users accepts the friends req the enum is now modifed to accepted.
        friendship.RespondedAt = DateTime.Now; //The field RespondedAt is now popualted.

        _context.Friendships.Update(friendship);

    
        var notification = new Notification // A new notification is also created. to shwo to the sender.
        {
            UserId = friendship.RequesterId, // The user who originally sent the request
            SenderId = currentUser.Id, // The user who accepted it
            Message = $"{currentUser.UserName} accepted your friend request!",
            ConversationId = currentUser.Id, // Link to chat
            CreatedAt = DateTime.UtcNow,
            IsRead = false
        };

        _context.Notifications.Add(notification);
        await _context.SaveChangesAsync();

        TempData["Message"] = "Friend request accepted!";
        return RedirectToAction(nameof(Index));
    }

    // POST: Decline friend request
    [HttpPost]
    public async Task<IActionResult> DeclineRequest(int friendshipId)
    {
        var currentUser = await _userManager.GetUserAsync(User);
        var friendship = await _context.Friendships.FindAsync(friendshipId);

        if (friendship == null || friendship.AddresseeId != currentUser.Id)
        {
            TempData["Error"] = "Friend request not found.";
            return RedirectToAction(nameof(Index));
        }

        _context.Friendships.Remove(friendship); // Removes relationship with the user.
        await _context.SaveChangesAsync();

        TempData["Message"] = "Friend request declined."; //Message for decline
        return RedirectToAction(nameof(Index));
    }


    // POST: Unfriend someone
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Unfriend(string friendId)
    {
        var currentUser = await _userManager.GetUserAsync(User);
     

        // Find the friendship
        var friendship = await _context.Friendships
            .FirstOrDefaultAsync(f =>
                ((f.RequesterId == currentUser.Id && f.AddresseeId == friendId) ||
                 (f.RequesterId == friendId && f.AddresseeId == currentUser.Id)) &&
                f.Status == FriendshipStatus.Accepted);

        if (friendship == null)
        {
            TempData["Error"] = "Friendship not found.";
            return RedirectToAction(nameof(Index));
        }

        // Remove the friendship from database/
        _context.Friendships.Remove(friendship);
        await _context.SaveChangesAsync();

        TempData["Message"] = "Friend removed successfully."; //Unfriend message
        return RedirectToAction(nameof(Index));
    }

    // POST: Block someone 
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Block(string userId) // Block method
    {
        var currentUser = await _userManager.GetUserAsync(User);
       

        // Find any existing relationships with the user.
        var relationship = await _context.Friendships
            .FirstOrDefaultAsync(f =>
                (f.RequesterId == currentUser.Id && f.AddresseeId == userId) ||
                (f.RequesterId == userId && f.AddresseeId == currentUser.Id));

        if (relationship == null)
        {
            //BLocks the user by creating a new friendshi pthe database, with enum of blocked.
            relationship = new Friendship
            {
                RequesterId = currentUser.Id,
                AddresseeId = userId,
                Status = FriendshipStatus.Blocked,
                CreatedAt = DateTime.Now
            };
            _context.Friendships.Add(relationship);
        }
        else
        {
            // Update existing relationship to blocked
            relationship.Status = FriendshipStatus.Blocked;
            relationship.RespondedAt = DateTime.Now;
            _context.Friendships.Update(relationship);
        }

        await _context.SaveChangesAsync();

        TempData["Message"] = "User has been blocked. They can no longer contact you."; //Message for blocked using Temp Data.
        return RedirectToAction(nameof(Index));
    }
}