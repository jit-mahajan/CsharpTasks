using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorUse
{

    internal class Employee
    {

        int id;
        string name;
        string city;

        public Employee() { }  
        public Employee(int id, string name, string city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.id = 101;
            emp1.name = "Jorden";
            emp1.city = "Mumbai";

            Employee emp2 = new Employee(102, "Ron", "Pune");

            Console.WriteLine("Employee Id :"+ emp1.id  );
            Console.WriteLine("Employee Name :" + emp1.name);
            Console.WriteLine("Employee City :" + emp1.city);

            Console.WriteLine("Employee Id :" + emp2.id);
            Console.WriteLine("Employee Name :" + emp2.name);
            Console.WriteLine("Employee City :" + emp2.city);
        }
    }
}
