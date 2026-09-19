using System;

namespace ThucHanh02
{
public class Bai1cham5
{
    public static void main(string [] args)
        {
            try
            {
                Console.WriteLine(" Tao don thuc :");
                DonThuc p = new DonThuc( 3.0,4);
                Console.WriteLine($"P(x) = {p}");
                // tai x =2
                double x =2.0;
                double giatri = p.Tinhgiatri(x);
                Console.WriteLine($"\n(a) tinh gia tri P(x) tai x={x} :");
                Console.WriteLine ($"P({x}) = {giatri}");
                // dao ham don thuc
                DonThuc q= p.Daoham();
                Console.WriteLine($"\n(b) Dao ham cua P(x) la :");
                Console.WriteLine($"Q(x) = P' (x) = {2}");
                DonThuc q2 = q.Daoham();
                Console.WriteLine ($"Dao ham bac 2 cua P''(x) : {q2}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Loi : {ex.Message}");
            }
            Console.ReadLine();
        }
}
class DonThuc
    {
        private double a;
        private int n;
        public DonThuc(double a, int n)
        {
            this.a=a;
            if(n<0)
            {
                throw new ArgumentException("n phai la so nguyen am");
            }
            this.n=n;
     
        }
        public double Tinhgiatri(double x)
        {
            return a* Math.Pow(x,n);
        }
        public DonThuc Daoham()
        {
            if (n==0)
            {
                return new DonThuc(0,0);
            }
            return new DonThuc (a*n, n-1);
        }
        public override string ToString()
        {
            if (a==0) return"0";
            if (n==0) return $"{a}";
            if(n==1) return $"{a}x";
            return $"{a}x^{n}";
        }
    }

}