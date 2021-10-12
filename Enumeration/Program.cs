using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1,"Merve","Baskan","K","asd@gmail.com");

            CustomerEnum donendurum = customer.addcustomer(customer);

            if (donendurum==CustomerEnum.recordsuccess)
            {
                Console.WriteLine("müşteri başarılı şekilde eklenmiştir.");
            }
            else
            {
                Console.WriteLine("müşteri eklenemedi");
            }
            Console.ReadLine();
        }
    }
}
