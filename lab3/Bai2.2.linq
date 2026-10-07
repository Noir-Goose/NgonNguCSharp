<Query Kind="Program" />

using System;
using System.Collections.Generic;
using System.Linq;
namespace BaiThucHanhLINQ
{
	class Program
	{
	    // a. Chọn từ có 4 ký tự, sắp xếp theo ký tự đầu tiên
	    static void CauA(string[] a)
	    {
	        var ketQua = a.Where(s => s.Length == 4)
	                      .OrderBy(s => s[0]);
	
	        Console.WriteLine("Cau a: " + string.Join(", ", ketQua));
	    }
	
	    // b. Chuyển thành dạng: chữ thường - CHỮ HOA
	    static void CauB(string[] a)
	    {
	        var ketQua = a.Select(s => s.ToLower() + " - " + s.ToUpper());
	
	        Console.WriteLine("Cau b:");
	        foreach (string s in ketQua)
	        {
	            Console.WriteLine(s);
	        }
	    }
	
	    // c. Chọn từ có chứa ký tự 'u'
	    static void CauC(string[] a)
	    {
	        var ketQua = a.Where(s => s.Contains('u'));
	
	        Console.WriteLine("Cau c: " + string.Join(", ", ketQua));
	    }
	
	    // d. Chọn từ bắt đầu bằng chữ in hoa
	    static void CauD(string[] a)
	    {
	        var ketQua = a.Where(s => !string.IsNullOrEmpty(s)
	                                 && char.IsUpper(s[0]));
	
	        Console.WriteLine("Cau d: " + string.Join(" ", ketQua));
	    }
	
	    static void Main(string[] args)
	    {
	        Console.OutputEncoding = System.Text.Encoding.UTF8;
	
	        string[] mangChuoi =
	        {
	            "đầu", "lòng", "hai", "ả", "tố", "nga",
	            "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân"
	        };
	
	        CauA(mangChuoi);
	        CauB(mangChuoi);
	        CauC(mangChuoi);
	        CauD(mangChuoi);
	    }
	}
}