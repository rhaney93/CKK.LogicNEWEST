using System;
using System.Collections.Generic;

namespace CKK.Logic.Models
{
    public interface IStore
    {
        StoreItem AddStoreItem(Product product, int quantity);
        StoreItem FindStoreItemById(int id);
        List<StoreItem> GetStoreItems();
        StoreItem RemoveStoreItem(int id, int quantity);
    }
}