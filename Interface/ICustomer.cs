using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface ICustomer
    {
        //interface içinde metotlar tanımlarız.
        //metotların erişim belirleyicisi olmaz. bodyleri olmaz(içerik).

        void add();
        void delete();
        void update();
        void get();
    }
}
