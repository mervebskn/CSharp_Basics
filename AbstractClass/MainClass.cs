using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class MainClass       //abstract olmayan classta sadece bodysi olan metotlar tanımlarız.
    {
        public void metot1()
        {
            Console.WriteLine("metot1 çalıştı");
        }

        public abstract void metot2();      //abstract olarak yazılan metodun body'sini yazmıyoruz.

    }
}
