using System;

class TrapezoidArea
{
    static void Main(string[] args)
    {
        //Write an expression that calculates trapezoid's area by given sides a and b and height h.
        Console.WriteLine("Enter trapezoid's side a:");
        double sideA = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter trapezoid's side b:");
        double sideB = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter trapezoid's height:");
        double height = double.Parse(Console.ReadLine());
        double area = (sideA + sideB) / 2 * height;
        Console.WriteLine("The area of your trapezoid is: {0:F6}",area);
    }
}

