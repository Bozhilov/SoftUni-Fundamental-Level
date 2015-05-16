using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.String.Length
{
    class StringLength
    {
        static void Main()
        {
            string input = Console.ReadLine();

            char[] totalLength = new char[20];

            if (input.Length == 20)
            {
                Console.WriteLine(input);
                Environment.Exit(0);
            }
            else if (input.Length > 20)
            {
                for (int k = 0; k < 20; k++)
                {
                    Console.Write(input[k]);
                }
                Console.WriteLine();
                Environment.Exit(0);
            }
            else if (input.Length < 20)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    totalLength[i] = input[i];
                }

                for (int j = input.Length; j < totalLength.Length; j++)
                {
                    totalLength[j] = '*';
                }
                Console.WriteLine(totalLength);
                Environment.Exit(0);
            }
        }
    }
}