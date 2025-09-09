using Microsoft.AspNetCore.Mvc;

namespace MentalHealthApp.Controllers
{
    public class QuotesController : Controller
    {
        public IActionResult Index()
        {
            var quotes = new List<string> // Creates a lsit full of different positive affirmations/quotes. 
            {
                "You are enough just as you are.",
                "Small steps are still progress.",
                "Be gentle with yourself today.",
                "Your mental health matters.",
                "It's okay to ask for help.",
                "Embrace the journey, not just the destination.",
                "Peace begins with a smile.",
                "Let go of what you can't control.",
                "Your story is still being written.",
                "One day at a time.",
                "Believe in your inner strength.",
                "You deserve kindness and compassion.",
                "Rest is productive.",
                "Feelings are visitors, let them come and go.",
                "You are not alone.",
                "Hope is a powerful thing.",
                "Take time to nourish your soul.",
                "Your best is enough.",
                "Choose progress over perfection.",
                "Healing is not linear."
            };

            var random = new Random();  //Creates a new random number and stores it as the random variable
            var quote = quotes[random.Next(quotes.Count)];

            ViewData["Quote"] = quote;

            return View();
        }
    }
}