using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorEx
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        /*
        public Vehicle()
        {

            Console.WriteLine("Vehicle Class Constructor Called");
        }

        */


        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;

            Console.WriteLine("Vehicle is being Initialized. {0}",registrationNumber);
        }

    }
}
