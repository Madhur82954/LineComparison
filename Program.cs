﻿using System;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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
            length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("length is - " + length);
            */
            /* 
            int x1, x2, y1, y2, a1, b1, a2, b2;
            double length1,length2;
            Console.WriteLine("------------Calculate length of line--------");
            Console.WriteLine("Enter x1 value");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 value");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 value");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2 value");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a1 value");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a2 value");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b1 value");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b2 value");
            b2 = Convert.ToInt32(Console.ReadLine());
            length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            length2 = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));

            Console.WriteLine("length1 is -- " + length1);
            Console.WriteLine("length2 is -- " + length2);

            if (length1.Equals(length2))
            {
                Console.WriteLine("lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }
            */

            //UC3 - lines are smaller,greater or equal 
            int x1, x2, y1, y2, a1, b1, a2, b2;
            double length1, length2;
            Console.WriteLine("------------Calculate length of line--------");
            Console.WriteLine("Enter x1 value");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 value");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 value");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2 value");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a1 value");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a2 value");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b1 value");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b2 value");
            b2 = Convert.ToInt32(Console.ReadLine());
            length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            length2 = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));

            Console.WriteLine("length1 is -- " + length1);
            Console.WriteLine("length2 is -- " + length2);

            int result = length1.CompareTo(length2);

            if (result > 0)
            {
                Console.WriteLine("line is greater");
            }
            else if (result < 0)
            {
                Console.WriteLine("line is smaller");
            }
            else
            {
                Console.WriteLine("lines are equal");
            }
        }
    }
}
