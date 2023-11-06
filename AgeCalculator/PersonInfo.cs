using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    public class PersonInfo
    {
        public PersonInfo(DateTime bithdate)
        {
            Birthdate = bithdate;
        }

        public DateTime Birthdate { get;private set;}


        public int Age
        {
            get
            {
                var timespan = DateTime.Today - Birthdate;

                var years = timespan.Days / 365;

                return years;
            }
        }
    }
}
