using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace app8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // klavyeden grilen ismin arasındaki boşlukları silip diziye aktaran program 

            string isim,a;

            Console.Write("İsmi girin :");
            isim = Console.ReadLine();

            a = isim.Trim(); // ismin baştaki ve sondaki boşlukları siler
            a = isim.Replace(" ", string.Empty); //  replace string ifadedeki karakterleri değiştirmeye yarayan metotdur.
                                                 //  bir karakter boşluk yerine string.empty konuldu
                                                 
            Console.WriteLine("ismin boşluksuz uzunluğu : {0}",a.Length );

            string[] dizi = new string[a.Length]; 

            for(int i=0;i<a.Length;i++)
            {
                dizi[i] = a[i].ToString(); // isimin her bir harfini dizinin i. indise  atadık 
            }

            // sonuç verileri ekrana yazdırdı
            foreach (string harfler in dizi)
            {
                Console.WriteLine(harfler);
            }

            Console.ReadLine();
        }
    } 
}   