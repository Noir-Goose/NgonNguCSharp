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
			int [] mangSo = {50,42,16,3,9,8,12,7,24,0};
			CauA(mangSo);
			CauB(mangSo);
			int[] b = CauC(mangSo);
        	Console.WriteLine("Cau c: " + string.Join(", ", b));
		}
		 static void CauA(int[] a)
	    {
	        Console.Write("Cau a: ");
	
	        foreach (int x in a)
	        {
	            if (x % 4 == 0 && x % 3 == 0)
	                Console.Write(x + " ");
	        }
	
	        Console.WriteLine();
	    }
		 static void CauB(int[] a)
	    {
	        Console.Write("Cau b: ");
	
	        foreach (int x in a)
	        {
	            if (x <= 3)
	                Console.Write(x + " ");
	        }
	
	        Console.WriteLine();
	    }
		  static int[] CauC(int[] a)
	    {
	        int[] b = new int[a.Length];
	
	        for (int i = 0; i < a.Length; i++)
	        {
	            if (a[i] % 2 == 0)
	                b[i] = a[i] / 2;
	            else
	                b[i] = a[i];
	        }
	
	        return b;
	    }
	}
}
	