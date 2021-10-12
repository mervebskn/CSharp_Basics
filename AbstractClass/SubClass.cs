using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class SubClass : MainClass         //abstract class miras alınırsa, burada abstract classtaki metotlar implement edilmeli.
    {
        public override void metot2()
        {
            Console.WriteLine("metot2 çalıştı.");
        }
    }
}
