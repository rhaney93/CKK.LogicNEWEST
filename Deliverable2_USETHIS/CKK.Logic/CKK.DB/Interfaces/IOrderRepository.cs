using CKK.Logic.Models;

namespace CKK.DB.Interfaces
{
    internal interface IOrderRepository : IGenericRepository<Order>
    {
        Order GetOrderByCustomerId(int id);
    }
}
