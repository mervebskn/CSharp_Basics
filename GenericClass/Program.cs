using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer tipinde (T) repository instance oluşturduk. Get metodunu kullandık ve T gördüğü her yer Customer olacak şekilde çalışır.

            Repository<Customer> repocustomer = new Repository<Customer>();
            List<Customer> customers = repocustomer.Get();
            //Customer tipinde liste döner.

            Customer c1 = new Customer();
            c1.Id = 1;
            c1.Name = "merve";
            c1.Surname = "Baskan";
            c1.Gender = "K";
            string output1 = repocustomer.Add(c1);
            Console.WriteLine("müşteri "+output1);

            Repository<Product> repoproduct = new Repository<Product>();
            List<Product> products = repoproduct.Get();

            Product p1 = new Product();
            p1.ProductId = 1;
            p1.ProductName = "Ram";
            p1.ProductPrice = 300;
            string output2 = repoproduct.Add(p1);
            Console.WriteLine("ürün "+output2);

            Console.ReadLine();
        }
    }
}
