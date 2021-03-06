﻿using System;
/*Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.
 */ 

class Calculate
{
    static void Main()
    {
        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter x: ");
        int x = int.Parse(Console.ReadLine());
        float sum = 1;
        float factorial = 1;
        int power = x;
        for (int count = 1; count <= n; count++)
        {
            factorial *= count;
            sum += factorial / x;
            Console.WriteLine(sum);
            x *= power;
        }
        Console.WriteLine("{0 :F5}", sum);
    }
}