using System;

namespace class_session_1;

public class BT9
{
public static void Main(string[] args)
{
    Console.WriteLine("Nhap so do can doi sang radian: ");
    double sogocdo = Convert.ToDouble(Console.ReadLine());
    double radian = sogocdo*(Math.PI/180);
    Console.WriteLine("Gia tri radian la: " + radian);
}
}
