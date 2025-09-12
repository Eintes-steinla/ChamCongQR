using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamCongQRCode
{
    public class DatabaseHelper
    {
        private static string connectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=ChamCongDB;Integrated Security=True; Trust Server Certificate=True";
            //@"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyCongTrinh;Integrated Security=True; Trust Server Certificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
