using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ChatBotApp.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> SendMessage(string message)
        {
            // Check if the user is authenticated and has a username
            string username = User.Identity.IsAuthenticated ? User.Identity.Name : "Guest";

            // Create the response using the username
            string response = $"{username} said: {message}";
            return Json(response);
        }
    }
}
