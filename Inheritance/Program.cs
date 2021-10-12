using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir class sadece bir classı miras alabilir.*****

            Console.WriteLine("Kedi bilgileri:");

            Cat cat1 = new Cat();
            cat1.Animal_Name = "Boncuk";
            cat1.Animal_Gender = "Dişi";
            cat1.Animal_Color = "Beyaz";

            cat1.ShowAnimalInform();

            Console.WriteLine("Köpek bilgileri:");


            Dog_CrossClassInheritance_ dog1 = new Dog_CrossClassInheritance_();
            dog1.Animal_Name = "Mavi";
            dog1.Animal_Gender = "Dişi";
            dog1.Animal_Color = "Siyah";

            dog1.ShowDogInform();

            Console.ReadLine();
        }
    }
}
