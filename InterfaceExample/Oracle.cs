using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Oracle : ICustomer
    {
        public void add()
        {
            Console.WriteLine("oracle ekledi");
        }
        public void delete()
        {
            Console.WriteLine("oracle sildi");
        }
        public void update()
        {
            Console.WriteLine("oracle güncelledi");
        }
    }
}
