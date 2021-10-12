using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //int değerler alan bir instance(numbers) oluşturdum
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }

            //Generic collection faydası : Arraylist ile bi örnek oluşturunca obje tipinde tip istiyor , müşteri tipinde değer eklidik. bu değerler arka planda boxing işlemine tabi tutularak obje veri tipine çevriliyor. sonra müşterilere erişmek isteyince mesela 5. indexteki müşteriyi isteyince , o müşteri müşteri tipinde değil obje tipinde geliyor. unboxing yapıp tür dönüşümü yapıp , müşteri olarak yakalayıp öyle işlem yapmak zorunda kalıyoruz. generic koleksiyonda buna gerek kalmicak.

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer(1, "merve", "baskan", "m@gmail.com"));
            customers.Add(new Customer(2, "aslı", "baskan", "a@gmail.com"));
            customers.Add(new Customer(3, "burak", "baskan", "b@gmail.com"));
            customers.Add(new Customer(4, "selim", "baskan", "s@gmail.com"));

            foreach(Customer c in customers)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("koleksiyon boyutu : " + customers.Count);

            //customers.Clear();  //koleksiyondaki değerler silinir.
            //customers.RemoveAt(2);  //2.indexdeki değeri silecek.

            Console.ReadLine();
        }
    }
}
