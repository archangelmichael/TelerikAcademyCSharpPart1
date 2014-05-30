﻿using System;

class SolveQuadraticEquation
{
    static void Main(string[] args)
    {
        /*  Write a program that reads the coefficients a, b and c of a quadratic equation 
            ax2+bx+c=0 and solves it (prints its real roots). */

        Console.WriteLine("Enter values for a, b and c of your quadratic equation:");
        Console.WriteLine("a=");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("b=");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("c=");
        double c = double.Parse(Console.ReadLine());
        double sqrtpart = b * b - 4 * a * c;
        double x, x1, x2, img;
        if (sqrtpart > 0)
        {
            x1 = (-b + Math.Sqrt(sqrtpart)) / (2 * a);
            x2 = (-b - Math.Sqrt(sqrtpart)) / (2 * a);
            Console.WriteLine("Two Real Solutions: {0,8:f4} or  {1,8:f4}", x1, x2);
        }
        else if (sqrtpart < 0)
        {
            sqrtpart = -sqrtpart;
            x = -b / (2 * a);
            img = Math.Sqrt(sqrtpart) / (2 * a);
            Console.WriteLine("The Equation Has No Real Solutions!");
            Console.WriteLine("Two Imaginary Solutions: {0,8:f4} + {1,8:f4} i or {2,8:f4} + {3,8:f4} i", x, img, x, img);
        }
        else
        {
            x = (-b + Math.Sqrt(sqrtpart)) / (2 * a);
            Console.WriteLine("One Real Solution: {0,8:f4}", x);
        }
    }
}

