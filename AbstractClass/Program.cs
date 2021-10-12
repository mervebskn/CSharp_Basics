using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //abst classtan örnek oluşturulmaz. new'lenemez. bir tane abst class miras alınır sadece.

            SubClass subclass1 = new SubClass();
            subclass1.metot1();
            subclass1.metot2();

            Console.ReadLine();
        }
    }
}
