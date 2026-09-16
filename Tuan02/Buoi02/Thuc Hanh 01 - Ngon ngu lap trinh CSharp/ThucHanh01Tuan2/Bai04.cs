using System;

namespace ThucHanh01Tuan2;

public class Bai04
{
    static void Main(string [] args )
    {
        Console.WriteLine("Nhap so nguyn x:");
        if (!int.TryParse(Console.ReadLine(), out int x))
        {
            Console.WriteLine("Vui long nhap mot so nguyen hop le cho x.");
            return;
        }
        Console.WriteLine("Nhap so nguyen y:");
        if (!int.TryParse(Console.ReadLine(), out int y))
        {
            Console.WriteLine("Vui long nhap mot so nguyen hop le cho y.");
            return;
        }
        double KetQua = Math.Pow(x, y);
        Console.WriteLine("Ket qua cua x^y la: " + KetQua);
    }
}
