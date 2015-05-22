using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P01.Odd.Lines
{
    class OddLines
    {
        static void Main()
        {
            try
            {
                StreamReader reader = new StreamReader(Console.ReadLine());

                Console.WriteLine();

                string line;
                int lineNum = 0;

                using(reader)
                {
                    do
                    {
                        line = reader.ReadLine();
                        lineNum++;
                        line = reader.ReadLine();
                        Console.WriteLine("{0, 2}  {1}", lineNum, line);
                        lineNum++;
                    } while (line != null);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No such file found!");
            }
        }
    }
}