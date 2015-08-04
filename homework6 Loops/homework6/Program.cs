using System;
/*Problem 1. Numbers from 1 to N

Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
 */

class Numbers
{
    static void Main()
    {
        Console.Write("Please enter number:");
        int number = int.Parse(Console.ReadLine());

        for (int index = 1; index <= number; index++)
        {
            Console.Write("{0} ", index);
        }
    }
}
