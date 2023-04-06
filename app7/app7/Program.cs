using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace app7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*10 elemanlı dizi içine kulanıcının 10tane şehir eklemesini sağlayan 
             * Girilen baş harfe göre şehirleri listeleyen program [for, if, foreach, array]*/

            Console.WriteLine("\t\t*** ŞEHİR BİLGİLERİNİ GİRİN ***");
            string[] sehirler = new string[10];

            for (int i = 0; i < sehirler.Length; i++)
            {
                Console.Write($"{i + 1}. Şehri girin : ");
                sehirler[i] = Console.ReadLine();
            }
            Array.Sort(sehirler); // dizi elemanları küçükten büyüğe / a-z sıralandı.

            foreach (string sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

            Console.ReadLine();
        }
    }
}
