using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace ASP_0001
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // tạo chuỗi kết nối thủ công
            // string sqlConnection = "Data Source = localhost,1433;Initial Catalog =xtlab;User ID=sa;Password=Password123";

            // tạo chuỗi kết nối bằng sqlconnectionbuilder
            var sqlStringBuilder = new SqlConnectionStringBuilder();
            sqlStringBuilder["Server"] = "localhost,1433";
            sqlStringBuilder["Database"] = "xtlab";
            sqlStringBuilder["UID"] = "sa";
            sqlStringBuilder["PWD"] = "Password123";

            var sqlStringConnection = sqlStringBuilder.ToString();
            Console.WriteLine(sqlStringConnection);

            // Tạo lớp connection
            using var connection = new SqlConnection(sqlStringConnection);
            Console.WriteLine(connection.State);

            // mở truy vấn
            connection.Open();

            // truy vấn
            using DbCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT TOP(5) * FROM Sanpham";

            var dataReader = command.ExecuteReader();
            dataReader.Read();

            while (dataReader.Read())
            {
                Console.WriteLine($" {dataReader["TenSanPham"],10} ");
            }

            // đóng truy vấn
            connection.Close();

        }
    }
}