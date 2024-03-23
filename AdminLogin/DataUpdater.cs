using System;
using System.Data.SqlClient;
using System.IO;
using Newtonsoft.Json;

public class DataUpdater
{
    private string connectionString;
    private string jsonFilePath;

    public DataUpdater(string dbConnectionString, string jsonFilePath)
    {
        this.connectionString = dbConnectionString;
        this.jsonFilePath = jsonFilePath;
    }

    public void UpdateDataFromJsonToDatabase()
    {
        try
        {
            string jsonData = File.ReadAllText(jsonFilePath);
            dynamic jsonObject = JsonConvert.DeserializeObject(jsonData);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Manager (TenTaiKhoan, timeplay, soLanDangNhap, luongBossTieuDiet, level, diemCaoNhat, [x-positon], [y-position], [z-position], [y-rotation], scence) " +
                               "VALUES (@TenTaiKhoan, @timeplay, @soLanDangNhap, @luongBossTieuDiet, @level, @diemCaoNhat, @xPosition, @yPosition, @zPosition, @yRotation, @_sceneNow)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenTaiKhoan", jsonObject.characterName);
                command.Parameters.AddWithValue("@timeplay", 0); // Change this to the appropriate value
                command.Parameters.AddWithValue("@soLanDangNhap", 0); // Change this to the appropriate value
                command.Parameters.AddWithValue("@luongBossTieuDiet", 0); // Change this to the appropriate value
                command.Parameters.AddWithValue("@level", jsonObject.characterLevel);
                command.Parameters.AddWithValue("@diemCaoNhat", 0); // Change this to the appropriate value
                command.Parameters.AddWithValue("@xPosition", jsonObject.xPosition);
                command.Parameters.AddWithValue("@yPosition", jsonObject.yPosition);
                command.Parameters.AddWithValue("@zPosition", jsonObject.zPosition);
                command.Parameters.AddWithValue("@yRotation", jsonObject.yRotation);
                command.Parameters.AddWithValue("@_sceneNow", jsonObject._sceneNow);

                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while updating data from JSON to database: " + ex.Message);
        }
    }

    public void UpdateDataFromDatabaseToJson()
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TOP 1 * FROM Manager";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    dynamic jsonObject = new
                    {
                        characterName = reader["TenTaiKhoan"],
                        characterLevel = reader["level"],
                        xPosition = reader["x-positon"],
                        yPosition = reader["y-position"],
                        zPosition = reader["z-position"],
                        yRotation = reader["y-rotation"],
                        _sceneNow = reader["scence"]
                    };

                    string jsonData = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                    File.WriteAllText(jsonFilePath, jsonData);
                }

                reader.Close();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while updating data from database to JSON: " + ex.Message);
        }
    }
}
