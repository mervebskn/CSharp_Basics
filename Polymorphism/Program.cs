using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir metodu birden çok şekilde iş yükleyerek kullanarak farklı şekilde kullanmaya olanak sağlar.

            Console.WriteLine("şekil uygulaması...");
            while (true)
            {
                Console.WriteLine("işlem seçin :");
                Console.WriteLine("1-dikdörtgen işlemleri");
                Console.WriteLine("2-kare işlemleri");
                Console.WriteLine("q-çıkış");

                string choise = Console.ReadLine();

                if (choise == "q")
                {
                    break;
                }
                else if (choise == "1")
                {
                    while (true)
                    {
                        Console.WriteLine("1-dikdörtgen alanı hesapla");
                        Console.WriteLine("2-dikdörtgen bilgileri göster");
                        Console.WriteLine("q- dikdörtgenden çıkış");

                        string choiseRectangle = Console.ReadLine();

                        if (choiseRectangle == "1")
                        {
                            Console.Write("kısa kenarı girin : ");
                            int Shortedge = Convert.ToInt32(Console.ReadLine());
                            Console.Write("uzun kenarı girin : ");
                            int Longedge = Convert.ToInt32(Console.ReadLine());
                            Rectangle rectangle = new Rectangle("Dikdörtgen",Shortedge,Longedge);
                            rectangle.CalculateShape();
                        }
                        else if (choiseRectangle == "2")
                        {
                            Console.Write("kısa kenarı girin : ");
                            int Shortedge = Convert.ToInt32(Console.ReadLine());
                            Console.Write("uzun kenarı girin : ");
                            int Longedge = Convert.ToInt32(Console.ReadLine());
                            Rectangle rectangle = new Rectangle("Dikdörtgen", Shortedge, Longedge);
                            rectangle.ShowShapeInformation();
                        }
                        else if (choiseRectangle == "q")
                        {
                            Console.WriteLine("dikdörtgen işlemlerinden çıkılıyor...");
                            break;
                        }

                    }
                }
                else if (choise == "2")
                {
                    while (true)
                    {
                        Console.WriteLine("1-kare alanı hesapla");
                        Console.WriteLine("2-kare bilgileri göster");
                        Console.WriteLine("q- kareden çıkış");

                        string choisesquare = Console.ReadLine();

                        if (choisesquare == "1")
                        {
                            Console.Write("kenarı girin : ");
                            int edge = Convert.ToInt32(Console.ReadLine());
                            Square square = new Square("Kare",edge);
                            square.CalculateShape();
                        }
                        else if (choisesquare == "2")
                        {
                            Console.Write("kenarı girin : ");
                            int edge = Convert.ToInt32(Console.ReadLine());
                            Square square = new Square("Kare",edge);
                            square.ShowShapeInformation();
                        }
                        else if (choisesquare == "q")
                        {
                            Console.WriteLine("kare işlemlerinden çıkılıyor...");
                            break;
                        }
                    }
                }
                else if (choise == "q")
                {
                    break;
                }
            }
        }
    }
}
