using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class Repository<T>
    {
        //T tipinde liste döner.
        //<T> generic olarak ifade ederiz.
        //class , veritabanıyla ilişkili ise Repository adını veririz.

        public List<T> Get()       //T tipinde liste dönen metot.
        {
            //veritabanında ilgili tabloya gşt ve kayıtları getir.
            return null;
        }

        public string Add(T data)
        {
            //veritabanına git ilgili tabloya T tipindeki datayı ekle.
            return "bilgiler veritabanına eklendi.";
        }
    }
}
