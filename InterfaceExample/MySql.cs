using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class MySql : ICustomer
    {
        public void add()
        {
            Console.WriteLine("mysql ekledi");
        }

        public void delete()
        {
            Console.WriteLine("mysql sildi");
        }

        public void update()
        {
            Console.WriteLine("mysql güncelledi");
        }
    }
}
