﻿using System;
/*Problem 5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers.
 */ 

namespace TheBiggestOfThreeNumbers
{
    class TheBiggestOfThreeNumbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("{0}", a);
                }
            }
            else if (b > a)
            {
                if (b > c)
                {
                    Console.WriteLine("{0}", b);
                }
            }
            else if (c > a)
            {
                if (c > b)
                {
                    Console.WriteLine("{0}", c);
                }
            }
        }
    }
}