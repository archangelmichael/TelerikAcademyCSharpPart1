using System;

class Sort3Values
{
    static void Main(string[] args)
    {
        //Sort 3 real values in descending order using nested if statements.

        Console.WriteLine("Enter first number");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter third number");
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
        {
            if (secondNumber>= thirdNumber)
            {
                Console.WriteLine(" Your numbers are: {0}, {1}, {2}!",firstNumber,secondNumber,thirdNumber);
            }
            else
            {
                Console.WriteLine(" Your numbers are: {0}, {1}, {2}!", firstNumber, thirdNumber, secondNumber);
            }
        }
        else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
        {
            if (firstNumber>= thirdNumber)
            {
                Console.WriteLine(" Your numbers are: {0}, {1}, {2}!",secondNumber,firstNumber,thirdNumber);
            }
            else
            {
                Console.WriteLine(" Your numbers are: {0}, {1}, {2}!", secondNumber, thirdNumber, firstNumber);
            }
        }
        else
        {
            if (firstNumber >= secondNumber)
            {
                Console.WriteLine(" Your numbers are: {0}, {1}, {2}!", thirdNumber, firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine(" Your numbers are: {0}, {1}, {2}!", thirdNumber, secondNumber, firstNumber);
            }
        }

    }
}
