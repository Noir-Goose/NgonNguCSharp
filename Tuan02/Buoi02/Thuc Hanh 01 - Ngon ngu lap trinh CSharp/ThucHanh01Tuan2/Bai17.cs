using System;

namespace ThucHanh01Tuan2;



    public class Quanlymatran
    {
        private int[,] A= new int [0, 0];
        public void Ngaunhien ()
        {
            int m,n ;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Loi, nhap lai so nguoi :");
        }
        Console.Write("Nhap so cot :");
        while (!int.TryParse(Console.ReadLine(), out m) || m <= 0)
        {
            Console.Write("Loi, nhap lai so nguoi :");
        }
        A = new int[n,m];
        Random rand = new Random();
        for (int i =0 ; i< n; i++)
            {
                for (int j =0 ; i<m ; i++)
                {
                    A[i,j] = rand.Next(10,101);
                }
            }
        }
    }
    public void Inmatran()
   {
            int n = AB.GetLength(0);
            int m = AB.GetLength(1);

            if (n == 0 || m == 0)
            {
                Console.WriteLine("Ma tran rong!");
                return;
            }

            Console.WriteLine("\nMa tran A:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{AB[i, j],5}"); // Căn lề 5 khoảng trắng
                }
                Console.WriteLine();
            }
        }
        public void Chanle (out int [] sochan , out int [] sole)
    {
        List<int> dschan = new List<int>();
        List<int> dsle = new List<int>();
        foreach (int val in AB)
            {
                if (val % 2 == 0)
                    dsChan.Add(val);
                else
                    dsLe.Add(val);
            }
            sochan = dschan.ToArray();
            sole = dsle.ToArray();
    }
public class Bai17
{
    static void Main(string[] args)
        {
            QuanLyMaTran ql = new QuanLyMaTran();

            // Sinh mảng
            ql.SinhNgauNhien();

            // In mảng
            ql.InMaTran();

            // Tách và lấy 2 mảng chẵn/lẻ
            ql.TachChanLe(out int[] mangChan, out int[] mangLe);

            // In mảng chẵn
            Console.WriteLine("\n--- MANG CAC SO CHAN ---");
            Console.WriteLine(string.Join(" ", mangChan));

            // In mảng lẻ
            Console.WriteLine("\n--- MANG CAC SO LE ---");
            Console.WriteLine(string.Join(" ", mangLe));
        }
    
}
