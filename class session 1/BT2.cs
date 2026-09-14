using System;

namespace class_session_1;

public class BT2
{
public static void Main(string [] args)
    {
        const double pi =3.14;
        Console.WriteLine("Nhap ban kinh: ");
        int radius = int.Parse(Console.ReadLine());
    
    double chuvi = 2*pi*radius;
    double dientich = pi * radius * radius;
    Console.WriteLine("Dien tich hinh tron la: " + dientich);
    Console.WriteLine("Chu vi hinh tron la: " + chuvi);
    }
}
