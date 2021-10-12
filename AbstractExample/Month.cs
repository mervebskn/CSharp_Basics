using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    public abstract class MonthAbst
    {
        public int timeofday()
        {
            return 24;
        }
        public abstract int numberofmonth();
        public abstract int numberdays();

        //abstract class oluşturup her class için aynı değeri tanışan timeofday metodunu bir kez yazmış olduk.
        //diğer classlar (ocak şubak mart) bu metodu kullandı. diğer abstract metotlar (numberofmonth,numberdays) override edilip her classa özgü giydirdik.

    }
}
