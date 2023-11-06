using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle(4, "Mahindra", 850000, "Yes");

            Vehicle v2 = new Vehicle(2,825000);

            Vehicle v3 = new Vehicle("Honda", 285000, "No", 2);

            Console.WriteLine("Vehicle 1 Details are :");
            Console.WriteLine("Type : "+v1.wheels);
            Console.WriteLine("Company : " + v1.company);
            Console.WriteLine("Price : " + v1.price);
            Console.WriteLine("Availibility : " + v1.availibility);

            Console.WriteLine("Vehicle 2 Details are :");
            Console.WriteLine("Type : " + v2.wheels);
            Console.WriteLine("Price : " + v2.price);
        }
    }

    
}
