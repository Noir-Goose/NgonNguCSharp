using System;

namespace class_session_1;

public class BT4
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap so giay : ");
        int giay = int.Parse(Console.ReadLine()!);
        int gio = giay/3600;
        int phut = (giay%3600)/60;
        int giayconlai = (giay%3600)%60;
        Console.WriteLine("So gio : phut : giay la :" + gio + " : " + phut + " : " + giayconlai);
    }
}
