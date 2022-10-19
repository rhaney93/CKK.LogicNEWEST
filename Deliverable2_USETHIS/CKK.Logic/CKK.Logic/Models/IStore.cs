using System;
using System.Collections.Generic;
using System.Linq;

namespace CKK.Logic.Models
{
    public interface IStore
    {
        StoreItem AddStoreItem(Product product, int quantity);
        StoreItem FindStoreItemById(int id);
        List<StoreItem> GetStoreItems();
        StoreItem RemoveStoreItem(int id, int quantity);
        void DeleteStoreItem(int id);
        List<StoreItem> GetAllProductsByName(string name);
        List<StoreItem> GetProductsByQuantity();
        List<StoreItem> GetProductsByPrice();
    }
}