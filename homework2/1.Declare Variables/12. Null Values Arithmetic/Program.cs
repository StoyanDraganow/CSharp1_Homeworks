using System;
/*Problem 12. Null Values Arithmetic

Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.
 */ 

class NullValuesArithmetic
{
    static void Main()
    {
        int? variableInt = null;
        double? variableDouble = null;
        Console.WriteLine("This is the real number with Null value-->" + variableInt);
        Console.WriteLine("This is the real number with Null value-->" + variableDouble);
        //Add some numbers to variables
        variableInt = 7;
        variableDouble = 1.2;
        Console.WriteLine("This is the integer with value 7 -->" + variableInt);
        Console.WriteLine("This is the double number with value 1.2 -->" + variableDouble);
    }
}

