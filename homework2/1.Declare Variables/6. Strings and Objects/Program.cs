﻿using System;

/*Problem 6. Strings and Objects

Declare two string variables and assign them with Hello and World.
Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
 */

class StringsAndObjects
{
    static void Main()
    {
        string variable1="Hello";
        string variable2 = "World!";
        object variable3 = variable1  + " " + variable2;
        Console.WriteLine("{0}",variable3);
        string variable4 = (string)variable3;
        Console.WriteLine(variable4);
    }
}

