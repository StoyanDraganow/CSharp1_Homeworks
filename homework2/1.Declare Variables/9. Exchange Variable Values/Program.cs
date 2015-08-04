using System;

/*Problem 9. Exchange Variable Values

Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
Print the variable values before and after the exchange.
 */ 

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("a={0}",a);
        Console.WriteLine("b={0}",b);
        // After this i exchange value of the variables as i use variables 'c' and 'd'.
        int c;
        int d;
        a = c = 8; 
        b = d = 12;
        //this is the result
        Console.WriteLine("a={0}",a);
        Console.WriteLine("b={0}",b);
        
    }
}

