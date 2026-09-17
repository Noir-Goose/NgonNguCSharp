using System;
using System.Reflection.Emit;

namespace ThucHanh01Tuan2;

public class Bai15
{
    static void Main(String[] args)
    {
        QuanlyMang ql = new QuanlyMang();
        ql.NhapMang();
        Console.WriteLine("Ket Qua");
        ql.InMang();
        ql.TimMaxMin(out int max , out int min);
        Console.WriteLine("Phan tu lon nhat la : {max}");
        Console.WriteLine("Phan tu nho nhat la : {min}");
        int[] mangSNT = ql.LayDSNguyenTo();
        Console.Write("Cac so nguyen to trong mang la ");
        if (mangSNT.Length == 0)
        {
            Console.WriteLine ("Mang kkhong co so nguyen to");
        }
        else
        {
            foreach (int SNT in mangSNT)
            {
                Console.Write(SNT + " ");
            }
            Console.WriteLine();
        }
    }
}
public class QuanlyMang
{
    private int [] a = Array.Empty<int>();
    public void NhapMang()
    {
        int n;
        Console.Write("Nhap so luong phan tu n : ");
        while (!int.TryParse(Console.ReadLine(), out n) || n <=0)
        {
            Console.Write("Loi , nhap lai .So nguyen phai > 0 ");
        }
        a = new int[n];
        for (int i =0 ; i <n; i++ )
        {
            Console.Write("Nhap phan tu a :");
            {
                while (!int.TryParse(Console.ReadLine(), out a[i]))
                {
                    Console.Write("Loi , nhap lai phan tu a");
                }
            }
        }
        
    }


public void InMang()
    {
        if (a.Length == 0 )
        {
            Console.WriteLine("Mang rong");
            return;
        }
        Console.Write("Cac phan tu trong mang la : ");
        foreach (int item in a)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    public void TimMaxMin (out int max , out int min)
    {
        max = a[0];
        min = a[0];
        for (int i =1  ; i < a.Length; i++)
                {
                    if(a[i]> max ) max =a[i];
                    if (a[i]< min) min -= a[i];
                }
    }
    private bool SoNguyenTo (int n)
    {
        if (n<2 ) return false;
        for (int i =2 ; i<= Math.Sqrt(n);i++)
        {
            if (n % i ==0 ) return false;
        }
        return true;
    }
    public int[] LayDSNguyenTo()
    {
        List<int> SoPrime = new List<int>();
        foreach (int item in a )
        {
            if (SoNguyenTo(item))
            {
                SoPrime.Add(item);
            }
        }
        return SoPrime.ToArray();
    }
}    