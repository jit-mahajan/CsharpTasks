using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileCopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var src = @"C:\Tasks\SourceFile.txt";
            var dest = @"C:\Programs\SourceFile.txt";

            try
            {
                if (File.Exists(src))
                {
                    File.Copy(src, dest, true);

                    Console.WriteLine("File Copied....");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File Not Found");
            }

            var fileContent = File.ReadAllText(dest);

            Console.WriteLine(fileContent);

        }
    }
}
