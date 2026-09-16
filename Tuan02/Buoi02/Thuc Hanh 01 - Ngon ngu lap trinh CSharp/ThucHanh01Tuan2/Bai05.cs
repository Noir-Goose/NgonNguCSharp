using System;

namespace ThucHanh01Tuan2;

public class Bai05
{
    static void Main(string[] args)
    {
        double x=0 , y=0;
        int chon;
        do
        {
            Console.WriteLine("\n Nhap 2 so x va y: ");
            Console.WriteLine( "1.Nhap hai gia tri thuc x va y");
            Console.WriteLine( "2.Tinh tong x^y");
            Console.WriteLine( "3.Can bac 2 cua x^y");
            Console.WriteLine( "4.Thoat");
            Console.WriteLine( "Nhap lua chon cua ban: ");
            if (!int.TryParse(Console.ReadLine(), out chon))
            {
                Console.WriteLine("Vui long nhap mot so nguyen tu 1 den 4.");
                continue;
            }
            switch (chon)
            {
                case 1:
                    Console.Write("Nhap gia tri x: ");
                    x = double.Parse(Console.ReadLine());
                    Console.Write("Nhap gia tri y: ");
                    y = double.Parse(Console.ReadLine());
                    break;
                case 2:
                    double tong = Math.Pow(x, y);
                    Console.WriteLine($"Tong x^y = {tong}");
                    break;
                case 3:
                    double canBac2 = Math.Sqrt(Math.Pow(x, y));
                    Console.WriteLine($"Can bac 2 cua x^y = {canBac2}");
                    break;
                case 4:
                    Console.WriteLine("Thoat chuong trinh.");
                    break;
                
                default:
                    Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                    break;
            }
        }while (chon != 4);
    }
}
