using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public  class Animal                 //miras veren class : Base class
    {
        public string Animal_Name { get; set; }
        public string Animal_Gender { get; set; }
        public string Animal_Color { get; set; }

        public void ShowAnimalInform()
        {
            Console.WriteLine("hayvan ismi : " + Animal_Name);
            Console.WriteLine("hayvan cinsiyeti : " + Animal_Gender);
            Console.WriteLine("hayvan rengi : " + Animal_Color);
        }

        //public sealed class Animal : olarak classı tanımlasaydım , sealed keywordu ile bu class miras alınamazdı. (ctrl+space)
    }
}
