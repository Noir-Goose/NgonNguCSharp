using System;

namespace ThucHanh01Tuan2;

public class Timkiemsolonnhat
{
    public int TimMax(int a, int b, int c)
    {
        int max = a;
        if (b > max) max =b ;
        if (c > max) max = c;
        return max;
    }
}
public class Bai06
{
    public static void Main(string[] args)
    {
        Timkiemsolonnhat timkiem = new Timkiemsolonnhat();
        Console.WriteLine("Nhập số thứ nhất: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhập số thứ hai: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhập số thứ ba: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int max = timkiem.TimMax(a, b, c);
        Console.WriteLine($"Số lớn nhất là: {max}");
    }
}
