using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Square : Shape
    {
        public int edge { get; set; }
        public Square(string _name,int _edge) : base(_name)
        {
            this.edge = _edge;
        }
        public override void CalculateShape()
        {
            base.CalculateShape();
            Console.WriteLine(getname()+"nin alanı : "+(this.edge*this.edge));
        }
        public override void ShowShapeInformation()
        {
            base.ShowShapeInformation();
            Console.WriteLine(getname()+"'nin kenarı : "+this.edge);
        }
    }
}
