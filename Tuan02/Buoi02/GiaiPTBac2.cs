using System;

namespace Buoi02;

public class GiaiPTBac2
{
    public static int Main(string[] args)
    {
        double x1=0 , x2=0;
        int sn = LibBaiTap.GiaiPTBac2(1, -3, 2, ref x1, ref x2);
        Console.WriteLine($"sn = {sn}, x1 = {x1}, x2 = {x2}");
        return 0;
    }
}
