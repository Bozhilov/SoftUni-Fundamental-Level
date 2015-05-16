using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.Bigger.Number
{
    class BiggerNumber
    {
        public static int GetMax(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
            {
                return firstNum;
            }
            else if (firstNum < secondNum)
            {
                return secondNum;
            }

            return (firstNum += secondNum) / 2;
            
        }

        static void Main()
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(numOne, numTwo));
        }
    }
}
