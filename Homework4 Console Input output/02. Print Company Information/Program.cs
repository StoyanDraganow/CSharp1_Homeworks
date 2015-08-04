using System;

/*Problem 2. Print Company Information

A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.
 */

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Please enter Company name:"); string companyName = Console.ReadLine();
        Console.Write("Please enter Company address:"); string companyAddress = Console.ReadLine();
        Console.Write("Please enter Phone number:"); string companyPhone = Console.ReadLine();
        Console.Write("Please enter Fax number:"); string companyFax = Console.ReadLine();
        Console.Write("Please enter Web site:"); string companySite = Console.ReadLine();

        Console.Write("Please enter Manager first name:"); string managerFName = Console.ReadLine();
        Console.Write("Please enter Manager last name:"); string managerLName = Console.ReadLine();
        Console.Write("Please enter Manager age:"); byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Please enter Manager phone number:"); string managerPhone = Console.ReadLine();
        string managerFullName = managerFName + " " + managerLName;

        Console.WriteLine("[Company: Name:{0}, Address:{1}, Phone:{2}, Fax:{3}, WebSite:{4}]", companyName, companyAddress, companyPhone, companyFax, companySite);
        Console.WriteLine("[Manager: Name:{0}, Age:{1}, Phone:{2}]", managerFullName, managerAge, managerPhone);

    }
}
