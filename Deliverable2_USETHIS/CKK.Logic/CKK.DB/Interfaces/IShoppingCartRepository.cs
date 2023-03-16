using System.Collections.Generic;
using System.Threading.Tasks;
using CKK.Logic.Models;


namespace CKK.DB.Interfaces
{
    public interface IShoppingCartRepository
    {
        Task<ShoppingCartItem> AddToCart(Product product, int quantity);
        Task<bool> ClearCart();
        Task<decimal> GetTotal();
        Task<List<ShoppingCartItem>> GetProducts();
    }
}
