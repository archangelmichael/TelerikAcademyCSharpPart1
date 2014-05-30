using System;
class TableOfASCIIChars
{
    static void Main()
    {
        Console.WriteLine("The ASCII table consists of the following symbols:");
        for (int i = 0; i <= 127; i++)  // ASCII has only 127 symbols
        {
            Console.Write("{0}\t",(char) i);
        }
    }
}

