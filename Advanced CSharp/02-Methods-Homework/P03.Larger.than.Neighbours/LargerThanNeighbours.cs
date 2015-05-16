using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.Larger.than.Neighbours
{
    class LargerThanNeighbours
    {

        public static bool IsLarger(int[] nums, int p)
        {
            if (p == nums.Length - 1)
            {
                return true;
            }
            else if ((nums[p] > nums[p + 1]) && (nums[p] > nums[p + 2]))
            {
                return true;
            }
            return false;
        }
        static void Main()
        {
            string input = Console.ReadLine();
            int[] values = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i <= values.Length - 1; i++)
            {
                Console.WriteLine(IsLarger(values, i));
            }
        }
    }
}
