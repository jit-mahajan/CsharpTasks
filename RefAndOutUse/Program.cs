using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOutUse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int OutsideVal = 40;

            Addition1(ref OutsideVal);
            Console.WriteLine(OutsideVal);

            Addition2(out OutsideVal);
            Console.WriteLine(OutsideVal);
        }

        static void Addition1(ref int InsideVar)
        {
            Console.WriteLine("Ref Method Called...");
            InsideVar = InsideVar + 20;
        }

        static void Addition2(out int InsiderVar)
        {
            Console.WriteLine("Out Method Called...");
            InsiderVar = 0;

            InsiderVar = InsiderVar + 20;
        }
    }
}
