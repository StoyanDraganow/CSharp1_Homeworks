using System;

/*Problem 10. Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
Use descriptive names. Print the data at the console.
 */ 
class EmployeeData
{
    static void Main()
    {
        //I insert the values 

        string firstName = "Ivan";
        string lastName = "Ivanov";
        Byte age = 36;
        char  genger = 'm';
        ulong  IDNumber = 8306112507;
        int UniqueNumber = 27569999;

        //after this print it at the console

        Console.WriteLine("First Name: {0}",firstName);
        Console.WriteLine("Last Name: {0}",lastName);
        Console.WriteLine("age: {0}",age );
        Console.WriteLine("Genger: {0}",genger);
        Console.WriteLine("ID Number: {0}",IDNumber);
        Console.WriteLine("Unique Number: {0}",UniqueNumber);
    }
}

