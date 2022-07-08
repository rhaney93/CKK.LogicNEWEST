using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer _customer;
        private List<ShoppingCartItem> _items;

        public ShoppingCart(Customer customer)
        {
            _customer = customer;
            _items = new List<ShoppingCartItem>();
        }

        //Update ShoppingCart to have a public Property for Customer with get and set options
        //Update ShoppingCart to have a public Property for Products with get and set options
        public int Customer { get; set; }
        public int Products { get; set; }





        public ShoppingCartItem GetProductById(int Id)
        {
          return _items.Find(i => i.GetProduct().GetId() == Id);
        }

        
        public ShoppingCartItem AddProduct(Product product, int quantity)
        {
            if (quantity <= 0 || product == null) return null;
            
            var existingItem = GetProductById(product.GetId());
            if (existingItem != null)
            {
                existingItem.SetQuantity(existingItem.GetQuantity() + quantity);
                return existingItem;
            }

            else
            {
                var newItem = new ShoppingCartItem(product, quantity);
                _items.Add(newItem);
                return newItem;
            }
        }
        public ShoppingCartItem RemoveProduct(int id, int quantity)
        {
            if (quantity <= 0) return null;
            
            var productToRemove = GetProductById(id);
            var nextQuantity = productToRemove.GetQuantity() - quantity;

            if (nextQuantity > 0)
            {
                productToRemove.SetQuantity(nextQuantity);
                return productToRemove;
            } else
            {
                _items.Remove(productToRemove);
                productToRemove.SetQuantity(0);
                return productToRemove;
            }
        }
        

        public decimal GetTotal()
        {
            decimal total = 0;
            _items.ForEach(i => total += i.GetTotal());
            return total;
        }
        public List<ShoppingCartItem> GetProducts()
        {
            return _items;
        }
    }
    
}
