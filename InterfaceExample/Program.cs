using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerController c1 = new CustomerController();
            c1.addcustomer(new SQLServer());
            c1.addcustomer(new Oracle());
            c1.addcustomer(new MySql());

            //Interface'i implement eden classtan oluşturduğumuz örneği interface karşılayabilir.

            Console.ReadLine();
        }
    }
}
