<Query Kind="Program" />

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
	public class He
	{
	    public string MaHe { get; set; } = "";
	    public string TenHe { get; set; } = "";
	}
	public static List<He> DS_He()
	{
	    return new List<He>
	    {
	        new He
	        {
	            MaHe = "KTV",
	            TenHe = "Kỹ thuật viên"
	        },
	        new He
	        {
	            MaHe = "CD",
	            TenHe = "Chuyên đề"
	        },
	        new He
	        {
	            MaHe = "QT",
	            TenHe = "Chứng chỉ quốc tế"
	        }
	    };
	}
}

void Main()
{
    var dsMon = DuLieu.DS_Mon();
    var dsHe = DuLieu.DS_He();

    // a. Join: liệt kê Tên hệ, Mã môn, Tên môn
    var cauA = from mon in dsMon
               join he in dsHe on mon.He equals he.MaHe
               select new
               {
                   he.TenHe,
                   mon.MaMon,
                   mon.TenMon
               };

    cauA.Dump("a. Môn học và tên hệ");


    // b. Hệ chưa có môn học
    // GroupJoin kết hợp DefaultIfEmpty để tạo left outer join
    var cauB = dsHe
        .GroupJoin(
            dsMon,
            he => he.MaHe,
            mon => mon.He,
            (he, cacMon) => new { he, cacMon }
        )
        .SelectMany(
            x => x.cacMon.DefaultIfEmpty(),
            (x, mon) => new { x.he, mon }
        )
        .Where(x => x.mon == null)
        .Select(x => new
        {
            x.he.MaHe,
            x.he.TenHe
        });

    cauB.Dump("b. Hệ chưa có môn học");


    // c. Liệt kê đầy đủ: cả các dòng khớp và không khớp
    // Phần 1: lấy tất cả hệ, kể cả hệ chưa có môn
    var heVaMon = from he in dsHe
                  join mon in dsMon
                      on he.MaHe equals mon.He into nhomMon
                  from mon in nhomMon.DefaultIfEmpty()
                  select new
                  {
                      MaHe = he.MaHe,
                      TenHe = he.TenHe,
                      MaMon = mon?.MaMon ?? "",
                      TenMon = mon?.TenMon ?? ""
                  };

    // Phần 2: lấy môn không có hệ tương ứng
    var monKhongCoHe = dsMon
        .Where(mon => !dsHe.Any(he => he.MaHe == mon.He))
        .Select(mon => new
        {
            MaHe = mon.He,
            TenHe = "",
            MaMon = mon.MaMon,
            TenMon = mon.TenMon
        });

    var cauC = heVaMon.Concat(monKhongCoHe);

    cauC.Dump("c. Toàn bộ hệ và môn, kể cả không khớp");


    // d. Chỉ lấy các dòng không khớp ở hai phía
    var heChuaCoMon = dsHe
        .Where(he => !dsMon.Any(mon => mon.He == he.MaHe))
        .Select(he => new
        {
            MaHe = he.MaHe,
            TenHe = he.TenHe,
            MaMon = "",
            TenMon = ""
        });

    var cauD = heChuaCoMon.Concat(monKhongCoHe);

    cauD.Dump("d. Hệ chưa có môn và môn chưa có hệ");


    // e. Lấy 5 môn đầu tiên theo số tiết giảm dần
    // Left join để vẫn giữ môn nếu chưa có hệ tương ứng
    var cauE = (from mon in dsMon
                join he in dsHe
                    on mon.He equals he.MaHe into nhomHe
                from he in nhomHe.DefaultIfEmpty()
                orderby mon.SoTiet descending, mon.MaMon
                select new
                {
                    TenHe = he?.TenHe ?? "Chưa khai báo hệ",
                    mon.MaMon,
                    mon.TenMon,
                    mon.SoTiet
                })
                .Take(5);

    cauE.Dump("e. 5 môn có số tiết cao nhất");


    // f. Tổng số môn của mỗi hệ, kể cả hệ có 0 môn
    var cauF = from he in dsHe
               join mon in dsMon
                   on he.MaHe equals mon.He into nhomMon
               select new
               {
                   he.MaHe,
                   he.TenHe,
                   TongSoMon = nhomMon.Count()
               };

    cauF.Dump("f. Tổng số môn của mỗi hệ");


    // g. Đếm số giá trị số tiết khác nhau
    var cauG = dsMon
        .Select(mon => mon.SoTiet)
        .Distinct()
        .Count();

    cauG.Dump("g. Số loại số tiết khác nhau");


    // h. Môn đầu tiên có tên bắt đầu bằng "Lập trình"
    var cauH = dsMon
        .FirstOrDefault(mon => mon.TenMon.StartsWith("Lập trình"));

    cauH.Dump("h. Môn đầu tiên bắt đầu bằng Lập trình");


    // i. Liệt kê môn theo từng hệ, đánh số từ 1 trong mỗi nhóm
    var cauI = dsHe
        .GroupJoin(
            dsMon,
            he => he.MaHe,
            mon => mon.He,
            (he, cacMon) => new
            {
                he.MaHe,
                he.TenHe,
                CacMon = cacMon
                    .OrderBy(mon => mon.MaMon)
                    .Select((mon, index) => new
                    {
                        STT = index + 1,
                        mon.MaMon,
                        mon.TenMon,
                        mon.SoTiet
                    })
                    .ToList()
            }
        );

    cauI.Dump("i. Môn theo hệ và số thứ tự trong mỗi nhóm");
}