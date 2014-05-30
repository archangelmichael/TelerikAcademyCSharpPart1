using System;

class QuoteInTwoWays
{
    static void Main()
    {
        string firstQuote = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(firstQuote);
        string secondQuote = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(secondQuote);
    }
}

