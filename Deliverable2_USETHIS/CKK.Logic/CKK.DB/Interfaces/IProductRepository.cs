using System;
using System.Collections.Generic;
using CKK.Logic.Models;

//Inherit from IGenericRepository<Product>
//List<Product> GetByName(string name);

namespace CKK.DB.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        List<Product> GetByName(string name);
    }
}
