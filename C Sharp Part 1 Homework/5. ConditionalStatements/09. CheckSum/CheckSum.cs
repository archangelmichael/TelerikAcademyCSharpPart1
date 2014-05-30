using System;

class CheckSum
{
    static void Main(string[] args)
    {
        /*  We are given 5 integer numbers. Write a program that checks 
         * if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0. */

        double[] number = { 0d, 0d, 0d, 0d, 0d };
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter number:");
            number[i] = double.Parse(Console.ReadLine());
        }
        bool haveZeroSum = false;
        for (int firstNumber = 0; firstNumber < 5; firstNumber++)
        {
            double sum = 0;
            for (int lastNumber = firstNumber; lastNumber < 5; lastNumber++)
            {
                sum += number[lastNumber];
                if (sum == 0)
                {
                    haveZeroSum = true;
                    Console.Write(" Zero subset found: ");
                    for (int variation = firstNumber; variation <= lastNumber; variation++)
                    {
                        Console.Write("{0} ",number [variation]);
                    }
                    Console.WriteLine();
                }
            }
        }
        if (haveZeroSum == false)
        {
            Console.WriteLine(" No subset that has 0 sum was found !");
        }
    }
}

