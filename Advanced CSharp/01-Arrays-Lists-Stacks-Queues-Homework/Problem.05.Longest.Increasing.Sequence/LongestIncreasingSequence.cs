using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LongestIncreasingSequence
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] values = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Console.WriteLine();

        int counter, maxlength, end;
        
        counter = 1;
        maxlength = 1;
        end = 0;

        Console.Write(values[0]+" ");

        for (int i = 1; i < values.Length; i++)
        {
            if (values[i] > values[i - 1])
            {
                counter++;
                Console.Write(values[i] + " ");
            }
            else
            {
                counter = 1;
                Console.WriteLine();
                Console.Write(values[i]+" ");
            }
            if (counter > maxlength)
            {
                maxlength = counter;
                end = i;
            }
        }

        Console.WriteLine();
        Console.Write("Longest: ");

        for (int i = end - maxlength + 1; i <= end; i++)
        {
            Console.Write(values[i]+" ");
        }

        Console.WriteLine("\n");
    }
}