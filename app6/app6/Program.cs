using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dizi içine rastgele eleman atayan program.

            int n, rastgeleindis, rastgeledeger, sayac = 0;

            // klavyeden dizi eleman sayısı belirlendi.
            Console.Write("n değerini girin : ");
            n = Convert.ToInt32(Console.ReadLine());

            // random sınıfından rnd nesnesi üretildi.
            Random rnd = new Random();

            if (n > 3 && n < 11)
            {
                int[] veriler = new int[n]; // veriler dizisi oluşturuldu.

                // sayaç değişkeni dizinin dolu olup olmadığını kontrol eder.
                while (sayac != veriler.Length)
                { 
                    // rastgele indis ve değer üretildi.
                    rastgeledeger = rnd.Next(-11, 11);
                    rastgeleindis = rnd.Next(0, n);

                    if ( veriler[rastgeleindis] < 0 || veriler[rastgeleindis] > 0) // indisteki veri doluysa.
                    {
                        Console.WriteLine("{0}.indise {1} değer atanmıştır", rastgeleindis, veriler[rastgeleindis]);
                    }
                    else // indisteki veri boşsa diziye veri aktarımı yapılır.
                    { 
                        veriler[rastgeleindis] = rastgeledeger;
                        Console.WriteLine("{0}.indis {1}", rastgeleindis, veriler[rastgeleindis]);
                        sayac++; // her veri eklendiğinde sayaç artırılır.
                    }
                }
                foreach (int item in veriler) // veriler ekrana yazılır.
                {
                    Console.WriteLine($"dizideki veriler {item}");
                }

            }   Console.ReadLine();
        }
    }
}
