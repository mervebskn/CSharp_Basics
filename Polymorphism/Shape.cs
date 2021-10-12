using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Shape
    {
        public string name { get; set; }
        public Shape(string _name)
        {
            this.name = _name;
        }
        public string getname()
        {
            return this.name;
        }
        public virtual void CalculateShape()
        {
            Console.WriteLine("şeklin alanı hesaplanıyor..");
        }
        public virtual void ShowShapeInformation()
        {
            Console.WriteLine(getname()+"'nin bilgileri..");
        }
    }
}
