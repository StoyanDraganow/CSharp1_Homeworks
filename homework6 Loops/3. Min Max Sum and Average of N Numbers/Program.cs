using System;
/*Problem 3. Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number,
the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.
 */ 
class MinMaxSum
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        float averageSum;
        int minNumber = int.MaxValue;
        int maxNumber = int.MinValue;
           
        for (int index = 0; index < num; index++)
        {
            int newNumber = int.Parse(Console.ReadLine());
            sum += newNumber;
            if (newNumber > maxNumber)
            {
                maxNumber = newNumber;
            }
            if (newNumber < minNumber)
            {
                minNumber = newNumber;
            }
        }
           
        averageSum = (float) sum / num;
        Console.WriteLine("min = {0}", minNumber);
        Console.WriteLine("max = {0}", maxNumber);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0 :F2} ", averageSum);
    }
}
