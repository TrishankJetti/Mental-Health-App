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

            ViewData["CurrentFilter"] = searchString;
            ViewData["PriceSortParm"] = string.IsNullOrEmpty(priceOrder) ? "price_desc" : "";

            if (!string.IsNullOrEmpty(searchString))
            {
                products = products.Where(p =>
                    p.Name.Contains(searchString) || p.Description.Contains(searchString));
            }

            switch (priceOrder)
            {
                case "price_desc":
                    products = products.OrderByDescending(p => p.Price);
                    break;
                default:
                    products = products.OrderBy(p => p.Price);
                    break;
            }

            return View(products.ToList());
        }
    }
}
