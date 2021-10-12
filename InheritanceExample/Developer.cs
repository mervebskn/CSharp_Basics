using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Developer : Worker
    {
        //burada da contructor metodu yazılmalı( prop lar private )
        //base : miras aldığım classın contructor metodunu temsil eder.
        //developer classından nesne türetince , 3 parametre alacak , ben bu parametreleri Workerdaki parametrelere göndermiş olucam.

        public Developer(int _Id,string _Name,string _Surname,string _Language) :base(_Id,_Name,_Surname)
        {
            this.Language = _Language;
        }
        private string Language;

        public void ToFormat(string OperatingSystem)
        {
            Console.WriteLine(getName() + " , " + OperatingSystem+"işletim sistemine format atıyor.");
        }
    }
}
