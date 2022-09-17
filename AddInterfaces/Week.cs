using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddInterfaces
{
    internal class Week:IEnumerable
    {
        string[] days = {"Monday","Tuesday","Wednesday",
                        "Thursday","Friaday","Saturday",
                        "Sunday"};

        public IEnumerator GetEnumerator()
        {
            return new WeekEnumerator(days);
        }
    }
}
