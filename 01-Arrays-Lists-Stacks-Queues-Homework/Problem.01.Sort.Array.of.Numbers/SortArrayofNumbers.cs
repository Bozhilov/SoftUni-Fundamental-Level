using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortArrayofNumbers
{
    static void Main()
    {
        string[] values = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[values.Length];
        for (int i = 0; i < values.Length; i++)
        {
            numbers[i] = int.Parse(values[i]);
        }
        Array.Sort(numbers);
        for (int i = 0; i <= numbers.Length - 1; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}