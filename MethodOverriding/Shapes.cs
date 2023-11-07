using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{

    public class Circle : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("Circle is Drawn.....");
        }
    }

    public class Rectangle : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle is Drawn.....");
        }
    }

    public class Shapes
    {

        public int Width {  get; set; }
        public int Height { get; set; } 

      
        public virtual void Draw()
        {

        }
    }
}
