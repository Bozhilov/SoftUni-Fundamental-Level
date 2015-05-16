using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CategorizeNumsMinMaxAvg
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] values = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        double[] nums = new double[values.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = double.Parse(values[i]);
        }

        List<double> roundNums = new List<double>();
        List<double> floatNums = new List<double>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 1 != 0)
            {
                floatNums.Add(nums[i]);
            }
            else
            {
                roundNums.Add(nums[i]);
            }
        }

        Console.Write("\n[");

        foreach (var n in floatNums)
        {
            Console.Write(n + ", ");
        }

        Console.Write("] -> min: {0:F2}, max: {1:F2}, sum: {2:F2}, avg: {3:F2}\n\n[", floatNums.Min(), floatNums.Max(), floatNums.Sum(), floatNums.Average());

        foreach (var n in roundNums)
        {
            Console.Write(n + ", ");
        }

        Console.Write("] -> min: {0:F2}, max: {1:F2}, sum: {2:F2}, avg: {3:F2}\n\n", roundNums.Min(), roundNums.Max(), roundNums.Sum(), roundNums.Average());
    }
}