using System;
using System.Collections.Generic;

namespace CuocThiTinHoc
{
    abstract class ThiSinh
    {
        public string SBD { get; set; } = string.Empty;
        public string HoTen { get; set; } = string.Empty;
        public double Bai1 { get; set; }
        public double Bai2 { get; set; }
        public double Bai3 { get; set; }

        public virtual void Nhap()
        {
            Console.Write("Nhap So bao danh: ");
            SBD = Console.ReadLine() ?? string.Empty;
            Console.Write("Nhap Ho ten: ");
            HoTen = Console.ReadLine() ?? string.Empty;
            Console.Write("Nhap diem Bai 1: ");
            Bai1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem Bai 2: ");
            Bai2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem Bai 3: ");
            Bai3 = Convert.ToDouble(Console.ReadLine());
        }

        public abstract double TinhTongDiem();

        public virtual void Xuat()
        {
            Console.Write($"SBD: {SBD,-8} | Ho ten: {HoTen,-20} | Bai 1: {Bai1,4} | Bai 2: {Bai2,4} | Bai 3: {Bai3,4}");
        }
    }

    class ThiSinhChuyen : ThiSinh
    {
        public double TiengAnh { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap diem Tieng Anh: ");
            TiengAnh = Convert.ToDouble(Console.ReadLine());
        }

        public override double TinhTongDiem()
        {
            double tong = Bai1 + Bai2 + Bai3;
            double diemThuong = TiengAnh switch
            {
                >= 9 and <= 10 => 2,
                >= 7 and < 9 => 1,
                _ => 0
            };

            return tong + diemThuong;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($" | Anh van: {TiengAnh,4} | Tong diem: {TinhTongDiem(),5} | Loai: Chuyen");
        }
    }

    class ThiSinhSieuCup : ThiSinh
    {
        public double CSDL { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap diem Co so du lieu (CSDL): ");
            CSDL = Convert.ToDouble(Console.ReadLine());
        }

        public override double TinhTongDiem()
        {
            return Bai1 + Bai2 + Bai3 + CSDL;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($" | CSDL: {CSDL,4} | Tong diem: {TinhTongDiem(),5} | Loai: Sieu cup");
        }
    }

    class CuocThi
    {
        private readonly List<ThiSinh> danhSachThiSinh;

        public CuocThi()
        {
            danhSachThiSinh = new List<ThiSinh>();
        }

        public void NhapDanhSach()
        {
            Console.Write("Nhap so luong thi sinh tham gia: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Nhap thong tin thi sinh thu {i + 1} ---");
                Console.WriteLine("Chon doi tuong: 1 - Chuyen | 2 - Sieu cup");
                Console.Write("Lua chon cua ban: ");
                int loai = Convert.ToInt32(Console.ReadLine());

                ThiSinh ts = loai switch
                {
                    1 => new ThiSinhChuyen(),
                    2 => new ThiSinhSieuCup(),
                    _ => new ThiSinhChuyen()
                };

                ts.Nhap();
                danhSachThiSinh.Add(ts);
            }
        }

        public void XuatKetQua()
        {
            Console.WriteLine("\n====================== KET QUA CUOC THI ======================");
            if (danhSachThiSinh.Count == 0)
            {
                Console.WriteLine("Chua co du lieu thi sinh.");
                return;
            }

            foreach (ThiSinh ts in danhSachThiSinh)
            {
                ts.Xuat();
            }

            Console.WriteLine("==============================================================");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            CuocThi thiTinHoc = new CuocThi();
            thiTinHoc.NhapDanhSach();
            thiTinHoc.XuatKetQua();

            Console.ReadLine();
        }
    }
}