using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.DataAccess
{
    internal class DbSettings
    {
        internal const string ConnectionString =
            "Server=(localdb)\\MSSQLLocalDB; Database=Northwind; Integrated Security=true;";
    }
}
