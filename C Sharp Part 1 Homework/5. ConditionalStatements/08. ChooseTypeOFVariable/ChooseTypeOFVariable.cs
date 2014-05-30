using System;

class ChooseTypeOFVariable
{
    static void Main(string[] args)
    {
        /*  Write a program that, depending on the user's choice inputs int, double or string variable. 
            If the variable is integer or double, increases it with 1. 
            If the variable is string, appends "*" at its end. 
            The program must show the value of that variable as a console output. Use switch statement.  */

        Console.WriteLine("Choose type of variable: 1 - int, 2 - double, 3 - string ?");
        byte variableType = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter your variable:");
        switch (variableType)
        {
            case 1: int variableInt = int.Parse(Console.ReadLine());
                variableInt += 1;
                Console.WriteLine(" Your variable : {0} !", variableInt);
                break;
            case 2: double variableDouble = double.Parse(Console.ReadLine());
                variableDouble += 1;
                Console.WriteLine(" Your variable : {0} !", variableDouble);
                break;
            case 3: string variableString = Console.ReadLine();
                variableString += "*";
                Console.WriteLine(" Your variable : {0} !", variableString);
                break;
            default: Console.WriteLine("Wront Variable Type !");
                break;
        }
    }
}

