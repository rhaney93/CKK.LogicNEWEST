using System;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class StoreItem : InventoryItem
    {
        public StoreItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }
    }
}
