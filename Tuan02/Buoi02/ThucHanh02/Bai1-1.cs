using System;
using System.Drawing;
using System.Security.Cryptography;

namespace ThucHanh02;

public class Bai1_1
{

}
class point
{
    private double x;
    private double y;
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
        this.x = 0;
        this.y =0 ;
    }
        public Point (double x, double y)
    {
        this.x =x;
        this.y = y;
    }
    public void Input()
    {
        Console.Write("Nhap x : ");
        this.x = double.Parse(Console.ReadLine());
        Console.Write("Nhap y : ");
        this.y = double.Parse(Console.ReadLine());
    }
    public void output()
    {
        Console.WriteLine ($"Toa do : ({this.x}, {this.y})");
    }
    public override string ToString()
    {
        return $"({x},{y})";
    }
    
  public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.x + p2.x, p1.y + p2.y);
    }

    public static Point operator -(Point p1, Point p2)
    {
        return new Point(p1.x - p2.x, p1.y - p2.y);
    }
    public stactic Point operator -(Point p)
    {
        return new Point(-p.x , -p.y)
    }
} 