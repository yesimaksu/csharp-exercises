using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dizi içerisindeki en uzun metni bulan program 

            string metin;
            int sayac, enuzunmetin;
            string[] dizi = new string[10];


            for (int i = 0; i < 10; i++)
            {
                Console.Write("Metni girin :");
                metin = Console.ReadLine();
                dizi[i] = metin;

            }


            enuzunmetin = dizi[0].Length; 
            sayac = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (i + 1 < dizi.Length && enuzunmetin < dizi[i + 1].Length)
                {
                    enuzunmetin = dizi[i + 1].Length;
                    sayac = i + 1;
                }
            }
            Console.WriteLine("En uzun metin {0} karakterlidir,{1}.indistedir .", enuzunmetin, sayac);
            Console.ReadLine();
        }
    }
}
