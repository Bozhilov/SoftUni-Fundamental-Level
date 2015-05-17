using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P04.Sentence.Extractor
{
    class SentenceExtractor
    {
        static void Main()
        {
            string inputWord = Console.ReadLine();
            string inputText = Console.ReadLine();
            
            string pattern = string.Format(@"(?<=\s|^)(.*?\b{0}\b.*?(?=\!|\.|\?)[?.!])", inputWord);
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(inputText);

            foreach (Match sentence in matches)
            {
                Console.WriteLine(sentence.Groups[0]);
            }
        }
    }
}