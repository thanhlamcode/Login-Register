using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AdminLogin
{
    internal class Modify
    {
        SqlCommand sqlCommand; //dùng để truy vấn
        SqlDataReader dataReader; //đọc dữ liệu trong bảng

        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();

                // Kiểm tra xem dataReader có giá trị null không trước khi đọc dữ liệu từ nó
                if (dataReader != null)
                {
                    while (dataReader.Read())
                    {
                        taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                    }
                    // Đóng dataReader sau khi sử dụng
                    dataReader.Close();
                }

                sqlConnection.Close();
            }
            return taiKhoans;
        }
        public void Command(string query)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                sqlCommand = new SqlCommand (query, connection);
                sqlCommand.ExecuteNonQuery(); // thuc thi cau truy van
                connection.Close();
            }
        }
    }
}
