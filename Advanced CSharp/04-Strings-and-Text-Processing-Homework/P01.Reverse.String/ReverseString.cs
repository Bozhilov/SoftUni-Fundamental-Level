using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.Reverse.String
{
    class ReverseString
    {
        static void Main()
        {
            string input = Console.ReadLine();

            char[] reversedInput = input.ToCharArray();
            Array.Reverse(reversedInput);

            Console.WriteLine(reversedInput);
        }
    }
}