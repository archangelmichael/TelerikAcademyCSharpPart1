using System;

class Show10NumbersInSequence
{
    static void Main(string[] args)
    {
        int initialValue = 2;
        for (int count = 0; count < 10; count++)
        {
            if (initialValue % 2 == 0)
                Console.Write(initialValue);

            else
                Console.Write("-{0}", initialValue);

            Console.Write("\t");
            initialValue += 1;
        }
    }
}

