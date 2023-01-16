using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static int solveMeFirst(int a, int b)
    {
        if (((1 <= a) && (a <= 1000)) && ((1 <= b) && (b <= 1000)))
        {
            return a + b;
        }
        else
        {
            return 0;
        }
    }
    static void Main(String[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập a: ");
        int val1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập b: ");
        int val2 = Convert.ToInt32(Console.ReadLine());
        int sum = solveMeFirst(val1, val2);
        Console.WriteLine(sum);
        Console.ReadKey();
    }
}