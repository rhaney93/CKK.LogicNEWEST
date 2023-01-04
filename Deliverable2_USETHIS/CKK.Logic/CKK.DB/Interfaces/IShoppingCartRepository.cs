using System.Collections.Generic;
using System.Threading.Tasks;
using CKK.Logic.Models;


namespace CKK.DB.Interfaces
{
    public interface IShoppingCartRepository
    {
        Task<ShoppingCartItem> AddToCart(string itemName, int quantity);
        Task<int> ClearCart(int shoppingCartId);
        Task<decimal> GetTotal(int ShoppingCartId);
        Task<List<ShoppingCartItem>> GetProducts(int shoppingCartId);
        void Ordered(int shoppingCartId);
        Task<int> Update(ShoppingCartItem entity);
        Task<int> Add(ShoppingCartItem entity);
    }
}
