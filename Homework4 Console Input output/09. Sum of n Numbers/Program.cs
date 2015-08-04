using System;
/* 9. Sum of n Numbers

Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
Examples:

numbers	   sum
3	       90
20	
60	
10	
5	       6.5
2	 
-1	
-0.5	
4	
2	
1	       1    
1
 */

using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter your loop length: ");
        int length = int.Parse(Console.ReadLine());


        double result = 0;

        for (double i = 0; i < length; i++)
        {
            Console.Write("Number [{0}]: ", i);
            double number = double.Parse(Console.ReadLine());

            result += number;
        }

        Console.WriteLine("Sum of these numbers is " + result);
    }
}