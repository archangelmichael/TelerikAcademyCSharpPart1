using System;

class RightTypesForVariables
{
    static void Main()
    {
        ushort a = 52130;
        sbyte b = -115;
        int c = 4825932;
        byte d = 97;
        short e = -10000;
        Console.WriteLine("Number {0} is best defined as {1}!", a, a.GetType());
        Console.WriteLine("Number {0} is best defined as {1}!", b, b.GetType());
        Console.WriteLine("Number {0} is best defined as {1}!", c, c.GetType());
        Console.WriteLine("Number {0} is best defined as {1}!", d, d.GetType());
        Console.WriteLine("Number {0} is best defined as {1}!", e, e.GetType());
    }
}

