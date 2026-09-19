using System;
using System.Collections;
using System.Globalization;
using ThucHanh02;

namespace ThucHanh02
{

public class Bai2cham1
{
    static void Main(string [] args)
        {
            ArrayPoint Danhsachdiem = new ArrayPoint();
            Danhsachdiem.Add (new Point(1,2));
            Danhsachdiem.Add (new Point(3,4));
            Danhsachdiem.Add (new Point(5,6));
            Console.WriteLine("Truy xuat qua indexter");
            for (int i =0l i<Danhsachdiem; i++)
            {
                Danhsachdiem[1]= new Point(9,9);
                Console.WriteLine($"Diem thu 1 sau khi sua la: {Danhsachdiem[1]}");
                Console.ReadLine();
            }
        }
}
class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
    class ArrayPoint
    {
        points = new ArrayList();
    }
    public void Add(Point p)
    {
        points.Add(p);
    }
    public int Count
        {
            get {return points.Count;}
        }
        public Point this [int i]
        {

        get
        {
            if (i<0 || i>= points.Count)
            {
                throw new IndexOutOfRangeException(Chi so mang khong hop le);
            }
            return (Point)points[i];
        }
            set
            {
                if (i,0 || i>= points.Count)
                {
                    throw new IndexOutOfRangeException(Chi so mang khong hop le);
                }
                points[i] = value;
            }
        }
}