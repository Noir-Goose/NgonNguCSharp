using System;

namespace ThucHanh01Tuan2;

public class NhanVien
{
    public string HoTen {get ; set;} = string .Empty;
    public double MucLuong {get ; set;}
    public int SoNgayOff {get ; set ;}
    public void NhapThongTin()
    {
        Console.Write("Nhap ho ten nhan vien : ");
        HoTen = Console.ReadLine() ?? string.Empty;

        Console.Write("Nhap muc luong cua ban :");
        double luong;
        while (!double.TryParse(Console.ReadLine(), out luong) || luong < 0)
        {
            Console.Write(" Loi , nhap lai muc luong ");
        }
        MucLuong = luong;

        Console.Write("Nhap so ngay off :");
    int ngay;
    while (!int.TryParse(Console.ReadLine(), out ngay) || ngay < 0)
        {
            Console.Write("Loi , nhap lai so ngay off :");
        }
        SoNgayOff = ngay;
    }

public double TinhLuong()
    {
        double Tienphat = SoNgayOff *100000;
        double Luongcung = MucLuong - Tienphat ;
        return Luongcung <0?0: Luongcung ;
    }
    

public void XuatThongTin()
    {
        Console.WriteLine("\n--- THONG TIN LUONG NHAN VIEN ---");
        Console.WriteLine($"Ho ten        : {HoTen}"); 
        Console.WriteLine($"Muc luong     : {MucLuong:N0} VNĐ"); 
        Console.WriteLine($"So ngay vang  : {SoNgayOff} ngay"); 
        Console.WriteLine($"Tien phat vang: {SoNgayOff * 100000:N0} VNĐ"); 
        Console.WriteLine($"Luong thuc nhan: {TinhLuong():N0} VNĐ");
    }
}

class Bai14
{
    static void Main (string[] args )
    {
        NhanVien nv= new NhanVien();
        nv.NhapThongTin();
        nv.XuatThongTin();
    }
}