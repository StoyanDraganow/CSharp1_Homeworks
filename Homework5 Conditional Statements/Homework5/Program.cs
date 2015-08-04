using System;
/*Problem 1. Exchange If Greater

Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. 
 * As a result print the values a and b, separated by a space.
 */ 

class ExchangeIfGreater
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a="); string a = Console.ReadLine();
        int firstnum = int.Parse(a);
        Console.Write("Please enter b="); string b = Console.ReadLine();
        int secondnum = int.Parse(b);
        if (firstnum > secondnum)
            {
                Console.WriteLine("result is : {0} {1}",firstnum ,secondnum);
            }
            else
            {
                Console.WriteLine("error");
            }
                

    }
}

