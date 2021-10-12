using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Rectangle : Shape
    {
        public int shortedge { get; set; }
        public int longedge { get; set; }
        public Rectangle(string _name,int _shortedge,int _longedge) : base(_name)
        {
            this.shortedge = _shortedge;
            this.longedge = _longedge;
        }
        public override void CalculateShape()
        {
            base.CalculateShape();
            Console.WriteLine(getname()+"'nin alanı : "+(this.shortedge*this.longedge));
        }
        public override void ShowShapeInformation()
        {
            base.ShowShapeInformation();
            Console.WriteLine("şeklin ismi : "+getname());
            Console.WriteLine(getname()+"'nin kısa kenarı: "+this.shortedge);
            Console.WriteLine(getname()+"'nin uzun kenarı: "+this.longedge);
        }
    }
}
