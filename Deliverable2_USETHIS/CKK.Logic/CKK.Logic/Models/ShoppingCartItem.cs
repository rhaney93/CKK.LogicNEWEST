using System;
using CKK.Logic.Exceptions;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    [Serializable]
    public class ShoppingCartItem
    {
        public ShoppingCartItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }
        public Product Product { get; set; }
        public int ShoppingCartId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        private int quantity { get; set; }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value >= 0)
                {
                    quantity = value;
                }
                else
                {
                    throw new InventoryItemStockTooLowException();
                }
            }
        }
        public decimal GetTotal()
        {
            return this.Quantity * this.Product.Price;
        }
    }
}
