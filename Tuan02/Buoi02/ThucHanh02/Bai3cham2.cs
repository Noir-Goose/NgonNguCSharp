using System;
namespace Sapxeptuychinh
{
    public class Bai3cham2
    {
        public static void MySort<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length <= 1) return;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            int[] numbers = { 12, 22, 65, 67, 36, 22, 1 };
            Console.WriteLine("--- MẢNG SỐ NGUYÊN TRƯỚC KHI SẮP XẾP ---");
            Console.WriteLine(string.Join(", ", numbers));

            MySort(numbers);
            Console.WriteLine("\n--- MẢNG SỐ NGUYÊN SAU KHI SẮP XẾP (Tăng dần) ---");
            Console.WriteLine(string.Join(", ", numbers));

            SanPham[] dsSanPham =
            {
                new SanPham("Laptop", 15000),
                new SanPham("Chuột", 200),
                new SanPham("Bàn phím", 800),
                new SanPham("Màn hình", 4500)
            };

            Console.WriteLine("\n\n--- DANH SÁCH SẢN PHẨM TRƯỚC KHI SẮP XẾP ---");
            foreach (var sp in dsSanPham) Console.WriteLine(sp);

            MySort(dsSanPham);

            Console.WriteLine("\n--- DANH SÁCH SẢN PHẨM SAU KHI SẮP XẾP THEO GIÁ ---");
            foreach (var sp in dsSanPham) Console.WriteLine(sp);
            Console.ReadLine();
        }
    }

    class SanPham : IComparable<SanPham>
    {
        public string Ten {get;set;}
        public double Gia {get ; set ;}
        public SanPham (string ten , double gia)
        {
            Ten=ten;
            Gia=gia;
        }
        public int CompareTo(SanPham other)
        {
            if (other == null ) return 1;
            return this.Gia.CompareTo(other.Gia);
        }
        public override string ToString()
        {
            return $"{Ten,-10} |Gia :{Gia}";
        }
    }
}
