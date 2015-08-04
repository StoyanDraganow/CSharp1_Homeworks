using System;

/*Problem 8. Isosceles Triangle

Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©

  © ©

 ©   ©

© © © ©
 */

class IsoscelesTriangle
{
    static void Main()
    {
        char copyright = '\u00a9';
        string whitespace = " ";
        Console.WriteLine("{1}{1}{1}{0}{1}{1}{1}", copyright, whitespace);
        Console.WriteLine("{1}{1}{0}{1}{0}{1}{1}", copyright, whitespace);
        Console.WriteLine("{1}{0}{1}{1}{1}{0}{1}", copyright, whitespace);
        Console.WriteLine("{0}{1}{0}{1}{0}{1}{0}", copyright, whitespace);
    }
}

