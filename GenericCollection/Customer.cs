using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public Customer(int _Id,string _Name,string _Surname,string _Email)
        {
            this.Id = _Id;
            this.Name = _Name;
            this.Surname = _Surname;
            this.Email = _Email;
        }

        //Customer tipinden oluşturduğumuz referansı ekrana yazdırınca ToString metodu tetiklenip aşağıdaki ifadeyi string olarak return edicek.
        public override string ToString()
        {
            return "Id : "+this.Id+" "+"İsim : "+this.Name+" "+"Soyadı : "+this.Surname+" "+" "+"Email : "+this.Email;
        }
    }
}
