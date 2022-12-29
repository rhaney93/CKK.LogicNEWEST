using CKK.DB.Interfaces;
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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShoppingCart()
        {
            return View(workManager.Products.GetAll());
        }

        public IActionResult CheckOutCustomer([FromQuery] int orderId)
        {
           return View();
        }

        [HttpGet]
        [Route("/Shop/ShoppingCart/Add/{productId}")]
        public IActionResult Add([FromRoute] int quantity)
        {
            return View();
        }
    }
}
