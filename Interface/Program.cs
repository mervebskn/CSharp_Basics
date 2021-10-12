using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer custormer1 = new Customer();
            custormer1.add();
            custormer1.delete();

            Supplier supplier1 = new Supplier();
            supplier1.update();

            //Icustomer customer1 = new Customer();
            //classtan oluşturduğumuz instance'ı ,miras alıdığımız ınterface karşılayabilir.

            Console.ReadLine();
        }
    }
}
