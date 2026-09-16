using System;

namespace ThucHanh01Tuan2;

public class Sinhvien
{
    public  string MaSV{get;set;}= string.Empty;
    public string HoTen {get ; set;} =string.Empty;
    public string DiaChi {get ; set ;}= string.Empty;
    public int Namthu {get ; set ;}
    public void Nhapinfo()
    {
        Console.Write("Nhap ma sinh vien : ");
        MaSV = Console.ReadLine()!;
        Console.Write ("Nhap ho ten :");
        HoTen = Console.ReadLine()!;
        Console.Write("Nhap dia chi :");
        DiaChi = Console.ReadLine()!;
        Console.Write("Nhap sinh vien na thu :");
        while (!int.TryParse(Console.ReadLine(), out int Nam) ||Nam <=0)
        {
            Console.Write("Loi ! Nhap lai nam thu : ");
        }
        Namthu = int.Parse(Console.ReadLine()?? "1");
    }
    public void XuatThonginfo()
    {
        Console.WriteLine("Thong tin sinh vien");
        Console.WriteLine("Ma sinh vien : {MaSV}");
        Console.WriteLine("Ho ten  : {HoTen}");
        Console.WriteLine("Nam thu  : {Namthu}");
    }
}
class Bai134
{
    static void Main(string[] args)
    {
        Sinhvien sv = new Sinhvien();
        sv.Nhapinfo();
        sv.XuatThonginfo();
    }
}
