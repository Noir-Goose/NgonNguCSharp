using System;

namespace ThucHanh01Tuan2;

public class KiemTra
{
    public bool Checksodoixung (string input)
    {
        if(string.IsNullOrEmpty(input)) return false ;
        int left = 0;
        int right = input.Length -1;
        while(left < right )
        {
            if (input[left] != input[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}
class Bai10
{
    static void Main(string[] args)
    {
        Console.Write("Nhap chuoi can kiem tra : ");
        string? chuoi = Console.ReadLine();
        KiemTra xl = new KiemTra ();
        if (xl.Checksodoixung(chuoi!))
        {
            Console.WriteLine ("La chuoi doi xung");
        }
        else
        {
            Console.WriteLine("Day khong la chuoi doi xung");
        }
    }
}