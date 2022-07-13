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
                quantity = value;
                if (quantity > 0)
                {
                    throw new InventoryItemStockTooLowException();
                }
            }
        }


    }
}
