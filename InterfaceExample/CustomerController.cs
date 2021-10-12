using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class CustomerController
    {
        public void addcustomer(ICustomer database)
        {
            database.add();
        }


        //eğer ınterface kullanmasaydık her class için bir metot yazmak zorunda kalırdık : 3

        //    public void addcustomersql(SQLServer database)
        //    {
        //   database.add();
        //     }

        //    public void addcustomeroracle(Oracle database)
        //    {
        //   database.add();
        //     }

        //    public void addcustomermysql(Mysql database)
        //    {
        //   database.add();
        //     }
    }
}
