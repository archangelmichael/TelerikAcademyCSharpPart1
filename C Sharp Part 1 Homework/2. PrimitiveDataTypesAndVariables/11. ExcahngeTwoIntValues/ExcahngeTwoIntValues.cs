using System;

class ExcahngeTwoIntValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("At start we have a = {0} and b = {1}.",a,b);
        a = a + b; // or a+=b;
        b = a - b;
        a = a - b;
        Console.WriteLine("In the end we have a = {0} and b = {1}!",a,b);
    }
}

