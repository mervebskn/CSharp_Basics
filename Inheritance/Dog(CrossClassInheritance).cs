using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Dog_CrossClassInheritance_ : Cat
    {
        //kedi sınıfı hayvan sınıfı miras aldığı için , köpek sınıfı da hem kedş hem hayvan sınıfındaki propertyleri kullanabilir.
        //protected olan EyeColor propertysine değer atayıp class içinde kullandık , cat classını miras aldığı için.

        public void ShowDogInform()
        {
            EyeColor = "Yeşil";

            Console.WriteLine("hayvan ismi : " + Animal_Name);
            Console.WriteLine("hayvan cinsiyeti : " + Animal_Gender);
            Console.WriteLine("hayvan rengi : " + Animal_Color);
            Console.WriteLine("hayvan göz rengi : " + EyeColor);
        }
    }
}
