using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class Store : Entity
    {
        
        private List<StoreItem> _items;

        public Store()
        {
            _items = new List<StoreItem>();
        }

        //Same question as in Customer
        public int Id { get; set; }
        public string Name { get; set; }
        public StoreItem AddStoreItem(Product product, int quantity)
        {
            var existingItem = FindStoreItemById(product.GetId());
            if (quantity <= 0)
            {
                return null;
            }
            if (existingItem == null)
            {
                var newItem = new StoreItem(product, quantity);
                _items.Add(newItem);
                return newItem;
            } 
            else
            {
                existingItem.SetQuantity(existingItem.GetQuantity() + quantity);
                return existingItem;
            }
        }

        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            var itemToRemove = FindStoreItemById(id);
            if (itemToRemove != null)
            {
                var nextQuantity = Math.Max(itemToRemove.GetQuantity() - quantity, 0);
                itemToRemove.SetQuantity(nextQuantity);
            }

            return itemToRemove;
        }

        public List<StoreItem> GetStoreItems()
        {
            return _items;
        }
        public StoreItem FindStoreItemById(int id)
        {
            return _items.Find(i => i.GetProduct().GetId() == id);
        }
       
    }
}