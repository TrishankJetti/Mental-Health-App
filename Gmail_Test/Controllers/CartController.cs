using Microsoft.AspNetCore.Mvc;
using MentalHealthApp.Models;
using Newtonsoft.Json;
using Stripe.Checkout;

public class CartController : Controller
{
    private const string CartSessionKey = "Cart";

    private List<CartItem> GetCart()
    {
        var cartJson = HttpContext.Session.GetString(CartSessionKey);
        return string.IsNullOrEmpty(cartJson)
            ? new List<CartItem>()
            : JsonConvert.DeserializeObject<List<CartItem>>(cartJson);
    }

    private void SaveCart(List<CartItem> cart)
    {
        var cartJson = JsonConvert.SerializeObject(cart);
        HttpContext.Session.SetString(CartSessionKey, cartJson);
    }

    public IActionResult Index()
    {
        var cart = GetCart();
        return View(cart);
    }

    [HttpPost]
    public IActionResult Add(int productId, string productName, decimal price, int quantity, string imageUrl)
    {
        var cart = GetCart();
        var existing = cart.FirstOrDefault(c => c.ProductId == productId);

        if (existing != null)
            existing.Quantity += quantity;
        else
            cart.Add(new CartItem { ProductId = productId, ProductName = productName, Price = price, Quantity = quantity, ImageUrl = imageUrl });

        SaveCart(cart);
        TempData["Toast"] = $"{productName} added to cart!";
        return RedirectToAction("Index", "Shop");
    }
    [HttpPost]
    public IActionResult AddWithToast(int productId, string productName, decimal price, int quantity, string imageUrl)
    {
        var cart = GetCart();
        var existing = cart.FirstOrDefault(c => c.ProductId == productId);

        if (existing != null)
            existing.Quantity += quantity;
        else
            cart.Add(new CartItem { ProductId = productId, ProductName = productName, Price = price, Quantity = quantity, ImageUrl = imageUrl });

        SaveCart(cart);
        TempData["Toast"] = $"{productName} added to cart!";
        return RedirectToAction("Index", "Shop");
    }

    [HttpPost]
    public IActionResult Update(int productId, int quantity)
    {
        var cart = GetCart();
        var item = cart.FirstOrDefault(c => c.ProductId == productId);

        if (item != null)
        {
            if (quantity <= 0)
                cart.Remove(item);
            else
                item.Quantity = quantity;
        }

        SaveCart(cart);
        return RedirectToAction("Index");
    }

    public IActionResult Clear()
    {
        SaveCart(new List<CartItem>());
        return RedirectToAction("Index");
    }

    public IActionResult Checkout()
    {
        var cart = GetCart();

        if (!cart.Any())
        {
            TempData["Toast"] = "Your cart is empty.";
            return RedirectToAction("Index");
        }

        var domain = $"{Request.Scheme}://{Request.Host}";
        var options = new SessionCreateOptions
        {
            PaymentMethodTypes = new List<string> { "card" },
            LineItems = cart.Select(item => new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions
                {
                    UnitAmountDecimal = item.Price * 100, // Stripe expects cents so multiply by 100 for dollars.
                    Currency = "nzd",
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = item.ProductName
                    }
                },
                Quantity = item.Quantity
            }).ToList(),
            Mode = "payment",
            SuccessUrl = domain + Url.Action("Success", "Cart"),
            CancelUrl = domain + Url.Action("Cancelled", "Cart")
        };

        var service = new SessionService();
        var session = service.Create(options);

        return Redirect(session.Url);
    }

    // Success page
    public IActionResult Success()
    {
        // Optionally clear the cart on success
        SaveCart(new List<CartItem>());
        return View();
    }

    // Cancelled page
    public IActionResult Cancelled()
    {
        return View();
    }
}
