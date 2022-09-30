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

        //TODO: Method should remove an item from inventory completely-- store no longer carries it
        void DeleteStoreItem(int id);
        
    }
}