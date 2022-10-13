using System;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    [Serializable]
    public class StoreItem : InventoryItem
    {

        public string Name
        {
            get { return Product.Name;  }
        }

        public decimal Price
        {
            get { return Product.Price; }
        }

        public int Id
        {
            get { return Product.Id; }
        }

        public StoreItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }
    }
}
