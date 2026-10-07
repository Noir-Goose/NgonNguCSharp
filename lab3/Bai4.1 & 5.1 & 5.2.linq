<Query Kind="Program" />

void Main()
{
    // Lấy nguồn dữ liệu đối tượng
    List<MonHoc> danhSach = DuLieu.DS_Mon();

    // Hiển thị toàn bộ danh sách
    danhSach.Dump("Danh sách môn học");
	
    // a. Chỉ lấy tên các môn bắt đầu bằng "Lập trình"
    var cauA = danhSach
        .Where(mon => mon.TenMon.StartsWith("Lập trình"))
        .Select(mon => mon.TenMon);

    cauA.Dump("a. Tên môn bắt đầu bằng Lập trình");

    // b. Hệ CD: số tiết giảm dần, nếu bằng nhau thì mã môn tăng dần
    var cauB = danhSach
        .Where(mon => mon.He == "CD")
        .OrderByDescending(mon => mon.SoTiet)
        .ThenBy(mon => mon.MaMon);

    cauB.Dump("b. Môn hệ CD");

    // c. Tên chứa "web", không phân biệt hoa thường
    // Chỉ lấy hai thuộc tính: TenMon và He
    var cauC = danhSach
        .Where(mon => mon.TenMon.Contains(
            "web", StringComparison.OrdinalIgnoreCase))
        .Select(mon => new
        {
            mon.TenMon,
            mon.He
        });

    cauC.Dump("c. Môn có tên chứa web");

    // d. Hệ KTV: mã môn tăng dần
    var cauD = danhSach
        .Where(mon => mon.He == "KTV")
        .OrderBy(mon => mon.MaMon);

    cauD.Dump("d. Môn hệ KTV");
    // e. Nhóm theo số tiết, sắp xếp số tiết giảm dần
    danhSach
        .GroupBy(mon => mon.SoTiet)
        .OrderByDescending(nhom => nhom.Key)
        .Select(nhom => new
        {
            SoTiet = nhom.Key,
            TongSoMon = nhom.Count()
        })
        .Dump("e. Tổng số môn theo số tiết");

    // f. Thông tin các môn có số tiết cao nhất
    int soTietCaoNhat = danhSach.Max(mon => (int)mon.SoTiet);

    danhSach
        .Where(mon => mon.SoTiet == soTietCaoNhat)
        .Dump("f. Môn có số tiết cao nhất");

    // g. Thống kê theo hệ
    danhSach
        .GroupBy(mon => mon.He)
        .Select(nhom => new
        {
            He = nhom.Key,
            TongSoMon = nhom.Count(),
            TongSoTiet = nhom.Sum(mon => (int)mon.SoTiet),
            SoTietCaoNhat = nhom.Max(mon => mon.SoTiet),
            SoTietThapNhat = nhom.Min(mon => mon.SoTiet)
        })
        .Dump("g. Thống kê theo hệ");

    // h. Liệt kê môn học phân nhóm theo hệ
    danhSach
        .GroupBy(mon => mon.He)
        .Select(nhom => new
        {
            He = nhom.Key,
            CacMon = nhom.ToList()
        })
        .Dump("h. Danh sách môn theo hệ");

    // i. Nhóm theo số tiết, sắp xếp số tiết tăng dần
    danhSach
        .GroupBy(mon => mon.SoTiet)
        .OrderBy(nhom => nhom.Key)
        .Select(nhom => new
        {
            SoTiet = nhom.Key,
            CacMon = nhom.ToList()
        })
        .Dump("i. Danh sách môn theo số tiết");

    // j. Hệ KTV: nhóm theo HP2, HP3, HP4, HP5
    danhSach
        .Where(mon => mon.He == "KTV")
        .GroupBy(mon => mon.MaMon.Split('_')[0])
        .OrderBy(nhom => nhom.Key)
        .Select(nhom => new
        {
            HocPhan = nhom.Key,
            CacMon = nhom.OrderBy(mon => mon.MaMon).ToList()
        })
        .Dump("j. Môn hệ KTV theo học phần");

    // k. Chỉ lấy môn có số tiết > 40, rồi nhóm theo hệ
    // Trong mỗi nhóm, sắp xếp mã môn tăng dần
    danhSach
        .Where(mon => mon.SoTiet > 40)
        .GroupBy(mon => mon.He)
        .Select(nhom => new
        {
            He = nhom.Key,
            CacMon = nhom.OrderBy(mon => mon.MaMon).ToList()
        })
        .Dump("k. Môn có số tiết > 40 theo hệ");

}

