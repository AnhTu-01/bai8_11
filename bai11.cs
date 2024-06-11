using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Nhập tên file (bao gồm phần mở rộng, ví dụ: example.txt): ");
        string fileName = Console.ReadLine();

        Console.WriteLine("Nhập nội dung bạn muốn ghi vào file:");
        string content = Console.ReadLine();

        // Ghi nội dung vào file
        WriteToFile(fileName, content);

        // Đọc nội dung từ file và hiển thị lên màn hình
        string readContent = ReadFromFile(fileName);
        Console.WriteLine("\nNội dung đọc từ file:");
        Console.WriteLine(readContent);
    }

    static void WriteToFile(string fileName, string content)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.Write(content);
            }
            Console.WriteLine($"Đã ghi nội dung vào file {fileName} thành công.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi ghi vào file: {ex.Message}");
        }
    }

    static string ReadFromFile(string fileName)
    {
        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }
        catch (Exception ex)
        {
            return $"Lỗi khi đọc file: {ex.Message}";
        }
    }
}