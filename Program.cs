﻿using System;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2;
            double length;
            Console.WriteLine("------------Calculate length of line--------");
            Console.WriteLine("Enter x1 value");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 value");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 value");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2 value");
            y2 = Convert.ToInt32(Console.ReadLine());
            length=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
            Console.WriteLine("length is - " + length);
        }
    }
}
