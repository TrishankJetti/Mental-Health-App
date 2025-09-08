using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MentalHealthApp.Data;
using System.Linq;

namespace MentalHealthApp.Controllers
{
    public class ShopController : Controller
    {
        private readonly MentalHealthContext _context;

        public ShopController(MentalHealthContext context)
        {
            _context = context;
        }

        public IActionResult Index(string searchString, string priceOrder)
        {
            var products = _context.Products.AsQueryable();

            // Search filtering
            if (!string.IsNullOrEmpty(searchString))
            {
                products = products.Where(p => p.Name.Contains(searchString) || p.Description.Contains(searchString));
                ViewData["CurrentFilter"] = searchString;
            }

            // Price sorting
            products = priceOrder switch
            {
                "price_desc" => products.OrderByDescending(p => p.Price),
                "price_asc" => products.OrderBy(p => p.Price),
                _ => products.OrderBy(p => p.Id) // Default case order
            };

            return View(products.ToList());
        }


    }
}
