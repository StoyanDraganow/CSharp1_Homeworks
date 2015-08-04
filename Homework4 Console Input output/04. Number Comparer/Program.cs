using System;
//Problem 4. Number Comparer

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.
/*
 a 	   b	greater
5	   6	6
10	   5	10
0	   0	0
-5	  -2	-2
1.5	  1.6	1.6
 */

class NumberComparer
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a= "); string inputStr = Console.ReadLine();
        decimal firstNum = decimal.Parse(inputStr);
        Console.Write("Please enter b= "); inputStr = Console.ReadLine();
        int secondNum = int.Parse(inputStr);
        decimal greater = Math.Max(firstNum, secondNum);
        Console.WriteLine("The greater is : {0}", greater);

    }
}
