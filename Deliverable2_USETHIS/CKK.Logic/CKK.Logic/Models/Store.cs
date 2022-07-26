using System;
using System.Collections.Generic;
using CKK.Logic.Exceptions;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class Store : Entity, IStore
    {

        private List<StoreItem> _items;

        public Store()
        {
            _items = new List<StoreItem>();
        }

        public StoreItem AddStoreItem(Product product, int quantity)
        {

            var existingItem = FindStoreItemById(product.Id);

            if (quantity <= 0)
            {
                throw new InventoryItemStockTooLowException();
            }

            if (existingItem == null)
            {
                var newItem = new StoreItem(product, quantity);
                _items.Add(newItem);
                return newItem;
            }
            else
            {
                existingItem.Quantity = existingItem.Quantity + quantity;
                return existingItem;
            }
        }

        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            var itemToRemove = FindStoreItemById(id);

            if (itemToRemove != null)
            {
                var nextQuantity = Math.Max(itemToRemove.Quantity - quantity, 0);
                itemToRemove.Quantity = nextQuantity;

                if (nextQuantity < 0)
                {
                    throw new ProductDoesNotExistException();
                }
            }
            else if (itemToRemove == null)
            {
                throw new ProductDoesNotExistException();
            }
            else
            {
                return itemToRemove;
            }

            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            //if (itemToRemove == null)
            //{
            //    throw new ProductDoesNotExistException();
            //}

            return itemToRemove;
        }
        public StoreItem FindStoreItemById(int id)
        {
            //if id is less than zero throw exception
            if (id < 0)
            {
                throw new InvalidIdException();
            }
            return _items.Find(i => i.Product.Id == id);
            
        }
        public List<StoreItem> GetStoreItems()
        {
            return _items;
        }


    }
}