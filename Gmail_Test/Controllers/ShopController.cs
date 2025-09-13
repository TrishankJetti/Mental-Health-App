using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MentalHealthApp.Data;
using System.Linq;
using MentalHealthApp.Models;
using System.Threading.Tasks; // Add this for Task


namespace MentalHealthApp.Controllers
{
    public class ShopController : Controller
    {
        private readonly MentalHealthContext _context;

        public ShopController(MentalHealthContext context)
        {
            _context = context;
        }

        // Change to async method and return Task<IActionResult>
        public async Task<IActionResult> Index(string searchString, string priceOrder, ProductCategory? categoryFilter, int? pageNumber)
        {
            pageNumber = pageNumber ?? 1;

            var products = _context.Products.AsQueryable();

            // Apply filters and sorting...
            if (!string.IsNullOrEmpty(searchString))
            {
                products = products.Where(p => p.Name.Contains(searchString) || p.Description.Contains(searchString));
                ViewData["CurrentFilter"] = searchString;
            }

            if (categoryFilter.HasValue)
            {
                products = products.Where(p => p.Category == categoryFilter.Value);
                ViewData["CurrentCategoryFilter"] = categoryFilter.Value;
            }

            products = priceOrder switch
            {
                "price_desc" => products.OrderByDescending(p => p.Price),
                "price_asc" => products.OrderBy(p => p.Price),
                _ => products.OrderBy(p => p.Id)
            };
            ViewData["CurrentPriceOrder"] = priceOrder;

            // Return PaginatedList instead of IEnumerable
            int pageSize = 5;
            var paginatedList = await PaginatedList<Product>.CreateAsync(products.AsNoTracking(), pageNumber.Value, pageSize);

            return View(paginatedList);
        }
    }
}