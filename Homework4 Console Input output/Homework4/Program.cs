using System;

/*Write a program that reads 3 real numbers from the console and prints their sum.
 */

class Homework4
{
    static void Main()
    {
        Console.WriteLine("Please enter numbers a=? , b=? , c=?");
        Console.Write("Please enter a= "); string inputStr = Console.ReadLine();
        double firstNum = double.Parse(inputStr);
        Console.Write("Please enter b= "); inputStr = Console.ReadLine();
        double secondNum = double.Parse(inputStr);
        Console.Write("Please enter c= "); inputStr = Console.ReadLine();
        double thirdNum = double.Parse(inputStr);
        double sum = firstNum + secondNum + thirdNum;
        Console.WriteLine("Result is: {0}", sum);

    }
}

