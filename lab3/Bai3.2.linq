<Query Kind="Program" />

using System;
using System.Collections.Generic;
using System.Linq;
namespace BaiThucHanhLINQ
{
	class Program
	{
		static void Main()
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;

	        string[] monAn =
	        {
	            "Bún bò Huế", "Hủ tiếu heo", "Bánh canh", "Bánh mì",
	            "Nước Cà phê", "Mì quảng", "Cơm tấm", "Nước Chanh dây",
	            "Mì xào", "Bún riêu", "Bánh cuốn", "Mì gói",
	            "Bún chả", "Hủ tiếu Nam vang"
	        };
	
	        CauA(monAn);
	        CauB(monAn);
	        CauC(monAn);
		}
	   	 static void CauA(string[] a)
	    {
	        int nganNhat = a.Min(s => s.Length);
	        int daiNhat = a.Max(s => s.Length);
	
	        var cacMonNgan = a.Where(s => s.Length == nganNhat);
	        var cacMonDai = a.Where(s => s.Length == daiNhat);
	
	        Console.WriteLine("Câu a:");
	        Console.WriteLine(
	            $"Ngắn nhất ({nganNhat} ký tự): {string.Join(", ", cacMonNgan)}"
	        );
	        Console.WriteLine(
	            $"Dài nhất ({daiNhat} ký tự): {string.Join(", ", cacMonDai)}"
	        );
	    }
	
	    // b. Phân nhóm theo từ đầu tiên
	    static void CauB(string[] a)
	    {
	        var cacNhom = a.GroupBy(s => s.Split(' ')[0]);
	
	        Console.WriteLine("Câu b:");
	
	        foreach (var nhom in cacNhom)
	        {
	            Console.WriteLine(
	                nhom.Key + ": " + string.Join(", ", nhom)
	            );
	        }
	    }
	
	    // c. Đếm tên món có từ đầu tiên là "Bánh"
	    static void CauC(string[] a)
	    {
	        int soLuong = a.Count(s => s.Split(' ')[0] == "Bánh");
	
	        Console.WriteLine("Câu c: " + soLuong + " món bắt đầu bằng từ Bánh");
	    }


	}
}