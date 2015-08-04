using System;
//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
/*Examples:

a	   b	   c	   roots
2	  | 5	  | -3	  | x1=-3; x2=0.5
-1	  |3	  |0	  |x1=3; x2=0
-0.5  | 4	  |-8	  |x1=x2=4
5	  |2	  | 8	  |no real roots
 */

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter a,b and c:");
        Console.Write("Please enter a = "); double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter b = "); double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter c = "); double c = double.Parse(Console.ReadLine());
        double D = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
        if (D > 0 && a != 0)
        {
            Console.WriteLine("x1={0}; x2={1}", (-b + D) / (2.0 * a), (-b - D) / (2.0 * a));
        }
        else if (D == 0 && a != 0)
        {
            Console.WriteLine("x1=x2={0}", -b / (2.0 * a));
        }
        else
        {
            Console.WriteLine("no real roots");
        }
    }
}
