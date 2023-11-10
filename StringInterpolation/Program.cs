using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 20;
            int b = 40;
            string s = "";

            //  s = "The sum of " + a + " and " + b + " is " + (a + b);

            //  Console.WriteLine(s);


            //  s = String.Format("The sum of {0} and {1} is {2}", a, b, a+b);
            //Console.WriteLine(s);

            s = $"The sum of {a} and {b} is {a+b}";
            Console.WriteLine(s);
        }
    }
}
