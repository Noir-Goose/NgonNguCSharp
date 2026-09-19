using System;
using System.Collections.Generic;

namespace ThuEmployeeSalaryManagementcHanh02
{
    abstract class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }

        protected NhanVien()
        {
            MaNV = "";
            HoTen = "";
        }

        public virtual void Input()
        {
            Console.Write("Nhập mã nhân viên: ");
            MaNV = Console.ReadLine() ?? "";
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine() ?? "";
        }

        public virtual void Output()
        {
            Console.Write($"Mã NV: {MaNV,-6} | Họ tên: {HoTen,-15}");
        }

        public abstract double TinhLuong();
    }
    class NhanVienKinhDoanh : NhanVien
    {
        public double LuongCoBan { get; set; }
        public int SoHopDong { get; set; }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhập mức lương cơ bản (VNĐ): ");
            LuongCoBan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập số hợp đồng đã ký kết: ");
            SoHopDong = Convert.ToInt32(Console.ReadLine());
        }
        public override double TinhLuong()
        {
            return LuongCoBan + (SoHopDong * 500000.0);
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine($" | Bộ phận: Kinh doanh | Hợp đồng: {SoHopDong,3} | Lương: {TinhLuong(),12:N0} VNĐ");
        }
    }
    class NhanVienSanXuat : NhanVien
    {
        public int SoSanPham { get; set; }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhập số lượng sản phẩm: ");
            SoSanPham = Convert.ToInt32(Console.ReadLine());
        }
        public override double TinhLuong()
        {
            double luong = SoSanPham * 1000.0;
            if (SoSanPham > 3000)
            {
                luong += luong * 0.05;
            }
            return luong;
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine($" | Bộ phận: Sản xuất  | Sản phẩm: {SoSanPham,3} | Lương: {TinhLuong(),12:N0} VNĐ");
        }
    }
    class Bai3cham5
    {
        static void Main(string[] args)
        {
            List<NhanVien> danhSach = new List<NhanVien>();
            Console.Write("Nhập số lượng nhân viên cần quản lý: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Nhập thông tin nhân viên thứ {i + 1} ---");
                Console.WriteLine("Chọn loại nhân viên: 1 - Kinh doanh | 2 - Sản xuất");
                Console.Write("Lựa chọn: ");
                int loai = Convert.ToInt32(Console.ReadLine());
                NhanVien nv = null;
                if (loai == 1)
                {
                    nv = new NhanVienKinhDoanh();
                }
                else if (loai == 2)
                {
                    nv = new NhanVienSanXuat();
                }
                else
                {
                    Console.WriteLine("Loại nhân viên không hợp lệ. Mặc định chọn Sản xuất.");
                    nv = new NhanVienSanXuat();
                }
                nv.Input();
                danhSach.Add(nv);
            }
            Console.WriteLine("\n================ BẢNG LƯƠNG NHÂN VIÊN ================");
            double tongLuongCongTy = 0;
            foreach (NhanVien nv in danhSach)
            {
                nv.Output();
                tongLuongCongTy += nv.TinhLuong();
            }
            Console.WriteLine("======================================================");
            Console.WriteLine($"TỔNG QUỸ LƯƠNG PHẢI TRẢ: {tongLuongCongTy:N0} VNĐ");
            Console.ReadLine();
        }
    }
}