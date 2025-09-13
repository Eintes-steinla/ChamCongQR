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
            @"Data Source=10.95.87.141,1433;Initial Catalog=QuanLyCongNhan;User ID=minh;Password=123456;TrustServerCertificate=True;";
            //@"Data Source=.\SQLEXPRESS;Initial Catalog=ChamCongDB;Integrated Security=True; Trust Server Certificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
