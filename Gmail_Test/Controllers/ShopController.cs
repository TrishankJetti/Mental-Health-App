using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MentalHealthApp.Data;
using System.Linq;
using MentalHealthApp.Models; // Make sure to include this for ProductCategory enum

namespace MentalHealthApp.Controllers
{
    public class ShopController : Controller
    {
        private readonly MentalHealthContext _context;

        public ShopController(MentalHealthContext context)
        {
            _context = context;
        }

        public IActionResult Index(string searchString, string priceOrder, ProductCategory? categoryFilter)
        {
            // Start with all products
            var products = _context.Products.AsQueryable();

            // 1. Apply Search Filtering
            if (!string.IsNullOrEmpty(searchString))
            {
                products = products.Where(p => p.Name.Contains(searchString) || p.Description.Contains(searchString));
                ViewData["CurrentFilter"] = searchString; // Keep search term in the input field
            }

            // 2. Apply Category Filtering
            if (categoryFilter.HasValue)
            {
                products = products.Where(p => p.Category == categoryFilter.Value);
                ViewData["CurrentCategoryFilter"] = categoryFilter.Value; // Keep selected category in dropdown
            }

            // 3. Apply Price Sorting
            products = priceOrder switch
            {
                "price_desc" => products.OrderByDescending(p => p.Price),
                "price_asc" => products.OrderBy(p => p.Price),
                _ => products.OrderBy(p => p.Id) // Default sort
            };
            ViewData["CurrentPriceOrder"] = priceOrder; 

            // Execute the query and return the results
            return View(products.ToList());
        }
    }
}