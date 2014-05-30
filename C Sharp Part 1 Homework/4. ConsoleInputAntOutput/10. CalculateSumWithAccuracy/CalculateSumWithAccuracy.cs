using System;

class CalculateSumWithAccuracy
{
    static void Main(string[] args)
    {
        /* Write a program to calculate the sum (with accuracy of 0.001):
             1 + 1/2 - 1/3 + 1/4 - 1/5 + ... */
        decimal sum = 1m;
        decimal count = 2m;
        Console.WriteLine(" The sum 1 + 1/2 - 1/3 + 1/4 - 1/5 + ... with accuracy of 0.001 is:");
        int sign = 1;
        while (1m / count > 0.001m)
        {

            sum = sum + (1m / count) * sign;
            sign = sign * (-1);
            count++;
        }
        Console.WriteLine("sum = {0:0.000}", sum);
    }
	         
}
        
