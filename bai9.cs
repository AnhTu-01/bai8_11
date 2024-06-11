using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Chọn chức năng:");
            Console.WriteLine("1. Đảo ngược chuỗi");
            Console.WriteLine("2. Đếm số lượng từ trong chuỗi");
            Console.WriteLine("3. Thoát");
            Console.Write("Lựa chọn của bạn: ");
            
            switch (Console.ReadLine())
            {
                case "1":
                    ReverseString();
                    break;
                case "2":
                    CountWordsInString();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Nhấn phím bất kỳ để thử lại.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void ReverseString()
    {
        Console.Clear();
        Console.Write("Nhập vào một chuỗi kí tự: ");
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);

        Console.WriteLine("Chuỗi đảo ngược: " + reversedString);
        Pause();
    }

    static void CountWordsInString()
    {
        Console.Clear();
        Console.Write("Nhập vào một chuỗi kí tự: ");
        string input = Console.ReadLine();

        string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        int wordCount = words.Length;

        Console.WriteLine("Số lượng từ trong chuỗi: " + wordCount);
        Pause();
    }

    static void Pause()
    {
        Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính.");
        Console.ReadKey();
    }
}