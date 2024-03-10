using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdminLogin
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\dtlam\OneDrive\Documents\A Code\AdminLogin\AdminLogin\Database1.mdf"";Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
