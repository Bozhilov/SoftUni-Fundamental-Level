using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.Count.Substring.Occurrences
{
    class CountSubstringOccurrences
    {

        static int CountSubstring(string text, string substring)
        {
            int count = 0;
            int i = 0;

            while (((i = text.IndexOf(substring, i, StringComparison.OrdinalIgnoreCase)) != -1))
            {
                i++;
                count++;
            }

            return count;
        }
        static void Main()
        {
            string inputText = Console.ReadLine();
            string subString = Console.ReadLine();
            Console.WriteLine(CountSubstring(inputText, subString));
        }
    }
}