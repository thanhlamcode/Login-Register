using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;

namespace AdminLogin
{
    class TextToJsonConverter
    {
        public static void ConvertTextToJson(string inputFilePath, string outputFilePath)
        {
            try
            {
                // Đọc dữ liệu từ tệp văn bản vào một chuỗi
                string textData = File.ReadAllText(inputFilePath);

                // Phân tích cú pháp của chuỗi văn bản thành một đối tượng JSON
                JObject jsonObject = JObject.Parse(textData);

                // Ghi đối tượng JSON vào tệp JSON mới
                File.WriteAllText(outputFilePath, jsonObject.ToString());

                Console.WriteLine("Converted text file to JSON successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

    }
}
