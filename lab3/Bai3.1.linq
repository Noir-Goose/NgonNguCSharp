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
			int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };
	        CauA(mangSo);
	        CauB(mangSo);
	        CauC(mangSo);
	        CauD(mangSo);
		}
		//a. Tính tổng phần tử
	   	static void CauA(int[] a)
	    {
	        Console.WriteLine("Cau a:");
	        Console.WriteLine("Tong so phan tu: " + a.Length);
	        Console.WriteLine("So phan tu chan: " + a.Count(x => x % 2 == 0));
	        Console.WriteLine("So phan tu le: " + a.Count(x => x % 2 != 0));
	    }

    	// b. Tính tổng, tìm giá trị lớn nhất và nhỏ nhất
	    static void CauB(int[] a)
	    {
	        Console.WriteLine("Cau b:");
	        Console.WriteLine("Tong: " + a.Sum());
	        Console.WriteLine("Lon nhat: " + a.Max());
	        Console.WriteLine("Nho nhat: " + a.Min());
	    }
	
	    // c. Đếm số giá trị khác nhau
	    static void CauC(int[] a)
	    {
	        int soLuong = a.Distinct().Count();
	
	        Console.WriteLine("Cau c: " + soLuong + " gia tri khac nhau");
	    }
	
	    // d. Phân nhóm theo số dư khi chia cho 5
	    static void CauD(int[] a)
	    {
	        var cacNhom = a.GroupBy(x => x % 5)
	                       .OrderBy(nhom => nhom.Key);
	
	        Console.WriteLine("Cau d:");
	
	        foreach (var nhom in cacNhom)
	        {
	            Console.WriteLine(
	                "So du " + nhom.Key + ": " + string.Join(", ", nhom));
	        }
	    }

	}
}