using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Chọn chức năng:");
            Console.WriteLine("1. Hiển thị bảng mã ASCII");
            Console.WriteLine("2. Hiển thị bảng mã UTF-8 của trang mã 65001");
            Console.WriteLine("3. Phát tiếng beep khi nhấn phím Space");
            Console.WriteLine("4. Đếm số lần xuất hiện của mỗi kí tự trong chuỗi");
            Console.WriteLine("5. Thoát");
            Console.Write("Lựa chọn của bạn: ");
            
            switch (Console.ReadLine())
            {
                case "1":
                    DisplayASCIITable();
                    break;
                case "2":
                    DisplayUTF8Table();
                    break;
                case "3":
                    BeepOnSpace();
                    break;
                case "4":
                    CountCharacterOccurrences();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Nhấn phím bất kỳ để thử lại.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void DisplayASCIITable()
    {
        Console.Clear();
        Console.WriteLine("ASCII Table:");
        for (int i = 0; i <= 127; i++)
        {
            Console.WriteLine($"{i} : {(char)i}");
        }
        Pause();
    }

    static void DisplayUTF8Table()
    {
        Console.Clear();
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("UTF-8 Table (Code Page 65001):");

        for (int i = 0; i <= 127; i++)
        {
            byte[] utf8Bytes = Encoding.UTF8.GetBytes(new char[] { (char)i });
            string hex = BitConverter.ToString(utf8Bytes);
            Console.WriteLine($"{i} : {(char)i} (UTF-8: {hex})");
        }
        Pause();
    }

    static void BeepOnSpace()
    {
        Console.Clear();
        Console.WriteLine("Nhấn phím Space để phát tiếng beep. Nhấn phím Esc để thoát.");
        while (true)
        {
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Spacebar)
            {
                Console.Beep();
            }
            else if (key == ConsoleKey.Escape)
            {
                break;
            }
        }
    }

    static void CountCharacterOccurrences()
    {
        Console.Clear();
        Console.Write("Nhập vào một chuỗi kí tự: ");
        string input = Console.ReadLine();

        Dictionary<char, int> characterCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (characterCount.ContainsKey(c))
            {
                characterCount[c]++;
            }
            else
            {
                characterCount[c] = 1;
            }
        }

        Console.WriteLine("Kết quả đếm số lần xuất hiện của mỗi kí tự:");
        foreach (var item in characterCount)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
        Pause();
    }

    static void Pause()
    {
        Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính.");
        Console.ReadKey();
    }
}