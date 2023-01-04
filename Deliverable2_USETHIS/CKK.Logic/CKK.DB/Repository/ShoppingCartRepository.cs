using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CKK.DB.Interfaces;
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
        public async Task<int> Add(ShoppingCartItem entity)
        {
            try
            {
                var insertStatement = "INSERT INTO ShoppingCartItems(Quantity, ProductId, ShoppingCartId) values(@Quantity,@ProductId,@ShoppingCartId); " +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";
                var result = await this.Connection.GetConnection.QueryAsync<int>(insertStatement, entity);
                entity.ShoppingCartId = result.SingleOrDefault();
            }
            catch
            {
                return -1;
            }

            return entity.ShoppingCartId;
        }

        public ShoppingCartItem AddToCart(string itemName, int quantity)
        {
            throw new NotImplementedException();
        }

        public int ClearCart(int shoppingCartId)
        {
            throw new NotImplementedException();
        }

        public List<ShoppingCartItem> GetProducts(int shoppingCartId)
        {
            var connection = this.Connection.GetConnection;
            return connection.Query<ShoppingCartItem>("SELECT * FROM products").ToList();
        }

        public decimal GetTotal(int ShoppingCartId)
        {
            throw new NotImplementedException();
        }

        public void Ordered(int shoppingCartId)
        {
            throw new NotImplementedException();
        }

        public int Update(ShoppingCartItem entity)
        {
            this.Connection.GetConnection.Update(entity);
            return entity.ShoppingCartId;
        }
    }
}
