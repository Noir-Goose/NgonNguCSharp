using System;

namespace ThucHanh01Tuan2;

public class SoPrime
{
    public bool Songuyento(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}
public class Bai07
{
    public static void Main(string[] args)
    {
        SoPrime soPrime = new SoPrime();
        Console.WriteLine("Nhập một số nguyên: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (soPrime.Songuyento(n))
        {
            Console.WriteLine($"{n} là số nguyên tố.");
        }
        else
        {
            Console.WriteLine($"{n} không phải là số nguyên tố.");
        }
    }
}