using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.DB.Interfaces;



namespace CKK.DB.Interfaces
{
    internal interface IUnitOfWork
    {
        IProductRepository Products { get; }
        IOrderRepository Orders { get; }
        IShoppingCartRepository ShoppingCarts { get; }
    }
}
