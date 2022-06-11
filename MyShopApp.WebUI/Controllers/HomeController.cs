using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyShopApp.Business.Abstract;
using MyShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        private ICartService _cartService;

        public HomeController(IProductService productService, ICartService cartService)
        {
            _productService = productService;
            _cartService = cartService;
        }

        public IActionResult Index()
        {

            return View(_productService.GetAll());
        }
        [HttpPost]
        public IActionResult AddCart(int productId, int quantity, int price)
        {
            Cart cart = new Cart()
            {
                ProductId = productId,
                Quantity = quantity,
                TotalPrice = (double)quantity * price
            };
            _cartService.Create(cart);
            return RedirectToAction("Cart");
        }
        public IActionResult Cart()
        {
            var model = _cartService.GetAllWithProduct();
            double totalPrice = 0;
            foreach (var item in model)
            {
                if (DateTime.Now.DayOfWeek.ToString() == "Saturday" || DateTime.Now.DayOfWeek.ToString() == "Sunday")
                {
                    totalPrice += 0.9 * (item.TotalPrice);
                }
                else
                {
                    totalPrice += item.TotalPrice;
                }
            }

            ViewBag.TotalPrice = totalPrice;
            return View(model);
        }
        [HttpPost]
        public IActionResult DeleteCartItem(int cartId)
        {
            var entityId = _cartService.GeyById(cartId);
            _cartService.Delete(entityId);
            return RedirectToAction("Cart");
        }
        [HttpPost]
        public IActionResult QuantityUpdate(int quantity,int cartId,int productId)
        {
            var cart=_cartService.GeyById(cartId);
            var product = _cartService.GetByWithProduct(productId);
            cart.Quantity = quantity;
            cart.TotalPrice = (double)product.Product.Price * quantity;
            //Cart model = new Cart()
            //{
            //    CartId=entityId
            //    Quantity = quantity
            //};
            _cartService.Update(cart);
            return RedirectToAction("Cart");
        }

    }
}
