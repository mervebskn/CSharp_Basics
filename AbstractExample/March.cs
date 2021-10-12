using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    public class March : MonthAbst
    {
        public override int numberdays()
        {
            return 31;
        }

        public override int numberofmonth()
        {
            return 3;
        }
    }
}
