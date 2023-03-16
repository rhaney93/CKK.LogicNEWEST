using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CKK.DB.Interfaces;
using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using Dapper;
using Dapper.Contrib.Extensions;

namespace CKK.DB.Repository
{
    internal class ShoppingCartRepository : IShoppingCartRepository
    {
        internal IConnectionFactory Connection { get; set; }

        public ShoppingCartRepository(IConnectionFactory connection)
        {
            this.Connection = connection;
        }

        public async Task<ShoppingCartItem> AddToCart(Product product, int quantity)
        {
            try
            {
                var connection = this.Connection.GetConnection;
                var result = await connection.InsertAsync(new ShoppingCartItem { ProductId = product.Id, Quantity = quantity, ShoppingCartId = 1 });
                return connection.Get<ShoppingCartItem>(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public async Task<bool> ClearCart()
        {
            return await this.Connection.GetConnection.DeleteAllAsync<ShoppingCartItem>();
        }

        public async Task<List<ShoppingCartItem>> GetProducts()
        {
            var connection = this.Connection.GetConnection;
            var result = await connection.QueryAsync<ShoppingCartItem>("SELECT * FROM shoppingcartitems");
            return result.ToList();
        }

        public async Task<decimal> GetTotal()
        {
            throw new NotImplementedException();
        }
    }
}
