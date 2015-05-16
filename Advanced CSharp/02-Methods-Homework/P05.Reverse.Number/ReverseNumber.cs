using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.Reverse.Number
{
    class ReverseNumber
    {

        public static float ReversedFloat(float value)
        {
            string valueToString = value.ToString();
            string result = string.Empty;

            for (int i = valueToString.Length - 1; i >= 0; i--)
            {
                result += valueToString[i];
            }

            value = float.Parse(result);
            return value;
        }

        static void Main()
        {
            float input = float.Parse(Console.ReadLine());
            float reversedInput = ReversedFloat(input);
            Console.WriteLine(reversedInput);
        }
    }
}