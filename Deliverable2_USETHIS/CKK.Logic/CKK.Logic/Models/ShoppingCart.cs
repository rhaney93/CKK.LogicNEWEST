using System;
using System.Collections.Generic;
using CKK.Logic.Exceptions;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class ShoppingCart : IShoppingCart
    {
        public Customer Customer;
        private List<ShoppingCartItem> Items;

        public ShoppingCart(Customer customer)
        {
            Customer = customer;
            Items = new List<ShoppingCartItem>();
        }

        public int GetCustomerId { get; set; }
        //needs to be function not property

        public ShoppingCartItem GetProductById(int Id)
        {
            if (Id < 0)
            {
                throw new InvalidIdException("Cannot be a negative number");
            }
            return Items.Find(i => i.Product.Id == Id);
        }


        public ShoppingCartItem AddProduct(Product product, int quantity)
        {

            var existingItem = GetProductById(product.Id);

            if (product.Id < 0)
            {
                throw new InvalidIdException("Cannot be a negative number");
            }

            if (existingItem != null)
            {
                existingItem.Quantity = existingItem.Quantity + quantity;
                return existingItem;
            }

            else
            {
                var newItem = new ShoppingCartItem(product, quantity);
                Items.Add(newItem);
                return newItem;
            }


        }
        public ShoppingCartItem RemoveProduct(int id, int quantity)
        {

            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot be a negative number");
            }

            var productToRemove = GetProductById(id);

            if (productToRemove == null)
            {
                throw new ProductDoesNotExistException("Cannot be a negative number");
            }
            var nextQuantity = productToRemove.Quantity - quantity;

            if (nextQuantity > 0)
            {
                productToRemove.Quantity = nextQuantity;
                return productToRemove;
            }
            else
            {
                Items.Remove(productToRemove);
                productToRemove.Quantity = 0;
                return productToRemove;
            }
        }


        public decimal GetTotal()
        {
            decimal total = 0;
            Items.ForEach(i => total += i.GetTotal());
            return total;
        }
        public List<ShoppingCartItem> GetProducts()
        {
            return Items;
        }
    }

}
