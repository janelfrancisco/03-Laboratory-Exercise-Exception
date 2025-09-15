using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountRegistration
{
    internal class DatabaseConnection
    {
        // 1. Database  Connection
        private static string connectionString =
            "Server=JCELGFRANCISCO\\SQLEXPRESS;Database=AccountRegistration;Integrated Security=True;";

        
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}
