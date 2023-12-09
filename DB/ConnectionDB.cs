using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class ConnectionDB
    {
        public static string SQLServer()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            //servidor
            builder.DataSource = "DESKTOP-HFCROD8\\SQLEXPRESS";

            //Base de datos
            builder.InitialCatalog = "CineDB";

            //Username
            builder.UserID = "sa";

            //password
            builder.Password = "123";

            return builder.ToString();
        }
    }
}
