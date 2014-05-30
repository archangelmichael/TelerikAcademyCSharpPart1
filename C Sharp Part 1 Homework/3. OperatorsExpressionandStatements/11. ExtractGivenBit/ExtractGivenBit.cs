using System;

class ExtractGivenBit
{
    static void Main(string[] args)
    {
        /*  Write an expression that extracts from a given integer i 
            the value of a given bit number b. Example: i=5; b=2  value=1. */
        Console.WriteLine("Enter your number i:");
        int number = int.Parse(Console.ReadLine());
        //Console.WriteLine("your number i is: {0}!",Convert.ToString(number,2).PadLeft(32,'*'));
        Console.WriteLine("Enter the position b you want to check :");
        short position = short.Parse(Console.ReadLine());
        Console.WriteLine("{0} : Original number : {1}", Convert.ToString(number, 2).PadLeft(32, '0'), number);
        int mask = 1 << position;
        if ((number & mask) != 0)
        {
            Console.WriteLine(" i= {0}; b= {1} => value = 1", number, position);
        }
        else
        {
            Console.WriteLine(" i= {0}; b= {1} => value = 0", number, position);
        }
    }
}

