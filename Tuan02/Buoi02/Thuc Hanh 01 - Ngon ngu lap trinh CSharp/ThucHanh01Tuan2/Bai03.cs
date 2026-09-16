using System;

namespace ThucHanh01Tuan2;

public class Bai03
{
    static void Main(string [] args )
    {
        Console.WriteLine("Nhap so nguyn x:");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so nguyen y:");
        int y = int.Parse(Console.ReadLine());
        double KetQua = Math.Pow(x,y);
        Console.WriteLine("Ket qua cua x^y la: "+KetQua);
    }
}
