using System;

namespace ThucHanh02
{

public class Bai2cham2
{
static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== NHẬP DANH SÁCH NHÂN KHẨU ===");
             DanhsachNguoi = new ();
            DanhsachNguoi.Input();

            Console.WriteLine("\n=== DANH SÁCH TOÀN BỘ NHÂN KHẨU ===");
            DanhsachNguoi.Output();

            Console.WriteLine("\n=== DANH SÁCH NHỮNG NGƯỜI CÒN SỐNG ===");
             dsConSong = danhSach.LivingPeople();
            dsConSong.Output();

            Console.ReadLine();
        }
    }
}
class Person1
    {
        private string id ,name ;
        private int namsinh , nammat ;
        public Person1()
        {
            this.id ="";
            this.name = "Khong du lieu";
            this.namsinh =0 ;
            this.nammat =0 ;
        }
        public Person1(Person1 other)
        {
            this.id = other.id;
            this.name = other.name;
            this.namsinh = other .namsinh;
            this. nammat = other . nammat;
        }
    
    public void input()
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
        
                public DanhsachNguoi Consong()
        {
            DanhsachNguoi consong= new Consong(person1);
            foreach (Person1 person1 int this.list)
            {
                if (Person1.Consong())
                {
                    Danhsachnguoisong.Add(new Person1(person1));
                }
            }
            return Consong;
        }
        public DanhsachNguoi(DanhsachNguoi other)
        {
            list = new List<Person>();
            foreach (Person p in other.list)
            {
                // Gọi copy constructor của Person để tạo bản sao độc lập
                this.list.Add(new Person(p)); 
            }
        }
    
}
