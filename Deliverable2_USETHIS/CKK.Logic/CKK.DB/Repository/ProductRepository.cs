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
        public async Task<int> Add(Product entity)
        {
            try {
                var insertStatement = "INSERT INTO Products(Price, Quantity, Name) values(@Price,@Quantity,@Name); SELECT CAST(SCOPE_IDENTITY() as int)";
                var result = await this.Connection.GetConnection.QueryAsync<int>(insertStatement, entity);
                entity.Id = result.SingleOrDefault();
            } catch {
                return -1;
            }

            return entity.Id;
        }

        public async Task<int> Delete(int id)
        {
            await this.Connection.GetConnection.DeleteAsync(new Product() { Id = id });
            return id;
        }

        public async Task<List<Product>> GetAll()
        {
            var connection = this.Connection.GetConnection;
            var result = await connection.QueryAsync<Product>("SELECT * FROM products", null);
            return result.ToList();
        }

        public async Task<Product> GetById(int id)
        {
            var connection = this.Connection.GetConnection;
            var result = await connection.QueryAsync<Product>("SELECT * FROM products WHERE Id=@Id", new { Id = id });
            return result.FirstOrDefault();
        }

        public async Task<List<Product>> GetByName(string name)
        {
            var connection = this.Connection.GetConnection;
            var result = await connection.QueryAsync<Product>("SELECT * FROM products WHERE Name=@Name", new { Name = name });
             return result.ToList();
        }

        public async Task<int> Update(Product entity)
        {
            await this.Connection.GetConnection.UpdateAsync(entity);
            return entity.Id;
        }
    }
}
