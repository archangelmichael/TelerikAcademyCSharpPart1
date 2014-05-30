using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllCards
{
    class AllCards
    {
        static void Main(string[] args)
        {
            /*  Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
             * The cards should be printed with their English names. Use nested for loops and switch-case.  */
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] suit = { " of Clubss", " of Diamonds", " of Hearts", " of Spades" };
            for (int i = 0; i < 52; i++)
            {
                Console.Write("{0}", cards[i % 13]);
                Console.WriteLine(suit[i / 13]);
            }
        }
    }
}
