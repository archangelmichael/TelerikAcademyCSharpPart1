using System;

class CompanyInformation
{
    static void Main(string[] args)
    {
        /*  A company has name, address, phone number, fax number, web site and manager.
            The manager has first name, last name, age and a phone number. 
            Write a program that reads the information about a company and its manager
            and prints them on the console.*/
        Console.WriteLine("Enter your company's information:");
        Console.WriteLine("Company name:");
        string companyName = Console.ReadLine();
        Console.WriteLine("Company address:");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Company phone number:");
        uint companyPhone = uint.Parse(Console.ReadLine());  //may be string if it includes +,* or #
        Console.WriteLine("Company fax number:");
        uint companyFax = uint.Parse(Console.ReadLine());    //may be string if it includes +,* or #
        Console.WriteLine("Company website:");
        string companyWeb = Console.ReadLine();
        Console.WriteLine("Company Manager:");
        Console.WriteLine("Company Manager's First Name:");
        string managerFirstName = Console.ReadLine();
        Console.WriteLine("Company Manager's Second Name:");
        string managerSecondName = Console.ReadLine();
        string companyManagerName = managerFirstName + " " + managerSecondName;
        Console.WriteLine("Company Manager's Age:");
        sbyte managerAge = sbyte.Parse(Console.ReadLine());
        Console.WriteLine("Company Manager's Phone:");
        uint managerPhone = uint.Parse(Console.ReadLine());
        Console.WriteLine(new string ('*',40));
        Console.WriteLine("Your company has the following info: ");
        Console.WriteLine("Company name: {0}",companyName);
        Console.WriteLine("Company address: {0}",companyAddress);
        Console.WriteLine("Company phone number: {0}",companyPhone);
        Console.WriteLine("Company fax number: {0}",companyFax);
        Console.WriteLine("Company website: {0}",companyWeb);
        Console.WriteLine("Company Manager: {0}, age  {1},phone number {2}. ",companyManagerName,managerAge, managerPhone);
        
    }
}

