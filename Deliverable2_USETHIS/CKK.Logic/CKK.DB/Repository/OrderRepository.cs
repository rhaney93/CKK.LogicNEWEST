using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CKK.DB.Interfaces;
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
        public int Add(Order entity)
        {
            try
            {
                var insertStatement = "INSERT INTO Orders(OrderNumber, CustomerId, ShoppingCartId) values(@OrderNumber,@CustomerId,@ShoppingCartId); " +
                    "SELECT CAST(SCOPE_IDENTITY() as int)";
                var newOrderId = this.Connection.GetConnection.Query<int>(insertStatement, entity).SingleOrDefault();
                entity.OrderId = newOrderId;
            }
            catch
            {
                return -1;
            }

            return entity.OrderId;
        }

        public int Delete(int orderId)
        {
            this.Connection.GetConnection.Delete(new Order() { OrderId = orderId });
            return orderId;
        }

        public List<Order> GetAll()
        {
            var connection = this.Connection.GetConnection;
            return connection.Query<Order>("SELECT * FROM orders").ToList();
        }

        public Order GetById(int orderId)
        {
            var connection = this.Connection.GetConnection;
            return connection.Query<Order>("SELECT * FROM orders WHERE OrderId=@OrderId", new { OrderId = orderId }).FirstOrDefault();
        }

        public Order GetOrderByCustomerId(int customerId)
        {
            var connection = this.Connection.GetConnection;
            return connection.Query<Order>("SELECT * FROM orders WHERE CustomerId=@CustomerId", new { CustomerId = customerId })
                .FirstOrDefault();
        }

        public int Update(Order entity)
        {
            this.Connection.GetConnection.Update(entity);
            return entity.CustomerId;
        }
    }
}
