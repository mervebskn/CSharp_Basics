using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Cat : Animal    //Cat : miras alan class : Sub Class tır.
    {
        //Animal class'ını miras aldığı için , Animal class ta tanımlanan property'leri kullanabiliriz.
        //protected olarak tanımlanan EyeColor propertysine sadece miras alan classlar erişir.

        protected string EyeColor { get; set; }
    }
}
