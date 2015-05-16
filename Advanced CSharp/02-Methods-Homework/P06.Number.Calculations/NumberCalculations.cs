using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace P06.Number.Calculations
{
    class NumberCalculations
    {
        // MinAndMax method for integers
        static void MinAndMax(int[] intValues)
        {
            int min = intValues[0];
            int max = intValues[0];

            for (int i = 0; i <= intValues.Length - 1; i++)
            {
                if (min > intValues[i])
                {
                    min = intValues[i];
                }
                if (max < intValues[i])
                {
                    max = intValues[i];
                }
            }
            Console.WriteLine("Min: {0}", min);
            Console.WriteLine("Max: {0}", max);
        }

        // MinAndMax method for doubles
        static void MinAndMax(float[] floatValues)
        {
            float min = floatValues[0];
            float max = floatValues[0];

            for (int i = 0; i <= floatValues.Length - 1; i++)
            {
                if (min > floatValues[i])
                {
                    min = floatValues[i];
                }
                if (max < floatValues[i])
                {
                    max = floatValues[i];
                }
            }
            Console.WriteLine("Min: {0}", min);
            Console.WriteLine("Max: {0}", max);
        }

        // MinAndMax method for decimals
        static void MinAndMax(decimal[] decimalValues)
        {
            decimal min = decimalValues[0];
            decimal max = decimalValues[0];

            for (int i = 0; i <= decimalValues.Length - 1; i++)
            {
                if (min > decimalValues[i])
                {
                    min = decimalValues[i];
                }
                if (max < decimalValues[i])
                {
                    max = decimalValues[i];
                }
            }
            Console.WriteLine("Min: {0}", min);
            Console.WriteLine("Max: {0}", max);
        }

        // xDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxD

        // AverageAndSum method for integers
        public static void AverageAndSum(int[] intValues)
        {
            float sum = 0;

            for (int i = 0; i <= intValues.Length - 1; i++)
            {
                sum += intValues[i]; 
            }

            float average = sum / intValues.Length;

            Console.WriteLine("Avg: {0}", average);
            Console.WriteLine("Sum: {0}", sum);
        }

        // AverageAndSum method for doubles
        public static void AverageAndSum(float[] floatValues)
        {
            float sum = 0;

            for (int i = 0; i <= floatValues.Length - 1; i++)
            {
                sum += floatValues[i];
            }

            float average = sum / floatValues.Length;

            Console.WriteLine("Avg: {0}", average);
            Console.WriteLine("Sum: {0}", sum);
        }

        // AverageAndSum method for decimals
        public static void AverageAndSum(decimal[] decimalValues)
        {
            decimal sum = 0;

            for (int i = 0; i <= decimalValues.Length - 1; i++)
            {
                sum += decimalValues[i];
            }

            decimal average = sum / decimalValues.Length;

            Console.WriteLine("Avg: {0}", average);
            Console.WriteLine("Sum: {0}", sum);
        }

        // xDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxDxD

        // Product method for integers
        public static void Product(int[] intValues)
        {
            int product = 1;

            for (int i = 0; i <= intValues.Length - 1; i++)
            {
                product *= intValues[i];
            }

            Console.WriteLine("Product: {0}", product);
        }

        // Product method for doubles
        public static void Product(float[] floatValues)
        {
            float product = 1;

            for (int i = 0; i <= floatValues.Length - 1; i++)
            {
                product *= floatValues[i];
            }

            Console.WriteLine("Product: {0}", product);
        }

        // Product method for decimals
        public static void Product(decimal[] decimalValues)
        {
            decimal product = 1;

            for (int i = 0; i <= decimalValues.Length - 1; i++)
            {
                product *= decimalValues[i];
            }

            Console.WriteLine("Product: {0}", product);
        }

        static void Main()
        {
            Console.Write("Enter 1 for integers\n      2 for doubles\n      3 for decimals: ");
            int input = int.Parse(Console.ReadLine());
            
            if (input == 1)
            {
                int[] integers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                MinAndMax(integers);
                AverageAndSum(integers);
                Product(integers);
            }
            else if (input == 2)
            {
                float[] doubles = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(float.Parse).ToArray();
                MinAndMax(doubles);
                AverageAndSum(doubles);
                Product(doubles);
            }
            else if (input == 3)
            {
                decimal[] decimals = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();
                MinAndMax(decimals);
                AverageAndSum(decimals);
                Product(decimals);
            }
        }
    }
}
