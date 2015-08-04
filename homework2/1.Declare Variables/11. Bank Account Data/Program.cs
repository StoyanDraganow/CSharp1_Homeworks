using System; 

/*Problem 11. Bank Account Data

A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
 */ 

class BankAccountData
{
    static void Main()
    {
        string firstName = "Nikolay";
        string middleName = "Ivanov";
        string lastName = "Sladkishev";
        decimal availableMoney= 21376515456M;
        string bankName = "Poland National Bank";
        string IBAN = "9876 KL9M 8765 LKO9 65TE 87";
        long cardNumber1 = 3563214568569451;
        long cardNumber2 = 9804568546589524;
        long cardNumber3 = 5213696548547891;
        Console.WriteLine("First Name: {0}",firstName);
        Console.WriteLine("Middle Name: {0}",middleName);
        Console.WriteLine("Last Name: {0}",lastName);
        Console.WriteLine("Available Money (Balance): {0}",availableMoney);
        Console.WriteLine("Bank Name: {0}",bankName);
        Console.WriteLine("IBAN: {0}",IBAN);
        Console.WriteLine("Card Number 1: {0}",cardNumber1);
        Console.WriteLine("Card Number 2: {0}", cardNumber2);
        Console.WriteLine("Card Number 3: {0}", cardNumber3);
    }
}

