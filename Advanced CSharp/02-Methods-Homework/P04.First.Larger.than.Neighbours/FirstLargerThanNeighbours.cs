using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.First.Larger.than.Neighbours
{
    class FirstLargerThanNeighbours
    {

        public static int FirstLargerThanNeighs(int[] values)
        {
            for (int i = 0; i <= values.Length - 1; i++)
			{
                if (i == values.Length - 1)
                {
                    return -1;
                }
                else if ((values[i] > values[i + 1]) && (values[i] > values[i + 2]))
                {
                    return i;
                }
			}
            return -1;
        }
        static void Main()
        {
            string input = Console.ReadLine();
            int[] inputValues = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.WriteLine(FirstLargerThanNeighs(inputValues));
        }
    }
}