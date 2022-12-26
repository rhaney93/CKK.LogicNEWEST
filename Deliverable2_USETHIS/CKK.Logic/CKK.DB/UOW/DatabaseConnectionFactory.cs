using System.Data;
using System.Data.Common;
using CKK.DB.Interfaces;
using System.Configuration;


namespace CKK.DB.UOW
{
    public class DatabaseConnectionFactory : IConnectionFactory
    {
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }


        public IDbConnection GetConnection
        {
            get
            {
                DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
                System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder();
                builder["Data Source"] = "(localdb)\\MSSQLLocalDB";
                builder["Initial Catalog"] = "StructuredProjectDB";
                builder["integrated Security"] = true;

                var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
                var conn = factory.CreateConnection();
                conn.ConnectionString = builder.ConnectionString;
                conn.Open();
                return conn;
            }
        }
    }
}
