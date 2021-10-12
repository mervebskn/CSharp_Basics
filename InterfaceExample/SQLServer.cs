using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class SQLServer : ICustomer
    {
        public void add()
        {
            Console.WriteLine("sqlserver ekledi");
        }

        public void delete()
        {
            Console.WriteLine("sqlserver sildi");
        }

        public void update()
        {
            Console.WriteLine("sqlserver güncelledi");
        }
    }
}
