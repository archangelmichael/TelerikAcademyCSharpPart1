using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PointWithinACircle
{
    static void Main(string[] args)
    {
        //Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
        Console.WriteLine("Please enter range for x: ");
        double rangeX = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter range for y: ");
        double rangeY = double.Parse(Console.ReadLine());
        if (Math.Sqrt(rangeX * rangeX + rangeY * rangeY) <= 5)
        {
            Console.WriteLine("Your point is within circle[0,5]");
        }
    }
}

