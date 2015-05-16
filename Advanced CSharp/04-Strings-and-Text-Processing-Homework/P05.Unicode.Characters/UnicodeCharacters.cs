using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.Unicode.Characters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string unicodeChars = "";

            for (int i = 0; i < input.Length; i++)
            {
                unicodeChars += "\\" + ((int)input[i]).ToString("X4");
            }

            Console.WriteLine(unicodeChars);
        }
    }
}