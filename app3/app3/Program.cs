using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciadi, sifre;

            Console.Write("Kullanıcı Adını Girin : ");
            kullaniciadi = Console.ReadLine();
            Console.Write("Şifreyi girin : ");
            sifre = Console.ReadLine();

            if(kullaniciadi=="Harry" && sifre=="Potter")
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Tekrar Deneyiniz");
            }
            Console.ReadLine();
        }
    }
}
