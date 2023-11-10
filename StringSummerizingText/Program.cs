using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSummerizingText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "This is a very good session of ASP.Net in history";

            var output = Stringutility.SummerizeText(sentence);
            Console.WriteLine(output);


        }
    }
}
