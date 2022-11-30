using System;
using System.Collections.Generic;
using CKK.Logic.Models;

//Inherit from IGenericRepository<Product>
//List<Product> GetByName(string name);

namespace CKK.DB.Interfaces
{
    internal interface IProductRepository : IGenericRepository<Product>
    {
        List<Product> GetByName(string name);
    }
}
