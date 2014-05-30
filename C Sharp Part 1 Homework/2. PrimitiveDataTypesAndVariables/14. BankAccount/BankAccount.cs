using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Ivanov";
        string lastName = "Ivanov";
        object fullName = firstName + " " + middleName + " " + lastName;
        Console.WriteLine( "Bank Account \n Name of Owner: {0}",fullName);

        decimal balance = 23456.789m;
        string bankName = "First Investment Bank";
        string iBAN = "FINV 2123 3232 6567 8789 BGN";
        string bICCode = "FINVBGSF";
        long creditCard1 = 9898765432144567;
        long creditCard2 = 9876567898762345;
        long creditCard3 = 1234431256789432;
        Console.WriteLine("Current account balance: {0} BGN ",balance);
        Console.WriteLine("Bank details: ");
        Console.WriteLine("Bank Name: {0}",bankName);
        Console.WriteLine("IBAN: {0}",iBAN);
        Console.WriteLine("BIC code: {0}",bICCode);
        Console.WriteLine("Valid Credit Card Numbers:");
        Console.WriteLine("\t {0} \n \t {1} \n \t {2}",creditCard1,creditCard2,creditCard3);
    }
}

