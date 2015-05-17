using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P01.Series.of.Letters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            
            string pattern;
            string replace;
            Regex regex;

            for (int i = 0; i < input.Length; i++)
            {
                pattern = string.Format(@"{0}+", input[i]);
                replace = string.Format(@"{0}", input[i]);
                regex = new Regex(pattern);
                input = regex.Replace(input, replace);
            }
            Console.WriteLine(input);
        }
    }
}