using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Worker
    {
        private int Id;
        private string Name;
        private string Surname;

        public Worker(int _Id,string _Name,string _Surname)      //ctor metot
        {
            this.Id = _Id;            //bu classın içindeki propertyleri temsil eder.
            this.Name = _Name;
            this.Surname = _Surname;
        }

        public int getId()
        {
            return this.Id;        //classın içinde bulunan Id değerini dönecek.
        }
        public void setId(int _Id)
        {
            this.Id = _Id;    //parametre olarak gelen _Id değerini Prop Id ye atamış olduk.
        }
        public string getName()
        {
            return this.Name;
        }
        public void setName(string _Name)
        {
            this.Name = _Name;
        }
        public string getSurname()
        {
            return this.Surname;
        }
        public void setSurname(string _Surname)
        {
            this.Surname = _Surname;
        }

        public void ShowInformation()
        {
            Console.WriteLine("Id : " + this.Id);
            Console.WriteLine("İsim : " + this.Name);
            Console.WriteLine("Soyisim : " + this.Surname);
        }
    }
}
