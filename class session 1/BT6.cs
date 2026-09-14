using System;

namespace class_session_1;

public class BT6
{
public static void  Main(string [] args )
    {
        int n ;
        int a ;
        Console.WriteLine("Nhap so nguyen a :");
        a = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Nhap so mu n :");
        n = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Ket qua la : " + Math.Pow(a, n));
    }
}
