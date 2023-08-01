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
    public class EmployeeRepository
    {
        public List<Employee> GetAll()
        {
            try
            {
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    return conn.Query<Employee>("select * from Employees").ToList();
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                throw;
            }
        }

        public Employee Find(int employeeId)
        {
            try
            {
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    return conn
                        .QuerySingleOrDefault<Employee>("select * from Employees where EmployeeID = @id", new { id = employeeId });
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                throw;
            }
        }

        public bool Update(Employee employee)
        {
            const string sqlText = @"
UPDATE [dbo].[Employees]
   SET [LastName] = @LastName
      ,[FirstName] = @FirstName
      ,[Title] = @Title
      ,[TitleOfCourtesy] = @TitleOfCourtesy
      ,[BirthDate] = @BirthDate
      ,[HireDate] = @HireDate
      --,[Address] = @Address
      --,[City] = @City
      --,[Region] = @Region
      --,[PostalCode] = @PostalCode
      --,[Country] = @Country
      --,[HomePhone] = @HomePage
      --,[Extension] = @Extension
      --,[Photo] = @Photo
      --,[Notes] = @Notes
      ,[ReportsTo] = @ReportsTo
      --,[PhotoPath] = @PhotoPath
 WHERE EmployeeID = @EmployeeID";

            try
            {
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var affectedRows = conn.Execute(sqlText, employee);

                    return affectedRows > 0;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return false;
            }
        }

        public bool Remove(Employee employee)
        {
            return false;
        }
    }
}
