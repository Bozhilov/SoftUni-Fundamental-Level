using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.Fill.the.Matrix
{
    class FillTheMatrix
    {
        static void Main()
        {
            // This is the matrix with pattern A!
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, columns];

            int value = 1;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
			    {
                    matrix[j, i] = value;
                    value++;
			    }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }
                Console.WriteLine();
            }

            // I'm sorry i couldn't make pattern B as well as the remaining part of the homework :(
        }
    }
}
