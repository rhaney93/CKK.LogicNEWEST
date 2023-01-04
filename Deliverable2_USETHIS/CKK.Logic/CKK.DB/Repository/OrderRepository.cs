using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CKK.DB.Interfaces;
using CKK.DB.Repository;
using CKK.Logic.Models;
using Dapper;
using Dapper.Contrib.Extensions;

namespace CKK.DB.Repository
{
    public class OrderRepository : IOrderRepository
    {

        internal IConnectionFactory Connection { get; set; }

        public OrderRepository(IConnectionFactory connection)
        {
            this.Connection = connection;
        }
        public async Task<int> Add(Order entity)
        {
            try
            {
                var insertStatement = "INSERT INTO Orders(OrderNumber, CustomerId, ShoppingCartId) values(@OrderNumber,@CustomerId,@ShoppingCartId); " +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";
                var result = await this.Connection.GetConnection.QueryAsync<int>(insertStatement, entity);
                entity.OrderId = result.SingleOrDefault();
            }
            catch
            {
                return -1;
            }

            return entity.OrderId;
        }

        public async Task<int> Delete(int orderId)
        {
            await this.Connection.GetConnection.DeleteAsync(new Order() { OrderId = orderId });
            return orderId;
        }

        public async Task<List<Order>> GetAll()
        {
            var connection = this.Connection.GetConnection;
            var result = await connection.QueryAsync<Order>("SELECT * FROM orders");
            return result.ToList();
        }

        public async Task<Order> GetById(int orderId)
        {
            var connection = this.Connection.GetConnection;
            var result = await connection.QueryAsync<Order>("SELECT * FROM orders WHERE OrderId=@OrderId", new { OrderId = orderId });
            return result.FirstOrDefault();
        }

        public async Task<Order> GetOrderByCustomerId(int customerId)
        {
            var connection = this.Connection.GetConnection;
            var result = await connection.QueryAsync<Order>("SELECT * FROM orders WHERE CustomerId=@CustomerId", new { CustomerId = customerId });
            return result.FirstOrDefault();
        }

        public async Task<int> Update(Order entity)
        {
            await this.Connection.GetConnection.UpdateAsync(entity);
            return entity.CustomerId;
        }
    }
}
