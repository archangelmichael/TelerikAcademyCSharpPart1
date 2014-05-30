using System;
using System.Text;

class CopyRightsCharacter
{
    static void Main()
    {

        char copy = '\u00a9';
        Console.OutputEncoding = Encoding.Unicode;
        int rows = 3, chars = 1, columns = 5;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < (columns - chars) / 2; j++)
            {
                Console.Write("  ");
            }

            for (int j = 0; j < chars; j++)
            {
                Console.Write(copy + " ");
            }

            chars += 2;
            Console.WriteLine();
        }
    }
}

