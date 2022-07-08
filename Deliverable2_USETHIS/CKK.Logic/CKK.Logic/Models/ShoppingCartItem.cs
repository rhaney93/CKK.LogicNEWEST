using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCartItem
    {
        private Product _product;
        private int _quantity;


        public ShoppingCartItem(Product product, int quantity)
        {
            _product = product;
            _quantity = quantity;
        }
        //Same question as in Customer
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public decimal GetTotal()
        {
            return _quantity * Product.Price;
        }
    }
}
