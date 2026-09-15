#load "LibBaiTap.cs"
using System;

double x1 = 0, x2 = 0;
int result = LibBaiTap.GiaiPTBac2(1, -3, 2, ref x1, ref x2);

Console.WriteLine($"So nghiem: {result}, x1 = {x1}, x2 = {x2}");