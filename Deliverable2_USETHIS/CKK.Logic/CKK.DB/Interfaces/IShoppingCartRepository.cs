using System.Collections.Generic;
using CKK.Logic.Models;


namespace CKK.DB.Interfaces
{
    internal interface IShoppingCartRepository
    {
        ShoppingCartItem AddToCart(string itemName, int quantity);
        int ClearCart(int shoppingCartId);
        decimal GetTotal(int ShoppingCartId);
        List<ShoppingCartItem> GetProducts(int shoppingCartId);
        void Ordered(int shoppingCartId);
        int Update(ShoppingCartItem entity);
        int Add(ShoppingCartItem entity);
    }
}
