using System;

class PrintCircle
{
    static void Main(string[] args)
    {
        //Write a program that reads the radius r of a circle and prints its perimeter and area.
        Console.WriteLine("Enter the radius of your circle:");
        double radius = int.Parse(Console.ReadLine());
        Console.WriteLine("The perimeter of your circle is: {0}",2*Math.PI*radius);
        Console.WriteLine("The area of your circle is: {0}",Math.PI*Math.Pow(radius,2));
    }
}

