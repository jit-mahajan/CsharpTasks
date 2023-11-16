using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableAndIEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> years = new List<int>();

            years.Add(1990);
            years.Add(1992);
            years.Add(1994);
            years.Add(1996);
            years.Add(1998);
            years.Add(2000);
            years.Add(2001);
            years.Add(2002);
            years.Add(2003);

            Console.WriteLine("By IEnumerator");
            IEnumerator<int> ienumerate = years.GetEnumerator();

            IterateByIEnumerator90To2001(ienumerate);

            Console.WriteLine();
            Console.WriteLine("By IEnurable : ");
            IEnumerable<int> ienumerable = (IEnumerable<int>)years;
            IterateByIEnumerable90To2001(ienumerable);


        }

        static void IterateByIEnumerator90To2001 (IEnumerator<int> o)
        {
            while (o.MoveNext())
            {
                Console.WriteLine(o.Current.ToString());

                if (Convert.ToInt16(o.Current) > 2000)
                {
                    IterateByIEnumeratorAbove2001(o);
                }
            }
        }

        static void IterateByIEnumeratorAbove2001(IEnumerator<int> o)
        {
            while (o.MoveNext())
            {
                Console.WriteLine(o.Current.ToString());
            }

        }

        static void IterateByIEnumerable90To2001(IEnumerable<int> o)
        {
            foreach(int item in o)
            {
                Console.WriteLine(item);

                if(item > 2000)
                {
                    IterateByIEnumerableAbove2001(o);
                }
            }
        }

        static void IterateByIEnumerableAbove2001(IEnumerable<int> o)
        {
            foreach(int item in o)
            { Console.WriteLine(item); 
            }
        }

    }
}
