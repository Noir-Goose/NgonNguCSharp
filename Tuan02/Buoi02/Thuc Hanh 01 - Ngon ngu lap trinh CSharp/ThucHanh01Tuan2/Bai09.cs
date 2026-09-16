using System;

namespace ThucHanh01Tuan2;

public class Timmaxmin
{
    public void TimMaxMin()
    {
        Console.Write("Nhập số lượng phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine()!);
        int[] arr = new int[n];

        Console.WriteLine("Nhập các phần tử của mảng:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine()!);
        }

        int max = arr[0];
        int min = arr[0];

        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        Console.WriteLine($"Giá trị lớn nhất trong mảng là: {max}");
        Console.WriteLine($"Giá trị nhỏ nhất trong mảng là: {min}");
    }
}
class Bai09
{
    public static void Main(string[] args)
    {
        Timmaxmin timMaxMin = new Timmaxmin();
        timMaxMin.TimMaxMin();
    }
}