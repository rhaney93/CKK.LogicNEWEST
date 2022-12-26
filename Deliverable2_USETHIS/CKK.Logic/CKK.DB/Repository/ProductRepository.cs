using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.DB.Interfaces;
using CKK.Logic.Models;
using Dapper;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace CKK.DB.Repository
{
    public class ProductRepository : IProductRepository
    {
        internal IConnectionFactory Connection { get; set; }

        public ProductRepository(IConnectionFactory connection)
        {
            this.Connection = connection;
        }
        public int Add(Product entity)
        {
            try {
                var insertStatement = "INSERT INTO Products(Price, Quantity, Name) values(@Price,@Quantity,@Name); SELECT CAST(SCOPE_IDENTITY() as int)";
                var newProductId = this.Connection.GetConnection.Query<int>(insertStatement, entity).SingleOrDefault();
                entity.Id = newProductId;
            } catch {
                return -1;
            }

            return entity.Id;
        }

        public int Delete(int id)
        {
            this.Connection.GetConnection.Delete(new Product() { Id = id });
            return id;
        }

        public List<Product> GetAll()
        {
            var connection = this.Connection.GetConnection;
            return connection.Query<Product>("SELECT * FROM products", null)
                .ToList();
        }

        public Product GetById(int id)
        {
            var connection = this.Connection.GetConnection;
            return connection.Query<Product>("SELECT * FROM products WHERE Id=@Id", new { Id = id })
                .FirstOrDefault();
        }

        public List<Product> GetByName(string name)
        {
            var connection = this.Connection.GetConnection;
            return connection.Query<Product>("SELECT * FROM products WHERE Name=@Name", new { Name = name })
                .ToList();
        }

        public int Update(Product entity)
        {
            this.Connection.GetConnection.Update(entity);
            return entity.Id;
        }
    }
}
