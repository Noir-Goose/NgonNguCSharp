using System;
using System.Collections.Generic;

namespace EmployeeManagement
{

    class NhanVien
    {
        public string HoTen { get; set; }
        public double MucLuong { get; set; }
        public int SoNgayVang { get; set; }

        public NhanVien()
        {
            HoTen = "";
            MucLuong = 0;
            SoNgayVang = 0;
        }

        public void Input()
        {
            Console.Write("Nhap ho ten : ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap muc luong (VNĐ): ");
            MucLuong = Convert.ToDouble(Console.ReadLine());

            Console.Write("So ngay vang: ");
            SoNgayVang = Convert.ToInt32(Console.ReadLine());
        }

        public double TinhLuongThucLanh()
        {

            double tienTru = SoNgayVang * 100000;
            double luongThuc = MucLuong - tienTru;
            return luongThuc > 0 ? luongThuc : 0;
        }

        public void Output()
        {            Console.WriteLine($"Họ tên: {HoTen,-20} | Mức lương: {MucLuong,12:N0} VNĐ | Vắng: {SoNgayVang,2} ngày | Thực lãnh: {TinhLuongThucLanh(),12:N0} VNĐ");
        }
    }


    class PhongBan
    {
        private List<NhanVien> danhSach;

        public PhongBan()
        {
            danhSach = new List<NhanVien>();
        }

        public void Input()
        {
            Console.Write("Nhập số lượng nhân viên trong phòng ban (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Nhập thông tin nhân viên thứ {i + 1} ---");
                NhanVien nv = new NhanVien();
                nv.Input();
                danhSach.Add(nv);
            }
        }

        public void Output()
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Phòng ban chưa có nhân viên.");
                return;
            }

            for (int i = 0; i < danhSach.Count; i++)
            {
                Console.Write($"[{i + 1}] ");
                danhSach[i].Output();
            }
        }

        public double TinhTongLuong()
        {
            double tong = 0;
            foreach (NhanVien nv in danhSach)
            {
                tong += nv.TinhLuongThucLanh();
            }
            return tong;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== KHỞI TẠO PHÒNG BAN ===");
            PhongBan pb = new PhongBan();
            pb.Input();

            Console.WriteLine("\n=== DANH SÁCH NHÂN VIÊN VÀ LƯƠNG ===");
            pb.Output();

            double tongLuong = pb.TinhTongLuong();
            Console.WriteLine("\n=======================================================");
            Console.WriteLine($"TỔNG LƯƠNG CỦA PHÒNG BAN: {tongLuong:N0} VNĐ");
            Console.WriteLine("=======================================================");

            Console.ReadLine();
        }
    }
}