using System.Data;

namespace CKK.DB.Interfaces
{
    internal interface IConnectionFactory
    {
        IDbConnection GetConnection { get; }
    }
}
