using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using NorthwindProject.Entities;

namespace NorthwindProject.DataAccess
{
    public class ProductRepository
    {
        public List<Product> GetAll()
        {
            try
            {
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    return conn.Query<Product>("select * from Products").ToList();
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return new List<Product>();
            }
        }
    }
}
