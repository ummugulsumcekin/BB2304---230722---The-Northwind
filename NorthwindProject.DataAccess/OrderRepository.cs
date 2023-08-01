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
    public class OrderRepository
    {
        public List<Order> GetAll()
        {
            return new List<Order>();
        }

        public Order Find(int id)
        {
            return null;
        }

        public bool Add(Order order)
        {
            // Bu metot veritabanında hem Orders hem de Order Details tablolarına
            // insert gerçekleştirecek
            // Ayrıca bir OrderDetailsRepository sınıfı yazmayacağız
            const string orderInsertSql = @"
INSERT INTO [dbo].[Orders]
([CustomerID],[EmployeeID],[OrderDate],[RequiredDate],[ShippedDate],[ShipVia],[Freight],
[ShipName],[ShipAddress],[ShipCity],[ShipRegion],[ShipPostalCode],[ShipCountry])
VALUES
(@CustomerID,@EmployeeID,@OrderDate,@RequiredDate,@ShippedDate,@ShipVia,@Freight
,@ShipName,@ShipAddress,@ShipCity,@ShipRegion,@ShipPostalCode,@ShipCountry)

SELECT @@IDENTITY";

            const string orderDetailInsertSql = @"
INSERT INTO [dbo].[Order Details]
([OrderID],[ProductID],[UnitPrice],[Quantity],[Discount])
VALUES
(@OrderID,@ProductID,@UnitPrice,@Quantity,@Discount)";

            try
            {
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    // Henüz OrderID yok
                    var orderId = conn.ExecuteScalar<int>(orderInsertSql, order);
                    // OrderID artık belli oldu

                    foreach (var orderDetail in order.OrderDetails)
                    {
                        orderDetail.OrderID = orderId;
                        conn.Execute(orderDetailInsertSql, orderDetail);
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return false;
            }
        }
    }
}
