using System;

class AssignAsFloatOrDouble
{
    static void Main()
    {
        double a = 34.567839023d;
        float b = 12.345f;
        double c = 8923.1234857;
        float d = 3456.091f;
        Console.WriteLine("Numbers {0} and {1} are best defined with float! ",b,d);
        Console.WriteLine("Numbers {0} and {1} are best defined with double!",a,c);
    }
}

