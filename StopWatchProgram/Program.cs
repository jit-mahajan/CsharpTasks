using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatchProgram
{
    public class Program
    {
        static void Main(string[] args)
        {

            var functionality = new Functionality();


            for (var i = 1; i < 3; i++)
            {

                functionality.Start();

                Thread.Sleep(1000);

                functionality.Stop();

                Console.WriteLine("Duration : " + functionality.GetTimeSpan());

                Console.WriteLine("Press Enter to Run StopWatch!!!!!");

                Console.ReadLine();
            }
        }
    }
}
