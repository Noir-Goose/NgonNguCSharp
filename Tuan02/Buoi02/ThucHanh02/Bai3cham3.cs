using System;

namespace DelegateSortExample{

public class Bai3cham3
{
public delegate int HamSoSanh<T>(T x, T y);
class Program
{
    public static void MySort<T>(T[] array, HamSoSanh<T> soSanh)
            {
                if (array == null || array.Length <= 1) return;
                int n = array.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {if (soSanh(array[i], array[j]) > 0)
                        {
                            T temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }
    }
}
class Sach
    {
        public string TenSach { get; set; }
        public int NamXuatBan { get; set; }
        public double Gia { get; set; }
        public Sach(string ten, int nam, double gia)
        {
            TenSach = ten;
            NamXuatBan = nam;
            Gia = gia;
        }
        public override string ToString()
        {
            return $"Tên: {TenSach,-20} | Năm XB: {NamXuatBan} | Giá: {Gia}";
        }
    }
    static void Main(string[] args)
        {
            Sach[] thuVien = new Sach[]
            {
                new Sach("Lập trình C#", 2020, 150000),
                new Sach("Cấu trúc dữ liệu", 2018, 120000),
                new Sach("Trí tuệ nhân tạo", 2022, 200000),
                new Sach("Cơ sở dữ liệu", 2019, 135000)
            };
            Console.WriteLine("--- DANH SÁCH BAN ĐẦU ---");
            foreach (var s in thuVien) Console.WriteLine(s);
            MySort(thuVien, (s1, s2) => s1.Gia.CompareTo(s2.Gia));
            Console.WriteLine("\n--- SẮP XẾP THEO GIÁ TĂNG DẦN ---");
            foreach (var s in thuVien) Console.WriteLine(s);
            MySort(thuVien, (s1, s2) => s2.NamXuatBan.CompareTo(s1.NamXuatBan));
            Console.WriteLine("\n--- SẮP XẾP THEO NĂM XB GIẢM DẦN ---");
            foreach (var s in thuVien) Console.WriteLine(s);
            MySort(thuVien, (s1, s2) => string.Compare(s1.TenSach, s2.TenSach, StringComparison.Ordinal));
            Console.WriteLine("\n--- SẮP XẾP THEO TÊN SÁCH (A-Z) ---");
            foreach (var s in thuVien) Console.WriteLine(s);
            Console.ReadLine();
        }
}
    
                
            


