using System;

/*Problem 4. Unicode Character

Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *.
 */

class UnicodeCharacter
{
    static void Main(string[] args)
    {
        const char variable = '\u002a';
        //*this is the output;
        Console.WriteLine(variable);
        //*this look better; 
        Console.WriteLine("The code of'{0}' is: {1}", variable, (int) variable );
           
    }
 }

