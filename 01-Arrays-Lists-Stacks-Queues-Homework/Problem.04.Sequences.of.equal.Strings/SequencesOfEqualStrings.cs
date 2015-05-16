using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequencesOfEqualStrings
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] values = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        
        Console.WriteLine();

        for (int i = 0; i < values.Length - 1; i++)
        {
            Console.Write(values[i]+" ");
            if (!values[i].Equals(values[i + 1]))
            {
                Console.WriteLine();
            }
        }
        Console.Write(values[values.Length - 1]);
        Console.WriteLine("\n");
    }
}