using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P02.Line.Numbers
{
    class LineNumbers
    {
        static void Main()
        {
            var readFile = new StreamReader(Console.ReadLine());
            using (readFile)
            {
                var writeFile = new StreamWriter(Console.ReadLine());
                using (writeFile)
                {
                    string fileLine;
                    int lineNumber = 1;

                    do
	                {
                        fileLine = readFile.ReadLine();
                        writeFile.WriteLine("{0}  {1}", lineNumber, fileLine);
                        lineNumber++;
	                } while (fileLine != null);
                }
            }
        }
    }
}