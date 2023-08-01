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
    // Repository pattern'ına çok benzeyen DAO pattern'ı da mevcuttur
    // DAO: Data Access Object

    public class CategoryRepository
    {
        // GetAll: Veritabanından tüm kayıtları getir
        public List<Category> GetAll()
        {
            const string sqlText = "select * from Categories";

            try
            {
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var categoryList = conn.Query<Category>(sqlText).ToList();
                    return categoryList;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return new List<Category>();
            }
        }

        // Find, GetById: Bildirdiğim Id değerine sahip olan tek kayıdı getir
        public Category Find(int categoryId)
        {
            const string sqlText =
                "select * from Categories where CategoryID = @categoryId";

            try
            {
                using (var sqlConn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var category = sqlConn
                        .QuerySingleOrDefault<Category>(sqlText, new { categoryId });

                    return category;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());

                return null;
            }
        }

        // Add, Create: Bildirdiğim nesneyi veritabanına (satır olarak) ekle
        // Normalde bir repository sınıfında yer alan Add, Update, Remove (veri
        // modifikasyonu) metotları bir dönüş tipine sahip olmaz.
        // Ancak bu proje
        public bool Add(Category category)
        {
            const string sqlText = @"
insert into Categories (CategoryName, Description)
values (@CategoryName, @Description)";

            try
            {
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    conn.Execute(sqlText, category);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return false;
            }
        }

        // Update: Bildirdiğim nesneyi (satırı) veritabanında güncelle
        public bool Update(Category category)
        {
            const string sqlText = @"
update Categories
set
    CategoryName = @CategoryName,
    Description = @Description
where CategoryID = @CategoryID";

            try
            {
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var affectedRows = conn.Execute(sqlText, category);

                    return affectedRows > 0;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return false;
            }
        }

        // Remove, Delete: Bildirdiğim nesneyi (satırı) veritabanından sil
        public bool Remove(Category category)
        {
            const string sqlText = "delete from Categories where CategoryID = @CategoryID";

            try
            {
                using (var sqlConn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var affectedRows = sqlConn.Execute(sqlText, category);
                    return affectedRows > 0;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return false;
            }
        }

        public bool Remove(int categoryId)
        {
            var category = new Category() { CategoryID = categoryId };

            return Remove(category);
        }
    }
}
