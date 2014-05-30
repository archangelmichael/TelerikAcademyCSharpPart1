using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CalculateRectangleArea
{
    static void Main(string[] args)
    {
        //Write an expression that calculates rectangle’s area by given width and height.
        Console.WriteLine("Please enter the height of your rectangle:");
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the width of your rectangle:");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("The area of your rectangle is: {0}",height*width);

    }
}

