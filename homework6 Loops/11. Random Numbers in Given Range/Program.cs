using System;
/*Problem 11. Random Numbers in Given Range

Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
 */
 
class RandomNumbers
{
    static void Main(string[] args)
        {
        int count = int.Parse(Console.ReadLine());
        int minInt = int.Parse(Console.ReadLine());
        int maxInt = int.Parse(Console.ReadLine());
        if (minInt <= maxInt)
        {
            Random random = new Random();
            for (int index = 0; index < count; index++)
            {
                Console.Write("{0} ", random.Next(minInt, maxInt + 1));
            }
        }
        else
        {
            Console.WriteLine("incorrect input");
        }    
    }
}
