using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SelectionSort
{
    static void Main()
    {
        string[] values = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[values.Length];

        for (int i = 0; i < values.Length; i++)
        {
            numbers[i] = int.Parse(values[i]);
        }

        for (int x = 0; x < numbers.Length; x++)
        {
            int Min = x;
            for (int y = x; y < numbers.Length; y++)
            {
                if (numbers[Min] > numbers[y])
                {
                    Min = y;
                }
            }

            int temp = numbers[x];
            numbers[x] = numbers[Min];
            numbers[Min] = temp;
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}