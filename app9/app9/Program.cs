using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace app9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // hashtable oluşturup E derse değer ekliyecek H derse eklenen değerler listelenecek 

            string harf = string.Empty;

            Hashtable sozluk = new Hashtable();

            while (harf != "Q")
            {
                Console.WriteLine("değer eklemek istiyorsanız E listelemek istiyorsanız H programı sonlandırmak istiyorsanız Q basınız");
                harf = Console.ReadLine();

                if (harf == "E")
                {
                    Console.Write("kaç adet veri gireceksiniz  : ");
                    int adet = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= adet; i++)
                    {
                        Console.Write("key girin :"); // key değerini girilmesini istiyoruz
                        string key = Console.ReadLine();
                        Console.Write("{0} değerinin value değerini girin :", key); // key değerinin value değerini istiyoruz .
                        string value = Console.ReadLine();
                        sozluk.Add(key, value);
                    }
                }

                else if (harf == "H")
                {
                    foreach (var item in sozluk.Keys)
                    {
                        Console.WriteLine("{0} - {1}", item, sozluk[item]);
                    }
                }
            }

            Console.WriteLine(" program bitti ");
            Console.ReadLine();
        }
    }
}
