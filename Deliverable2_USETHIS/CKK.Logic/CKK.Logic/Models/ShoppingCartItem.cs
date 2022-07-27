using System;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class ShoppingCartItem : InventoryItem
    {
        public ShoppingCartItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }
        public decimal GetTotal()
        {
            return this.Quantity * this.Product.Price;
        }
    }
}
