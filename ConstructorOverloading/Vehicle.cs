using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading
{
    internal class Vehicle
    {
        public int wheels;
        public string company;
        public int price;
        public string availibility;

        public Vehicle(int wheels, string company, int price, string availibility)
        {
            this.wheels = wheels;
            this.company = company;
            this.price = price;
            this.availibility = availibility;
        }

        public Vehicle(int wheels, int price)
        {
            this.wheels = wheels;
            this.price = price;

        }

        public Vehicle(string company, int price, string availibility, int wheels)
        {
            this.company = company;
            this.price = price;
            this.availibility = availibility;
            this.wheels = wheels;
        }
    }
}
