using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Supplier : ICustomer
    {
        public void add()
        {
            Console.WriteLine("satıcı eklendi.");
        }

        public void delete()
        {
            Console.WriteLine("satıcı silindi.");
        }

        public void get()
        {
            Console.WriteLine("satıcı getirildi.");
        }

        public void update()
        {
            Console.WriteLine("satıcı güncellendi.");
        }
    }
}
