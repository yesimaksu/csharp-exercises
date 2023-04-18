using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app11
{
    internal class Program
    {
        static void Toplama(int a, int b) // toplama methodu toplama işlemini yapar .
        {
            int toplam = a + b;
            Console.WriteLine("{0} + {1} = {2} ", a, b, toplam); 
        }

        static void Cikarma(int a, int b) // cıkarma methodu çıkarma işlemini yapar .
        {
            int cikarma = a - b;
            Console.WriteLine("{0} - {1} = {2} ", a, b, cikarma);
        }

        static void Carpma(int a, int b) // carpma methodu çarpma işlemini yapar .
        {
            int carpma = a * b;
            Console.WriteLine("{0} * {1} = {2} ", a, b, carpma);
        }

        static void Bolme(int a, int b) // bolme methodu bölme işlemini yapar .
        {
            double bolme = a / b;
            Console.WriteLine("{0} / {1} = {2}", a, b, bolme);
        }

        static void Mod(int a, int b) // mod alma methodu a'nın b'ye modunu alır .
        {
            int mod = a % b;
            Console.WriteLine("{0} % {1} = {2} ", a, b, mod);
        }

        static void Ustal(int a, int b) // üstalma methodu a' nın b üssünü alır.
        {
            int ustalma = 1;
            for (int i=1;i<=b;i++)
            {
                ustalma = ustalma * a;
            }
            Console.WriteLine("{0} ^ {1} = {2} ",a,b,ustalma);
        }
        static void Karekok(int a, int b)
        {
            double kokA = Math.Sqrt(Convert.ToDouble(a));
            double kokB = Math.Sqrt(Convert.ToDouble(b));
            Console.WriteLine("Karekök {0} = {1} ",a,kokA);
            Console.WriteLine("Karekök {0} = {1} ",b,kokB);

        }

        static void Menu() // menu methodu ile yapılacak işlemler listelendi .
        {
            string[] islemler = { "Toplama", "Çıkarma", "Çarpma", "Bölme", "Mod","Üst Al","Karekök" };

            for (int i = 0; i < islemler.Length; i++)
            {
                Console.WriteLine("{0} - {1} ", i + 1, islemler[i]);
            }
        }

        static void Main(string[] args)
        {
            // klavyeden girilen değere göre işlem yapan program .

            Menu(); // menü methodunu çağırdık .

            Console.Write("Yapılacak işlem : ");
            int islem = Convert.ToInt32(Console.ReadLine());

            Console.Write("a sayısını girin : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b sayısını girin : ");
            int b = Convert.ToInt32(Console.ReadLine());


            switch (islem)
            {
                case 1:
                    Toplama(a, b); // toplama methodunu çağırdık :
                    break;
                case 2:
                    Cikarma(a, b); // cıkarma methodunu çağırdık :
                    break;
                case 3:
                    Carpma(a, b); // carpma methodunu çağırdık :
                    break;
                case 4:
                    Bolme(a, b); // bölme methodunu çağırdık :
                    break;
                case 5:
                    Mod(a, b); // mod alma methodunu çağırdık :
                    break;
                case 6:
                    Ustal(a, b); // üst alma methodunu çağırdık :
                    break;
                case 7:
                    Karekok(a, b); // karekok methodunu çağırdık :
                    break;
                default:
                    Console.WriteLine("1-7 arası değer giriniz ");
                    break;
            }

            Console.ReadLine();
        }

    }
}
