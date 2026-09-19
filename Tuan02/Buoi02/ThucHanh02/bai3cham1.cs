using System;

namespace ArraySortExample
{
    // Lớp SinhVien thực thi giao diện IComparable<SinhVien>
    class SinhVien : IComparable<SinhVien>
    {
        public string HoTen { get; set; }
        public double Diem { get; set; }

        public SinhVien(string hoTen, double diem)
        {
            HoTen = hoTen;
            Diem = diem;
        }

        // Cài đặt phương thức CompareTo để xác định tiêu chí sắp xếp
        public int CompareTo(SinhVien other)
        {
            if (other == null) return 1;

            // Sắp xếp tăng dần theo Điểm
            // (Nếu muốn sắp xếp giảm dần, đổi ngược lại thành: other.Diem.CompareTo(this.Diem))
            return this.Diem.CompareTo(other.Diem);
            
            /* 
             * Logic cơ bản của CompareTo:
             * Trả về < 0: Đối tượng hiện tại nhỏ hơn đối tượng other
             * Trả về 0  : Hai đối tượng bằng nhau
             * Trả về > 0: Đối tượng hiện tại lớn hơn đối tượng other
             */
        }

        public override string ToString()
        {
            return $"Họ tên: {HoTen,-15} | Điểm: {Diem}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 1. Khởi tạo mảng các đối tượng SinhVien
            SinhVien[] danhSach = new SinhVien[]
            {
                new SinhVien("Nguyễn Văn A", 7.5),
                new SinhVien("Lê Thị B", 9.0),
                new SinhVien("Trần Văn C", 5.5),
                new SinhVien("Phạm Thị D", 8.0)
            };

            Console.WriteLine("--- DANH SÁCH TRƯỚC KHI SẮP XẾP ---");
            foreach (SinhVien sv in danhSach)
            {
                Console.WriteLine(sv);
            }

            // 2. Gọi phương thức tĩnh Array.Sort()
            // Hàm này sẽ tự động gọi phương thức CompareTo() của từng đối tượng để hoán đổi vị trí
            Array.Sort(danhSach);

            Console.WriteLine("\n--- DANH SÁCH SAU KHI SẮP XẾP THEO ĐIỂM TĂNG DẦN ---");
            foreach (SinhVien sv in danhSach)
            {
                Console.WriteLine(sv);
            }

            Console.ReadLine();
        }
    }
}