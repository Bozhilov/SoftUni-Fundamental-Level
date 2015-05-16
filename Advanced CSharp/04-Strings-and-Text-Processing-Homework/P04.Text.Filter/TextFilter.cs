using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P04.Text.Filter
{
    class TextFilter
    {
        static void Main()
        {
            //string input = Console.ReadLine();
            //string[] bannedWords = Regex.Split(input, @"[, ]+");
            string[] bannedWords = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
 
            foreach (var p in bannedWords)
            {
            Regex word = new Regex("\\b" + p.ToString() + "\\b");
                text = word.Replace(text, delegate(Match match)
                {
                    string forRemoving = match.ToString();
                    return new string('*', forRemoving.Length);
                });
            }
            Console.WriteLine(text);
        }
    }
}