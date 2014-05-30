using System;

class CheckBitInNumber
{
    static void Main(string[] args)
    {
        /*Write a boolean expression that returns if the bit at position p 
          (counting from 0) in a given integer number v has value of 1. 
          Example: v=5; p=1  false.*/
        Console.WriteLine("Enter your number:");
        int number = int.Parse(Console.ReadLine());
        //Console.WriteLine("your number v is: {0}!",Convert.ToString(number,2).PadLeft(32,'*'));
        Console.WriteLine("Enter the position you want to check:");
        short position = short.Parse(Console.ReadLine());
        int mask = 1 << position;
        if ((number & mask) != 0 )
        {
            Console.WriteLine(" v= {0}; p= {1} => true", number, position);
        }
        else
        {
            Console.WriteLine(" v= {0}; p= {1} => false", number, position);
        }
    }
}

