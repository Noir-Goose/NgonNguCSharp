using System;

namespace ThucHanh01Tuan2;

public class Bai16
{
    static void Main(string[] args)
    {
        Quanlyhoten ql = new Quanlyhoten();
        ql.Nhapdanhsach();
        ql.Sapxeptangdan();
        Console.WriteLine("\n Danh sach sau khi sap xep la :");
        ql.Indanhsach();
    }
}
public class Quanlyhoten
{
    private string [] danhsach = Array.Empty<string>();
    public void Nhapdanhsach()
    {
        int n ;
        Console.Write("Nhap so luong nguoi :");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Loi, nhap lai so nguoi :");
        }
        danhsach = new string[n];
        for(int i =0 ; i<n ; i ++)
        {
            Console.Write("$Nhap ho ten nguoi thu {i +1}: ");
            danhsach[i] = Console.ReadLine() ?? string.Empty;
        }
    }
    public void Indanhsach()
    {
        if(danhsach.Length == 0)
        {
            Console.WriteLine("Danh sach trong ");
            return;
        }
        for (int i = 0; i < danhsach.Length; i++)
        {
            Console.WriteLine("$- {danhsach[i]}");
        }
    }
    public void Sapxeptangdan()
    {
        Array.Sort (danhsach, StringComparer.CurrentCultureIgnoreCase);
    }
}