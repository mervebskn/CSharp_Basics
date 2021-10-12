using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }

        public Customer(int _Id,string _Name,string _Surname,string _Gender,string _Email)
        {
            this.Id = _Id;                //bu classın içindeki Id değerine , parametre olarak gelen _Id yi atamış olduk.
            this.Name = _Surname;
            this.Gender = _Gender;
            this.Email = _Email;
        }

        //müşterileri koleksiyonda tutmak için arraylist tanımladık. instance oluşturduk. müşteri classındaki herkes bu listeye erişebilsin diye static olarak tanımladık. static tanımlamasaydık her müşteri referansında bu arraylist sıfırdan başlardı. her objeye özgü olacaktı

        public static ArrayList customers = new ArrayList();

        public CustomerEnum addcustomer(Customer m1)
        {
            customers.Add(m1);
            return CustomerEnum.recordsuccess;
        }
    }
}
