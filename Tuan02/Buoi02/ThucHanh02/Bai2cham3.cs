using System;
using System.Dynamic;

namespace Quanlymang;

public class Bai2cham3
{
static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Khoi tao day so");
            Dayso ds = new Dayso();
            ds.Input();

            Console.WriteLine("\nXuat day so");
            ds.Output();

            Console.WriteLine("\n--- THỬ NGHIỆM INDEXER ---");
            if (ds.Chieudai > 0)
            {
                Console.WriteLine($"Phần tử đầu tiên (index 0) là: {ds[0]}");
                Console.WriteLine("Thay đổi giá trị phần tử đầu tiên thành 99...");
                ds[0] = 99;
                Console.Write("Dãy số sau khi sửa: ");
                ds.Output();
            }

            Console.WriteLine("\n--- TÌM CÁC SỐ CHẴN TRONG DÃY ---");
            Dayso dsChan = ds.Timsochan();
            if (dsChan.Chieudai > 0)
            {
                Console.Write("Các số chẵn tìm được: ");
                dsChan.Output();
            }
            else
            {
                Console.WriteLine("Không có số chẵn nào trong dãy.");
            }

            Console.ReadLine();
        }
    }

class Dayso
{
    private int[] data;
    private int n;
    // cac loai constructor 
    public Dayso()
    {
        this.n = 0;
        this .data = new int[0];
    }
    public Dayso (int kichco)
    {
        if (kichco <0)
        {
            throw new ArgumentException("mang khong duoc be hon 0");
        }
        this .n = kichco;
        this . data = new int [n];
    }
    public Dayso (Dayso other)
    {
        this . n = other.n;
        data = new int[n];
    }
    // truy cap phan tu thu i
    public int this[int i]
    {
        get
        {
            if (i<0 || i>=n)
            {
                throw new IndexOutOfRangeException (" Chi so vuot qua pham vi");
                return data[i];
            }
        set
        {
                if (i<0 || i>=n)
                {
                    throw new IndexOutOfRangeException (" Chi so vuot qua pham vi");
                  data[i] = value;  
                } 
            }
    }
    public int Chieudai
    {
        get {return n ;}
    }
    // c nhap xuat 
    public void Input()
    {
        if (this.n ==0)
        {
            Console.Write("Nhap so luong phan tu day n :");
            this.n = Convert.ToInt32(Console.ReadLine());
            this.data = new int[this.n];
        }
        for (int i=0; i<n;i++)
        {
            Console.Write($"Nhap phan tu thu {i}");
            this.data[i]= Convert.ToInt32(Console.ReadLine());
        }
    }
    public void Output()
        {
            if (this.n == 0)
            {
                Console.WriteLine("Cac arry null");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
        }
        //tim so chan
        public Dayso Timsochan()
    {
        int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (data[i] % 2 == 0)
                {
                    dem++;
                }
            }
            Dayso ketQua = new Dayso(dem);
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                if (data[i] % 2 == 0)
                {
                    ketQua[index] = data[i]; 
                    index++;
                }
            }

            return ketQua;
        }
    }
}