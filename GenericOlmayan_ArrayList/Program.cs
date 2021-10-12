using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericOlmayan_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //ArrayList , her veri tipini ekleyebilir.

            ArrayList collection = new ArrayList();
            collection.Add(1);
            collection.Add("Merve");
            collection.Add(2.5);

            */
            
            //tek tipte veri tipini ekleyebilmek için addvalue metodunu yazıp Main'de çağırdık.

            addvalue(5);
            addvalue(3);
            addvalue(7);

            Console.ReadLine();
        }

        static void addvalue(int value)
        {
            ArrayList colleciton = new ArrayList();
            colleciton.Add(value);
            Console.WriteLine(value);
        }
    }
}
