using System;
using System.Collections.Generic;

namespace Quanlymatran
{

public class Bai2cham4
{

}
class mang2chieu
    {
       private int[,] data;
        private int n;
        private int m;
        public mang2chieu()
        {
            this.n =0 ;
            this .m =0;
            this.data = new int [0,0];
        }
        public mang2chieu (int n , int m)
        {
            if (n<0 || m< 0)
            {
                throw new AbandonedMutexException ("Kich thuoc mang phai lon hon 0");
            }
            this.n = n;
            this .m =m;
            this.data = new int [n,m];
        }
        public mang2chieu (mang2chieu other)
        {
            this.n=  other.n;
            this.m= other.m;
            this.data = (int[,])other.data.Clone();
        }
        public int this[int i , int j]
        {
            get
            {
                if (i < 0 || i >= n || j < 0 || j >= m)
                    throw new IndexOutOfRangeException(" (i, j) 2 chi so da vuot ra ngoai!");
                return data[i, j];
            }
            set
            {
                if (i < 0 || i >= n || j < 0 || j >= m)
                    throw new IndexOutOfRangeException(" (i, j) 2 chi so da vuot ra ngoai!");
                data[i, j] = value;
            }
        }
        public int sodong {get {return n;}}
        public int socot {get {return n;}}
        public void Input()
        {
            if(this.n ==0 || this.m ==0)
            {
                Console.Write("Nhap so dong :");
                this.n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap so cot :");
                this.m = Convert.ToInt32(Console.ReadLine());
                this.data = new int[this.n, this.m];
            }
            for (int i=0; i<n;i++)
            {
                for (int j =0; j<m;j++)
                {
                    Console.Write($"Nhap cac phan tu [{i},{j}]");
                    this.data[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void Output()
        {
            if (n==0 || m==0)
            {
                Console.WriteLine("mang null");
                return;
            }
            for (int i=0 ; i<n;i++)
            {
                for ( int j = 0; j<m;j++)
                {
                    Console.Write($"{data[i,j],5}");
                }
                Console.WriteLine();
            }
        }
        private bool songuyento (int number)
        {
            if (number < 2) return false;
            for (int i=2; i<= Math.Sqrt(number);i++)
            {
                if (number % i==0) return false;
            }
            return true ;
        }
        public int[] timsoprime ()
        {
            List<int> primes = new List<int>();
            for (int i=0; i<n;i++)
            {
                for (int j =0 ;j<m;j++)
                {
                    if (songuyento(data[i,j]))
                    {
                        primes.Add(data[i,j]);
                    }
                }
            }
            return primes.ToArray();
        }
        
    }
    class bai2cham4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Khoi tao mang 2 chieu");
            mang2chieu matran = new mang2chieu();
            matran.Input();
            Console.WriteLine("Xuat mang 2 chieu");
            matran.Output();
            Console.WriteLine("Kiem tra indexer");
            if (matran.sodong >0 && matran.socot >0)
            {
                Console.WriteLine($"Phan tu tai (0,0) la {matran[0,0]}");
                Console.WriteLine("Doi gia tri pha tu");
                matran[0,0] = 99;
                matran.Output();
            }
            Console.WriteLine("Tim cac so trong mang ");
            int [] primes = matran.timsoprime();
            if (primes.Length >0)
            {
                Console.Write("Cac so prime tim thay:");
                Console.WriteLine(string.Join(", ", primes));
            }
            else
            {
                Console.WriteLine("Khong thay so prime");
            }Console.ReadLine();
        }
    }
}