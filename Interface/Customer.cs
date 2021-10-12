using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Customer : ICustomer    //ctrl+. ile metotları implement ettik. Interface içindeki metotları override etmeli , kullanmalı.
    {
        public void add()
        {
            Console.WriteLine("müşteri eklendi.");
        }

        public void delete()
        {
            Console.WriteLine("müşteri silindi.");
        }

        public void get()
        {
            Console.WriteLine("müşteri getirildi.");
        }

        public void update()
        {
            Console.WriteLine("müşteri güncellendi.");
        }
    }
}
