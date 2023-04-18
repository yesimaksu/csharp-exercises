using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Rastgele değerler ile doldurulan dizinin ortalamasını hesaplayan program [for, foreach, array]*/

            int rastgele, n,ortalama,toplam=0;

            Console.Write("n girin :");
            n = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();

            int[] sayilar= new int[n];
            for (int i = 0; i < n; i++)
            {
                rastgele = rnd.Next(1, 100);
                sayilar[i] = rastgele;
                Console.WriteLine("{0}.indis elemanı :{1}", i, sayilar[i]);
            }
            
            foreach(int sayi in sayilar)
            {
                toplam = toplam + sayi;
            }
            ortalama = toplam / n;
            Console.WriteLine("Ortalama değeri :{0}",ortalama);
            Console.ReadLine();

        }
    }
}
