using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********String*****************");
            string s1 = "Jitesh";

            Console.WriteLine(s1);
            Console.WriteLine(s1.GetHashCode());
            s1 += " Mahajan";

            Console.WriteLine(s1);
            Console.WriteLine(s1.GetHashCode());



            StringBuilder sb = new StringBuilder("Jitesh");
            Console.WriteLine("*********StringBuilder*****************");
            Console.WriteLine(sb);
            Console.WriteLine(sb.GetHashCode());
            sb.Append(" Mahajan");
            sb.Append(" BE");
            Console.WriteLine(sb);
            Console.WriteLine(sb.GetHashCode());
        }

    }
}
