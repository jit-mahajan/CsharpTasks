using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Method1();
            Method2();
            Console.WriteLine("Main Thread");
            Console.ReadLine();
        }

        static void Method1()
        {
            Task.Run(new Action(LongTask));
            Console.WriteLine("New Thred");
        }

        static async void Method2()
        {
           await Task.Run(new Action(LongTask));
            Console.WriteLine("New Thred");
        }
        static void LongTask()
        {
            Thread.Sleep(2000);
        }
    }
}
