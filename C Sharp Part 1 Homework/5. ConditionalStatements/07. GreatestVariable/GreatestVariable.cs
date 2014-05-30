using System;

class GreatestVariable
{
    static void Main(string[] args)
    {
        /* Write a program that finds the greatest of given 5 variables. */

        decimal[] numbers = {0,0,0,0,0};
        for (int i = 0; i < 5; i++)
		{
			Console.WriteLine("Enter number:");
            numbers [i] = decimal.Parse(Console.ReadLine());
		}
        decimal biggerNumber = numbers [0];
        for (int i = 0; i < 5; i++)
		{
			if (numbers[i]>=biggerNumber)
	        {
                biggerNumber = numbers[i];
	        }
		}
        Console.WriteLine("The biggest number is: {0}!", biggerNumber);
    }
}

