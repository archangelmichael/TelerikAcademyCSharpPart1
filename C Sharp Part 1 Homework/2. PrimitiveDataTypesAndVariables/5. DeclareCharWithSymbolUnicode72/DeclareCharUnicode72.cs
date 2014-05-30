using System;

class DeclareCharUnicode72
{
    static void Main()
    {
        int number = 72;
        string hexOutput = String.Format("{0:X}", number);
        Console.WriteLine("Hexadecimal value of {0} is {1}", number, hexOutput);
        char ch = '\u0048';  //aslo possible char ch = (char)0x48;

        Console.WriteLine("The character with Unicode {0} is {1}!", hexOutput, ch);
    }
}

