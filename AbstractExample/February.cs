using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    public class February : MonthAbst
    {
        public override int numberdays()
        {
            return 28;
        }

        public override int numberofmonth()
        {
            return 2; ;
        }
    }
}
