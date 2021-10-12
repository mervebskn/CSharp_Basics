using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    public class January : MonthAbst
    {
        public override int numberdays()
        {
            return 30;
        }

        public override int numberofmonth()
        {
            return 1;
        }
    }
}
