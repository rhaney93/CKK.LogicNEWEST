using System;
using System.Collections.Generic;

namespace CKK.Logic.Models
{
    public interface IShoppingCart
    {
        int GetCustomerId { get; set; }

        ShoppingCartItem AddProduct(Product product, int quantity);
        ShoppingCartItem GetProductById(int Id);
        List<ShoppingCartItem> GetProducts();
        decimal GetTotal();
        ShoppingCartItem RemoveProduct(int id, int quantity);
    }
}