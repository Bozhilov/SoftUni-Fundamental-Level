using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P02.Replace.A.Tag
{
    class ReplaceATag
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"<a.*href=((?:.|\n)*?(?=>))>((?:.|\n)*?(?=<))<\/a>";
            string replace = @"[URL href=$1]$2[/URL]";
            var replaced = Regex.Replace(input, pattern, replace);
            Console.WriteLine(replaced);
        }
    }
}