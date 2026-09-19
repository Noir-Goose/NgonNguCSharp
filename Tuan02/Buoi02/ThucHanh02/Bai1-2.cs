using System;

namespace ThucHanh02
{

public class Point
{
    private double x,y;
    public double X 
    {
        get{return x;}
        set {x = value;}
    }
    public double Y
    {
    get{return y;}
    set {y = value;}
    }
    public Point()
    {
        this.x=0;
        this.y=0;
    }
    public Point (double x, double y)
    {
        this.x=x;
        this.y=y;
    }
    public void Input()
    {
        Console.Write("Nhap toa do x :");
        this.x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap toa do y :");
        this.y = Convert.ToDouble(Console.ReadLine());
    }
    public void Output()
    {
        Console.WriteLine(this.ToString());
    }
    public override string ToString()
    {
        return $"({this.x}, {this.y})";
    }
    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.x-p2.x,p1.y-p2.y);
    }
    public static Point operator -(Point p)
    {
        return new Point(-p.x, -p.y);
    }
    // a khoang cach giua 2 diem 
    public double KhoangCach (Point other)
    {
        return Math.Sqrt(Math.Pow(this.x-other.x,2)+Math.Pow(this.y-other.y,2));
    }
    public static double KhoangCach (Point p1 , Point p2)
    {
        return Math.Sqrt(Math.Pow(p1.x-p2.x,2)+Math.Pow(p1.y-p2.y,2));
    }
    //b trung diem cua 2 diem
    public Point TrungDiem(Point other)
    {
        return new Point((this.x +other.x)/2.0,(this.y + other.y)/2.0);
    }
    public static Point TrungDiem(Point p1 , Point p2)
    {
        return new Point((p1.x +p2.x)/2.0,(p1.y + p2.y)/2.0);
    }
    
}
    class Bai1_2
    {
        static void Main (string[] args )
        {
            Console.WriteLine("--- NHẬP ĐIỂM A ---");
            Point A = new Point();
            A.Input();

            Console.WriteLine("\n--- NHẬP ĐIỂM B ---");
            Point B = new Point();
            B.Input();

            Console.WriteLine("\n================ KẾT QUẢ ================");
            Console.WriteLine($"Điểm A: {A}");
            Console.WriteLine($"Điểm B: {B}");

            // (a) Khoảng cách
            Console.WriteLine("\n1. Khoảng cách giữa A và B:");
            Console.WriteLine($"- Dùng phương thức thành viên: {A.KhoangCach(B)}");
            Console.WriteLine($"- Dùng phương thức tĩnh:       {Point.KhoangCach(A, B)}");

            // (b) Trung điểm
            Console.WriteLine("\n2. Trung điểm I của A và B:");
            Console.WriteLine($"- Dùng phương thức thành viên: {A.TrungDiem(B)}");
            Console.WriteLine($"- Dùng phương thức tĩnh:       {Point.TrungDiem(A, B)}");
            Console.WriteLine("\n3. Các phép toán:");
            Console.WriteLine($"- Phép cộng (A + B):      {A + B}");
            Console.WriteLine($"- Phép trừ (A - B):       {A-B}");
            Console.WriteLine($"- Phép lấy âm của A (-A): {-A}");

            Console.ReadLine();
        }
    }
}