
using Linq2DBDapper.Table;
using LinqToDB;
using LinqToDB.Data;
using System.Data;



namespace Linq2DBDapper
{
    internal class LinqRepository
    {
        static DataConnection db = new LinqToDB.Data.DataConnection(ProviderName.PostgreSQL, Config.SqlConnectionString);
        public static List<Customers> GetCustomers()
        {
            return db.GetTable<Customers>().ToList();
        }

        public static List<Orders> GetOrders()
        {
            return db.GetTable<Orders>().ToList();
        }

        public static List<Products> GetProducts()
        {
            return db.GetTable<Products>().ToList();
        }

        public static List<Customers> GetCustomersName(string pattern)
        {
            return db.GetTable<Customers>()
                .Where(x => x.FirstName.Contains(pattern))
                .OrderByDescending(x => x.FirstName)
                .ToList();
        }
               

    }
}
