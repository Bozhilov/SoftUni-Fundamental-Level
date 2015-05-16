using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P06.Palindromes
{
    class Palindromes
    {
        static void Main()
        {
            string text = Console.ReadLine();
            var result = Regex.Matches(text, @"\w+").Cast<Match>()
                        .Select(m => m.Value)
                        .Where(w => String.Join("", w.Reverse()) == w).ToList();
            Console.WriteLine(string.Join(" ", result)); 
        }
    }
}