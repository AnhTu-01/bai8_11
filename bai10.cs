using System;

struct SinhVien
{
    public string Ten;
    public double Diem;
}

class Program
{
    static void Main()
    {
        Console.Write("Nhập số lượng sinh viên: ");
        int n = int.Parse(Console.ReadLine());

        SinhVien[] danhSachSinhVien = new SinhVien[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập thông tin cho sinh viên thứ {i + 1}:");
            Console.Write("Tên: ");
            danhSachSinhVien[i].Ten = Console.ReadLine();
            Console.Write("Điểm: ");
            danhSachSinhVien[i].Diem = double.Parse(Console.ReadLine());
        }

        double tongDiem = 0;
        Console.WriteLine("\nThông tin của từng sinh viên:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Sinh viên {i + 1}: Tên: {danhSachSinhVien[i].Ten}, Điểm: {danhSachSinhVien[i].Diem}");
            tongDiem += danhSachSinhVien[i].Diem;
        }

        double diemTrungBinh = tongDiem / n;
        Console.WriteLine($"\nĐiểm trung bình của cả lớp: {diemTrungBinh:F2}");
    }
}