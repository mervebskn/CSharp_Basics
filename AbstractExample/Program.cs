using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    class Program
    {
        static void Main(string[] args)
        {
            January jan = new January();
            Console.WriteLine("ocak gün saati "+jan.timeofday());

            February feb = new February();
            Console.WriteLine("şubat gün saati:"+feb.timeofday());

            March march = new March();
            Console.WriteLine("mart gün saati "+march.timeofday());

            Console.ReadLine();
        }
    }
}