public class MonHoc
{
    public string MaMon { get; set; } = "";
    public string TenMon { get; set; } = "";
    public string He { get; set; } = "";
    public byte SoTiet { get; set; }
}

public class DuLieu
{
    public static List<MonHoc> DS_Mon()
    {
        return new List<MonHoc>
        {
            new MonHoc
            {
                MaMon = "HP2_1",
                TenMon = "Nền tảng C#",
                He = "KTV",
                SoTiet = 64
            },
            new MonHoc
            {
                MaMon = "HP2_2",
                TenMon = "Công nghệ ADO.NET",
                He = "KTV",
                SoTiet = 64
            },
            new MonHoc
            {
                MaMon = "HP3_1",
                TenMon = "Lập trình Windows Forms",
                He = "KTV",
                SoTiet = 64
            },
            new MonHoc
            {
                MaMon = "HP3_2",
                TenMon = "Xây dựng ứng dụng Windows Forms",
                He = "KTV",
                SoTiet = 64
            },
            new MonHoc
            {
                MaMon = "HP4_1",
                TenMon = "Lập trình Web với HTML, CSS và JavaScript",
                He = "KTV",
                SoTiet = 64
            },
            new MonHoc
            {
                MaMon = "HP4_2",
                TenMon = "Xây dựng ứng dụng Web với ASP.NET",
                He = "KTV",
                SoTiet = 64
            },
            new MonHoc
            {
                MaMon = "HP5_1",
                TenMon = "Lập trình CSDL SQL Server căn bản",
                He = "KTV",
                SoTiet = 64
            },
            new MonHoc
            {
                MaMon = "HP5_2",
                TenMon = "Lập trình CSDL SQL Server nâng cao",
                He = "KTV",
                SoTiet = 64
            },
            new MonHoc
            {
                MaMon = "JLCB",
                TenMon = "Joomla cơ bản",
                He = "CD",
                SoTiet = 72
            },
            new MonHoc
            {
                MaMon = "LINQ",
                TenMon = "Language-Integrated Query",
                He = "CD",
                SoTiet = 64
            },
            new MonHoc
            {
                MaMon = "DAWEB",
                TenMon = "Đồ án thực tế Web với ASP.NET",
                He = "CD",
                SoTiet = 40
            },
            new MonHoc
            {
                MaMon = "DAWIN",
                TenMon = "Đồ án thực tế Windows Forms",
                He = "CD",
                SoTiet = 40
            },
            new MonHoc
            {
                MaMon = "C++",
                TenMon = "Lập trình hướng đối tượng với C/C++",
                He = "CD",
                SoTiet = 128
            },
            new MonHoc
            {
                MaMon = "JQUE",
                TenMon = "JQuery",
                He = "CD",
                SoTiet = 22
            },
            new MonHoc
            {
                MaMon = "XML",
                TenMon = "Công nghệ XML",
                He = "CD",
                SoTiet = 32
            },
            new MonHoc
            {
                MaMon = "CRYS",
                TenMon = "Crystal Report trong Visual Studio",
                He = "CD",
                SoTiet = 32
            },
            new MonHoc
            {
                MaMon = "RWEB",
                TenMon = "HTML, CSS và JavaScript",
                He = "CD",
                SoTiet = 32
            },
            new MonHoc
            {
                MaMon = "XYZ",
                TenMon = "Chưa đặt tên môn",
                He = "",
                SoTiet = 0
            }
        };
    }
}