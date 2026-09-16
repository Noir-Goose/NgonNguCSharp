using System;
using System.Dynamic;
using System.Reflection.PortableExecutable;

namespace ThucHanh01Tuan2;

public class docchuoi
{
    public int demtu (string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return 0 ;
        string[] cacTu = input.Trim().Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        return cacTu.Length;
    }
}
class Bai12
{
    static void Main(string[] args )
    {
        Console.Write("Nhap chuoi bao gom nhieu tu:");
        string? chuoi = Console.ReadLine();
        if ( chuoi != null)
        {
            docchuoi xl = new docchuoi();
            Console.WriteLine($"Chuoi ky tu thuong : {chuoi.ToLower()}");
                Console.WriteLine($"Chuoi ky tu hoa    : {chuoi.ToUpper()}");
                int soTu = xl.demtu(chuoi);
                Console.WriteLine($"So tu trong chuoi   : {soTu}");
        }
    }
}
