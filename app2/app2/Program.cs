using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan gelen 3 farklı sınav notunun ortalaması 45 değerine eşit veya büyük mü kontrol edelim.*/

            int sinav1, sinav2, sinav3, ortalama;

            Console.Write("1.Sınav Notu : ");
            sinav1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2.Sınav Notu : ");
            sinav2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("3.Sınav Notu : ");
            sinav3 = Convert.ToInt32(Console.ReadLine());

            ortalama = (sinav1 + sinav2 + sinav3) / 3;
            string sonuc = "";

            if (ortalama >= 90)
            {
                sonuc = "AA";
            }
            else if (ortalama >= 80)
            {
                sonuc = "BA";
            }
            else if (ortalama >= 75)
            {
                sonuc = "BB";
            }
            else if (ortalama >= 70)
            {
                sonuc = "CB";
            }
            else if (ortalama >= 60)
            {
                sonuc = "CC";
            }
            else if (ortalama >= 50)
            {
                sonuc = "DC";
            }
            else if (ortalama >= 40)
            {
                sonuc = "DD";
            }
            else
            {
                sonuc = "FF";
            }

            Console.WriteLine($"Ortalama : {ortalama} - Harf : {sonuc}");
            Console.ReadLine();
        }
    }
}
