using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace ASP_0002
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chủ yếu là SqlConnection
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Gõ lại bài 1");

            // StringConnectionBuilder
            var stringConnectionBuilder = new SqlConnectionStringBuilder();
            stringConnectionBuilder["Server"] = "localhost,1433";
            stringConnectionBuilder["Database"] = "xtlab";
            stringConnectionBuilder["UID"] = "sa";
            stringConnectionBuilder["PWD"] = "Password123";

            // conver stringconnectionbuilder to String
            var sqlConnection = stringConnectionBuilder.ToString();

            // sqlConnection
            using var connection = new SqlConnection(sqlConnection);

            // Open connection
            connection.Open();

            // Query
            using DbCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select top 10 * from Donhang";

            var dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Console.WriteLine($" KhachahngID : {dataReader["KhachhangID"]} - NgayDatHang : {dataReader["Ngaydathang"]} ");
            }

            // Close Connection
            connection.Close();
        }
    }
}