using System;

namespace ThucHanh02
{

public class PhanSo
{
    private int TuSo,Mauso;
    private int uocchunglonnhat(int a, int b)
        {
            a = Math.Abs(a);
            b= Math.Abs(b);
            while (a!=0  && b!=0)
            {
                if (a>b) a%=b;
                else b%=a;
            }
            return a |b ;
        }

private void ToiGian()
        {
            if (Mauso == 0)
            {
                throw new DivideByZeroException("Mẫu số không được bằng 0!");
            }
            
            // Nếu mẫu âm, chuyển dấu trừ lên tử số
            if (Mauso < 0)
            {
                TuSo = -TuSo;
                Mauso = -Mauso;
            }

            int ucln = uocchunglonnhat(TuSo, Mauso);
            if (ucln > 0)
            {
                TuSo /= ucln;
                Mauso /= ucln;
            }
        }


        public PhanSo()
        {
            this.TuSo = 0;
            this.Mauso = 1;
        }

        public PhanSo(PhanSo p)
        {
            this.TuSo = p.TuSo;
            this.Mauso = p.Mauso;
        }

        public PhanSo(int TuSo, int Mauso)
        {
            this.TuSo = TuSo;
            this.Mauso = Mauso;
            ToiGian();
        }

        public PhanSo (int TuSo)
        {
            this.TuSo = TuSo;
            this.Mauso = 1;
        }

        public override string ToString()
        {
            if (Mauso == 1) return $"{TuSo}";
            if (TuSo == 0) return "0";
            return $"{TuSo}/{Mauso}";
        }

        // Dau duong
        public static PhanSo operator +(PhanSo a)
        {
            return new PhanSo(a.TuSo, a.Mauso);
        }

        //Dau am
        public static PhanSo operator -(PhanSo a)
        {
            return new PhanSo(-a.TuSo, a.Mauso);
        }
        // Cong
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.TuSo * b.Mauso + b.TuSo * a.Mauso, a.Mauso * b.Mauso);
        }

        // Tru
        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.TuSo * b.Mauso - b.TuSo * a.Mauso, a.Mauso * b.Mauso);
        }

        // Nhan
        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.TuSo * b.TuSo, a.Mauso * b.Mauso);
        }

        // Chia phan so
        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            if (b.TuSo == 0) throw new DivideByZeroException("Không thể chia cho phân số 0!");
            return new PhanSo(a.TuSo * b.Mauso, a.Mauso * b.TuSo);
        }
        
        public static bool operator ==(PhanSo a, PhanSo b)
        {
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return ReferenceEquals(a, b);
                
            return (a.TuSo * b.Mauso) == (b.TuSo * a.Mauso);
        }

        public static bool operator !=(PhanSo a, PhanSo b)
        {
            return !(a == b);
        }

        public static bool operator >(PhanSo a, PhanSo b)
        {
            return (a.TuSo * b.Mauso) > (b.TuSo * a.Mauso);
        }

        public static bool operator <(PhanSo a, PhanSo b)
        {
            return (a.TuSo * b.Mauso) < (b.TuSo * a.Mauso);
        }

        public static bool operator >=(PhanSo a, PhanSo b)
        {
            return (a.TuSo * b.Mauso) >= (b.TuSo * a.Mauso);
        }

        public static bool operator <=(PhanSo a, PhanSo b)
        {
            return (a.TuSo * b.Mauso) <= (b.TuSo * a.Mauso);
        }

        public override bool Equals(object obj)
        {
            if (obj is PhanSo p) return this == p;
            return false;
        }

        public override int GetHashCode()
        {
            return TuSo.GetHashCode() ^ Mauso.GetHashCode();
        }
    }

    // CHƯƠNG TRÌNH TEST
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            PhanSo p1 = new PhanSo(1, 2);    // 1/2
            PhanSo p2 = new PhanSo(3, 4);    // 3/4
            PhanSo p3 = new PhanSo(-4, -8);  // Tự động rút gọn thành 1/2
            PhanSo p4 = new PhanSo(p2);      // Copy p2 -> 3/4

            Console.WriteLine($"Phân số 1 (p1): {p1}");
            Console.WriteLine($"Phân số 2 (p2): {p2}");
            Console.WriteLine($"Phân số 3 (p3 - rút gọn từ -4/-8): {p3}");
            Console.WriteLine($"Phân số 4 (p4 - copy p2): {p4}\n");

            Console.WriteLine("--- TOÁN TỬ MỘT NGÔI ---");
            Console.WriteLine($"+p1: {+p1}");
            Console.WriteLine($"-p1: {-p1}\n");

            Console.WriteLine("--- TOÁN TỬ HAI NGÔI ---");
            Console.WriteLine($"{p1} + {p2} = {p1 + p2}");
            Console.WriteLine($"{p1} - {p2} = {p1 - p2}");
            Console.WriteLine($"{p1} * {p2} = {p1 * p2}");
            Console.WriteLine($"{p1} / {p2} = {p1 / p2}\n");

            Console.WriteLine("--- TOÁN TỬ SO SÁNH ---");
            Console.WriteLine($"{p1} > {p2} : {p1 > p2}");
            Console.WriteLine($"{p1} < {p2} : {p1 < p2}");
            Console.WriteLine($"{p1} == {p3} : {p1 == p3}");
            Console.WriteLine($"{p1} != {p2} : {p1 != p2}");
            
            Console.ReadLine();
        }
    
}
}

