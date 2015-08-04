using System;
/*Problem 3. Check for a Play Card

Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. 
 */ 

class CheckForCard
{
    static void Main()
    {
        Console.Write("Please enter playcard = ");
        string ch = Console.ReadLine();
        if (ch == "2" || ch == "3" || ch == "4" || ch == "5" || ch == "6" || ch == "7" || ch == "8" || ch == "9" || ch == "10" || ch == "j" || ch == "q" || ch == "k" || ch == "a" || ch == "J" || ch == "Q" || ch == "K" || ch == "A")
        {
            Console.WriteLine("Valid card sign? \r\nYes");
        }
        else
        {
            Console.WriteLine("Valid card sign? \r\nNo");
        }
    }
}
