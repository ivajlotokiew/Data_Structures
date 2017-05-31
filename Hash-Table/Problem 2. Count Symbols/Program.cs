using System;
using System.Linq;
using Problem_1.Dictionary;

namespace Problem_2.Count_Symbols
{
    class Program
    {
        static void Main()
        {
            var textBuffer = new HashTable<char, int>();
            char[] textSymb = Console.ReadLine().ToCharArray();

            for (int counter = 0; counter < textSymb.Length; counter++)
            {
                char key = textSymb[counter];

                if (!textBuffer.ContainsKey(key))
                {
                    textBuffer[key] = 0;
                }

                textBuffer[key]++;
            }

            foreach (var dict in textBuffer)
            {
                Console.WriteLine("{0}: {1} time/s", dict.Key, dict.Value);
            }
        }
    }
}
