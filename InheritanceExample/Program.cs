using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer(1,"Merve","Baskan","C#,SQL,DAX");
            Executive executive = new Executive(2,"Aslı","Yıldız",65);

            Console.WriteLine("Çalışan uygulamasına hoşgeldiniz..");

            while (true)
            {
                Console.WriteLine("1- Developer İşlemleri");
                Console.WriteLine("2- Yönetici İşlemleri");
                Console.WriteLine("q- Çıkış");
                string choise = Console.ReadLine();


                if (choise == "q")
                {
                    Console.WriteLine("Programdan çıkılıyor");
                    break;
                }
                else if (choise == "1")
                {
                    Console.WriteLine("Yazılımcı işlemi seçiniz :");

                    while (true)
                    {
                        Console.WriteLine("1-Format at");
                        Console.WriteLine("2-Bilgileri göster");
                        Console.WriteLine("3-çıkış için q ya basın");
                        string developerChoise = Console.ReadLine();

                        if (developerChoise == "1")
                        {
                            Console.Write("İşletim sistemi girin :");
                            string system = Console.ReadLine();
                            developer.ToFormat(system);
                        }
                        else if (developerChoise == "2")
                        {
                            developer.ShowInformation();
                        }
                        else if (developerChoise == "q")
                        {
                            Console.WriteLine("çıkış yapılıyor..");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("lütfen geçerli işlem seçin..");
                        }
                    }
                }
                else if (choise == "2")
                {
                    Console.WriteLine("Yönetici işlemi seçiniz:");
                    Console.WriteLine("1-Zam yap");
                    Console.WriteLine("2-Yönetici bilgileri göster");
                    Console.WriteLine("3- çıkış için q ya basın");

                    string executiveChoise = Console.ReadLine();

                    while (true)
                    {
                        if(executiveChoise == "q")
                        {
                            Console.WriteLine("çıkış yapılıyor..");
                            break;
                        }
                        else if (executiveChoise == "1")
                        {
                            Console.Write("Zam miktarı giriniz : ");
                            int zammiktar = Convert.ToInt32(Console.ReadLine());
                            executive.ExtraSalary(500);
                        }
                        else if (executiveChoise == "2")
                        {
                            executive.ShowInformation();
                        }
                        else
                        {
                            Console.WriteLine("lütfen geçerli işlem seçin..");
                        }
                    }
                }
            }
        }
    }
}
