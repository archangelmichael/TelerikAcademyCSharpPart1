using System;

class ModifyBit
{
    static void Main(string[] args)
    {
        /*  We are given integer number n, value v (v=0 or 1) and a position p. 
            Write a sequence of operators that modifies n to hold the value v 
            at the position p from the binary representation of n.
	        Example: n = 5 (00000101), p=3, v=1  13 (00001101)
	        n = 5 (00000101), p=2, v=0  1 (00000001) */

        Console.WriteLine("Enter your number n:");
        int number = int.Parse(Console.ReadLine());
        int modified = number;
        
        Console.WriteLine("Enter the value v you want to modify with:");
        byte value = byte.Parse(Console.ReadLine());

        Console.WriteLine("Enter the position p you want to check:");
        short position = short.Parse(Console.ReadLine());
        int mask = 1;
        switch (value)
        {
            case 1: modified = number | (1 << position);
                Console.WriteLine(" n = {0} ({1}), p={2}, v={3} => {4} ({5})!", number, Convert.ToString(number, 2).PadLeft(12, '0'), position, value, modified, Convert.ToString(modified, 2).PadLeft(12, '0'));
                break;
            case 0: modified = number & (~(1 << position));
                Console.WriteLine(" n = {0} ({1}), p={2}, v={3} => {4} ({5})!", number, Convert.ToString(number, 2).PadLeft(12, '0'), position, value, modified, Convert.ToString(modified, 2).PadLeft(12, '0'));
                break;
        }       
    }
}

