using System;
/*Problem 6. Calculate N! / K!

Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.
 */

class CalculateNK
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        if (1 < k && k < n && n < 100)
        {
            ulong resuult = 1;
            for (int index = k + 1; index <= n; index++)
            {
                resuult *= (ulong)index;
            }
            Console.WriteLine(resuult);
        }
        else
        {
            Console.WriteLine("out of range");
        }
    }
}
