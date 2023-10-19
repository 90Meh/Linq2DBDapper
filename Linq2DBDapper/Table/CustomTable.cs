using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Npgsql;


namespace Linq2DBDapper.Table
{
    internal class CustomTable
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public List<CustomTable> GetCustomTables()
        {
            var query = @"SELECT c.ID, ""FirstName"", ""LastName"", o.""ProductID"", 
            ""Quantity"", p.""Price""
            FROM ""Customers"" AS c, ""Orders"" AS ""o"",""Products"" AS p
            WHERE o.""CustomerID""  = C.id  AND o.""ProductID"" = p.id AND c.""Age"" > 30 AND o.""ProductID"" = 11
            ORDER BY c.id;";

            using (var connection = new NpgsqlConnection(Config.SqlConnectionString))
            {

                var list = connection.Query<CustomTable>(query);
                return list.ToList();
            }
        }
    }


}
