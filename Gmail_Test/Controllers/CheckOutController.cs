using Microsoft.AspNetCore.Mvc;
using MentalHealthApp.Models;
using Stripe.Checkout;
using Microsoft.AspNetCore.Authorization;

namespace MentalHealthApp.Controllers
{
    [Authorize]
    public class CheckOutController : Controller
    {
        public IActionResult Index()
        {
            List<ProductEntity> productList = new List<ProductEntity>();

            productList = new List<ProductEntity>
            {
                new ProductEntity
                {
                    Product= "Mental Health Hoodie",
                    Rate = 25,
                    Quantity=1,
                    ImagePath="img/Hoodie.png"
                },
                 new ProductEntity
                {
                    Product= "Mental Health Shirt",
                    Rate = 15,
                    Quantity=1,
                    ImagePath="img/Shirt.png"
                },
                    new ProductEntity
                {
                    Product= "Mental Health Shirt",
                    Rate = 2,
                    Quantity=1,
                    ImagePath="img/MentalHealthPin.png"
                }
            };
            return View(productList);
        }

        public IActionResult OrderConfirmation()
        {

            var service = new SessionService();
            Session session = service.Get(TempData["Session"].ToString());
             
            if (session.PaymentStatus == "paid") 
            {

                return View("Success");
            
            }
            return View("Cancelled");

        }


        public IActionResult Cancelled()
        {


            return View();
        }

        public IActionResult Success()
        {


            return View();
        }
        public IActionResult CheckOut(List<ProductEntity> selectedProducts)
        {
            // Filter selected products
            var selectedItems = selectedProducts.Where(p => p.IsSelected && p.Quantity > 0).ToList();

            if (!selectedItems.Any())
            {
                TempData["ErrorMessage"] = "Please select at least one product to checkout.";
                return RedirectToAction("Index");
            }

            // Calculate total amount to check against Stripe minimum
            var totalAmount = selectedItems.Sum(item => item.Rate * item.Quantity);
            if (totalAmount < 0.50m)
            {
                TempData["ErrorMessage"] = "The total amount must be at least $0.50 NZD to proceed with checkout.";
                return RedirectToAction("Index");
            }

            var domain = "https://localhost:7118";
            var options = new SessionCreateOptions
            {
                SuccessUrl = domain + "/CheckOut/OrderConfirmation",
                CancelUrl = domain + "/CheckOut/Cancelled",
                LineItems = new List<SessionLineItemOptions>(),
                Mode = "payment"
            
            };

            foreach (var item in selectedItems)
            {
                var sessionLineItem = new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = (long)(item.Rate * 100), // Convert dollars to cents
                        Currency = "nzd",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = item.Product
                        }
                    },
                    Quantity = item.Quantity // Use the quantity specified by the user
                };

                options.LineItems.Add(sessionLineItem);
            }

            var service = new SessionService();
            Session session = service.Create(options);

            TempData["Session"] = session.Id;
            Response.Headers.Add("Location", session.Url);
            return new StatusCodeResult(303);
        }









    }
}
