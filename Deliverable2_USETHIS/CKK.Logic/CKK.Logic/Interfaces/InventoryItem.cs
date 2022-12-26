using System;
using CKK.Logic.Exceptions;
using CKK.Logic.Models;

namespace CKK.Logic.Interfaces
{
    [Serializable]
    public abstract class InventoryItem
    {
        private int _quantity;

        public Product Product;
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value >= 0)
                {
                    _quantity = value;  
                }
                else
                {
                    throw new InventoryItemStockTooLowException();
                }
            }
        }
    }
}
