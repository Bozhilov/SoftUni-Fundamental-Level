using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.Last.Digit.of.Number
{
    class LastDigitOfNumber
    {
        public static string LastDigit(int num)
        {
            if (num % 10 == 0)
            {
                return "zero";
            }
            if (num % 10 == 1)
            {
                return "one";
            }
            if (num % 10 == 2)
            {
                return "two";
            }
            if (num % 10 == 3)
            {
                return "three";
            }
            if (num % 10 == 4)
            {
                return "four";
            }
            if (num % 10 == 5)
            {
                return "five";
            }
            if (num % 10 == 6)
            {
                return "six";
            }
            if (num % 10 == 7)
            {
                return "seven";
            }
            if (num % 10 == 8)
            {
                return "eight";
            }
            if (num % 10 == 9)
            {
                return "nine";
            }

            return "";
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string lastDigitInText = LastDigit(n);
            Console.WriteLine(lastDigitInText);
        }
    }
}
