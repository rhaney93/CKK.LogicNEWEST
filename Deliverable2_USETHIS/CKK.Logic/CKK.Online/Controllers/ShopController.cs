using CKK.DB.Interfaces;
using CKK.Logic.Models;
using Microsoft.AspNetCore.Mvc;

namespace CKK.Online.Controllers
{
    public class ShopController: Controller
    {
        private readonly IUnitOfWork workManager;

        public ShopController(IUnitOfWork unit)
        { 
            this.workManager = unit;
        }

        public async Task<IActionResult> Index()
        {
            return View(await workManager.Products.GetAll());
        }

        public async Task<IActionResult> ShoppingCart()
        {
            return View(await workManager.ShoppingCarts.GetProducts());
        }

        [Route("/Shop/ShoppingCart/CheckOut")]
        public async Task<IActionResult> CheckOut()
        {
            
            
            var newOrder = new Order();
            newOrder.OrderId = Guid.NewGuid().GetHashCode();
            newOrder.CustomerId = Guid.NewGuid().GetHashCode();
            newOrder.ShoppingCartId = Guid.NewGuid().GetHashCode();
            newOrder.OrderNumber = Guid.NewGuid().ToString();
            
            newOrder.OrderId = await workManager.Orders.Add(newOrder);
            
            await workManager.ShoppingCarts.ClearCart();
            
            return View(newOrder);
        }

        [HttpGet]
        [Route("/Shop/ShoppingCart/Add/{productId}")]
        public async Task<IActionResult> Add([FromRoute] int productId, [FromQuery] int quantity)
        {
            var product = await workManager.Products.GetById(productId);

            return View(await workManager.ShoppingCarts.AddToCart(product, quantity));
        }
    }
}
