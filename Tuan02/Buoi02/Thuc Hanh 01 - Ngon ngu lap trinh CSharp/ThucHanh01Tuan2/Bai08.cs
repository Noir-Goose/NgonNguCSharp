using System;

namespace ThucHanh01Tuan2;

public class Kiemtrahoanvi
{
    public void HoanVi (ref double a, ref double b)
    {
        double temp = a;
        a = b;
        b = temp;
    }
}
class Bai08
{
    public static void Main(string[] args)
    {
        Kiemtrahoanvi hoanvi = new Kiemtrahoanvi();
        double a, b;
        Console.Write("Nhap gia tri a: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap gia tri b: ");
        b = Convert.ToDouble(Console.ReadLine());
        hoanvi.HoanVi(ref a, ref b);
        Console.WriteLine($"Gia tri sau khi hoan vi: a = {a}, b = {b}");
    }
}
