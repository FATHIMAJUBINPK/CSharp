using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.DataAccess
{
    internal class DatabaseHelper
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(
                "Data Source=.;Initial Catalog=LibraryDB;Integrated Security=True");
        }
    }
}
