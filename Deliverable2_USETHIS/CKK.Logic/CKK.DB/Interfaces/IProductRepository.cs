using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CKK.Logic.Models;

//Inherit from IGenericRepository<Product>
//List<Product> GetByName(string name);

namespace CKK.DB.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetByName(string name);
    }
}
