using System;
using System.Collections.Generic;
using System.Linq;
using CKK.Logic.Exceptions;
using CKK.Logic.Interfaces;


namespace CKK.Logic.Models
{
    public class Store : Entity, IStore
    {
        static int lastId = 1;
        static int generateId()
        {
            return lastId++;
        }
        private List<StoreItem> _items;

        public Store()
        {
            _items = new List<StoreItem>();
        }

        public StoreItem AddStoreItem(Product product, int quantity)
        {

            if (product.Id == 0)
            {
                product.Id = generateId();
                
            }
            var existingItem = FindStoreItemById(product.Id);

            if (quantity <= 0)
            {
                throw new InventoryItemStockTooLowException("Cannot be a negative number");
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
                    throw new ProductDoesNotExistException("Cannot be a negative number");
                }
            }
            else if (itemToRemove == null)
            {
                throw new ProductDoesNotExistException("Cannot be a negative number");
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
                throw new InvalidIdException("Cannot be a negative number");
            }
            return _items.Find(i => i.Product.Id == id);
            
        }
        public List<StoreItem> GetStoreItems()
        {
            return _items;
        }

        public void DeleteStoreItem(int id)
        {
            _items = _items.Where(i => i.Product.Id != id).ToList();
            
        }
        public List<StoreItem> GetAllProductsByName(string name)
        {
            return this.GetStoreItems()
                .FindAll(item => item.Name.Contains(name))
                .ToList();
        }

        public List<StoreItem> GetProductsByQuantity()
        {
            return this.GetStoreItems()
                .OrderBy(item => item.Quantity)
                .ToList();
        }

        public List<StoreItem> GetProductsByPrice()
        {
            return this.GetStoreItems()
                .OrderBy(item => item.Price)
                .ToList();
        }
    }
}