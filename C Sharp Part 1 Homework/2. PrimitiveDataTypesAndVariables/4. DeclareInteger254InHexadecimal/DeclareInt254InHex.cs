using System;

class DeclareInt254InHex
{
    static void Main(string[] args)
    {
        int numberInDec = 254;
        string number254InHex = String.Format("{0:X}", numberInDec);
        Console.WriteLine("Hexadecimal value of 254 is {0}!",number254InHex);
        int numberInHex = 0xFE;
        Console.WriteLine("{0} can be assigned to int as {1} using \"0xFE\"!", number254InHex, numberInHex);
    }
}