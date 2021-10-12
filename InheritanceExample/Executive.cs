using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Executive : Worker
    {

        private int NumberEmployed;
        public Executive(int _Id, string _Name, string _Surname, int _NumberEmployed) : base(_Id,_Name,_Surname)
        {
            this.NumberEmployed = _NumberEmployed;
        }

        public void ExtraSalary(int amount)
        {
            Console.WriteLine("patron : "+getName()+"çalışanlarına"+amount+"miktar zaman yapıyor.");
        }
    }
}
