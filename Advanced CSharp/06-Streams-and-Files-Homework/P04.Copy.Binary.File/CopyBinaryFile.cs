using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P04.Copy.Binary.File
{
    class CopyBinaryFile
    {
        static void Main()
        {
            CopyBinFile();
        }

        static void CopyBinFile()
        {
            Console.Write("Enter file path and name: ");
            FileStream src = new FileStream(Console.ReadLine(), FileMode.Open);
            
            Console.Write("Enter directory to copy to and file name: ");
            FileStream copySrcTo = new FileStream(Console.ReadLine(), FileMode.Create);
            
            using (src)
            { 
                using (copySrcTo)
                {
                    byte[] buffer = new byte[4096];
                    Console.WriteLine("\nCopying...");
                    while (true)
                    {
                        int readBytes = src.Read(buffer, 0, buffer.Length);
                    
                        if (readBytes == 0)
                        {
                            break;
                        }

                        copySrcTo.Write(buffer, 0, readBytes);
                    }
                    
                    Console.WriteLine("\nFinished copying\n");
                }
            }
        }
    }
}