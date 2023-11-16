using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 1000000, x => RunmillionIteraation());
            
        }

        private static void RunmillionIteraation()
        {
            string x = ""; 

            for(int iIndex = 0; iIndex < 1000000; iIndex++)
            {
                x = x + "J";
                Console.WriteLine(x);
            }

        }
    }
}
