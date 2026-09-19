using System;

namespace ThucHanh02{

public class Bai1cham3
{
    static void Main(string[]args)
        {
            Console.WriteLine("Nhap thong tin nguoi thu 1");
            Person p1 = new Person();
            p1.Input();
            Console.WriteLine("\n Thong tin nguoi thu 1");
            p1.Output();
        }
}
class Person
    {
        private string id,name;
        private int namsinh, nammat ;
        
        public Person()
        {
            this.id = "";
            this.name ="Unknow";
            this.namsinh =0;
            this.nammat =0;// 0 la con song
        }
        public void Input()
        {
            Console.Write("Nhap ID");
            this.id= Console.ReadLine();
            Console.Write("Nhap ten");
            this.name= Console.ReadLine();
            Console.Write("Nhap nam sinh");
            Console.Write("Nhap nam sinh :");
            this.namsinh= Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap nam mat : (diem so 0 neu con song)");
            this.nammat= Convert.ToInt32(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine($"Id :{this.id}");
            Console.WriteLine ($"Ten :{this.name}");
            Console.WriteLine($"Nam sinh :{this.namsinh}");
            if (Consong())
            {
                Console.WriteLine(" Con song ");
            }
            else
            {
                Console.WriteLine($"Nam mat : {this.nammat}");
            }
        }
        public bool Consong ()
        {
            return this.nammat ==0;
        }
    }

}