using System;
/*Problem 2. Numbers Not Divisible by 3 and 7

Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, 
on a single line, separated by a space.
 */ 

class NumbersNotDivisible
{
    static void Main()
    {
        Console.Write("please enter number:");
        int number = int.Parse(Console.ReadLine());

        for (int index = 1; index <= number; index++)
        {
            if (index % 3 == 0 || index % 7 == 0)
            {
                continue;
            }
            Console.Write("{0} ", index);
        }
    }
}
