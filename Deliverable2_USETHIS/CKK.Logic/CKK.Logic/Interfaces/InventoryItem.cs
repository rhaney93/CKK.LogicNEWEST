using System;
using CKK.Logic.Exceptions;
using CKK.Logic.Models;

namespace CKK.Logic.Interfaces
{
    public abstract class InventoryItem
    {

        private Product product;
        private int quantity;

        public Product Product;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (quantity > 0)
                {
                        quantity = value;
                        
                }
                else
                    {
                        throw new InventoryItemStockTooLowException("Cannot be a negative number");
                    }
            }
        }


    }
}
