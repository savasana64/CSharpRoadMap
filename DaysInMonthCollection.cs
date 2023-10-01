using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace EnumeratorExample
{
    internal class DaysInMonthCollection : IEnumerable<MonthWithDays>
    {

        //this here is an example of factory methos pattern
        public IEnumerator<MonthWithDays> GetEnumerator()
        {
            return new DaysInMonthEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
