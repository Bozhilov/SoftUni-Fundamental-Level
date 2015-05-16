using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubsetSums
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int[] numValues = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Console.WriteLine();
        
        List<int> nonRepeatables = numValues.ToList();
        nonRepeatables = nonRepeatables.Distinct().ToList();

        var subsets = from m in Enumerable.Range(0, 1 << nonRepeatables.Count)
                      select from i in Enumerable.Range(0, nonRepeatables.Count)
                             where (m & (1 << i)) != 0
                             select nonRepeatables[i];
        bool output = false;

        foreach (var item in subsets)
        {
            int tempSum = 0;
            foreach (var n in item)
            {
                tempSum += Convert.ToInt32(n);
            }
            if (tempSum == num && item.Count() > 0)
            {
                Console.WriteLine(string.Join(" + ", item) + " = {0}", num);
                output = true;
            }
        }   

        if (output == false)
        {
            Console.WriteLine("No matching subsets.");
        }

        Console.WriteLine();
    }
}