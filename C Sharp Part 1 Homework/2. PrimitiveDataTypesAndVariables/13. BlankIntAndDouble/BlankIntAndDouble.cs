using System;

class BlankIntAndDouble
{
    static void Main()
    {
        int? blankInt = null;
        double? blankDouble = null;
        Console.WriteLine("Integer with null value is {0}.",blankInt);
        Console.WriteLine("Double with null value is {0}.", blankDouble);
        blankInt = 13;
        blankDouble = 13.232123231;
        Console.WriteLine("Integer with value is {0}.", blankInt);
        Console.WriteLine("Double with value is {0}.", blankDouble);
    }
}

