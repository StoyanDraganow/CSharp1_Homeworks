using System;
using System.Text;
/* Find online more information about ASCII (American Standard Code for Information Interchange)
  and write a program to prints the entire ASCII table of characters at the console (characters from 0 to 255).
  Note that some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.
  You may need to use for-loops (learn in Internet how). */

class PrintASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("|Dec.\t|Hex.\t\t|Uni\t\t|");
        Console.WriteLine("-----------------------------------------");

        for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine("|{0}\t|{1}\t\t|{2}\t\t|", i, i.ToString("X"), (char)i);
                Console.WriteLine("-----------------------------------------");
            }
    }
}