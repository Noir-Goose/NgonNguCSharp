using System;

namespace ThucHanh02;

public class Bai1
{
     static void Main()
    {
        Console.Write("Nhap ho va ten sinh vien: ");
        string hoTen = Console.ReadLine();
        Console.Write("Nhap nam sinh: ");
        int namSinh = int.Parse(Console.ReadLine());
        int namHienTai = DateTime.Now.Year;
        int tuoi = namHienTai - namSinh;
        int namsinh = int .Parse(Console.ReadLine());
        int namhientai = DateTime.Now.Year;
        Console.WriteLine("\n--- THONG TIN SINH VIEN ---");
        Console.WriteLine($"Ho va ten: {hoTen}");
        Console.WriteLine($"Nam sinh: {namSinh}");
        Console.WriteLine($"Tuoi: {tuoi} tuoi");
    }
}
