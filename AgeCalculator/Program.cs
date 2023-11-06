using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var personInfo = new PersonInfo(new DateTime(1998, 4, 6));

            Console.WriteLine("Person's Age : "+personInfo.Age);
        }
    }
}
