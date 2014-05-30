using System;

class UniqueEmployeeInfo
{
    static void Main()
    {
        string firstName = "Ivan";
        string familyName = "Ivanov";
        byte age = 25;
        char gender = 'm'; //for male
        uint numberID = 2233456u;
        uint employeeNumber = 223345646u;
        Console.WriteLine("Personal Employee Information:");
        Console.WriteLine("Names: {0} {1}",firstName,familyName);
        Console.WriteLine("Age: {0}",age);
        Console.WriteLine("Gender: {0}",gender);
        Console.WriteLine("ID number: {0}",numberID);
        Console.WriteLine("Unique Personal Number: {0}",employeeNumber);
    }
}

