using System;

//3.Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Please enter r="); string inputStr = Console.ReadLine();
        byte radius = byte.Parse(inputStr);
        double perimeter = 2 * radius * Math.PI;
        double area = radius * radius * Math.PI;
        Console.WriteLine("perimeter = {0:F3}", perimeter);
        Console.WriteLine("area = {0:F3}", area);
    }
}

