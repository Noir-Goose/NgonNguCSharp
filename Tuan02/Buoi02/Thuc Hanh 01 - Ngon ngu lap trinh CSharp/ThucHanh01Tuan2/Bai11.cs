using System;

namespace ThucHanh01Tuan2;

public class Xulychuoi
{
    public string Daochuoi (string input)
    {
        if (string.IsNullOrEmpty(input)) return string.Empty;
        char[] charArray =input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
class Bai11
{
    public void Main(string[] args)
    {
        Console.Write("Nhap chuoi can doi:");
        string? input = Console.ReadLine();
        Xulychuoi xl = new Xulychuoi();
        string ketqua =xl.Daochuoi(input!);
        Console.WriteLine("Chuoi su khi dao nguoc");
    }
}
