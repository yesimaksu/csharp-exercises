using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app12
{
    // Öğrenci puanını hesaplayan program .
    public class Ogrenci
    {
        public double Ogrencipuanhesapla(double sınav1, double sınav2, double sınav3)
        {
            double ortalama = (sınav1 + sınav2 + sınav3) / 3;
            return ortalama;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sınav 1 'i girin : ");
            double sınav1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sınav 2 'i girin : ");
            double sınav2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sınav 3 'ü girin : ");
            double sınav3 = Convert.ToDouble(Console.ReadLine());

            Ogrenci ogr = new Ogrenci();
            double ogrencipuanhesapla = ogr.Ogrencipuanhesapla(sınav1, sınav2, sınav3);
            ogrencipuanhesapla = Math.Round(ogrencipuanhesapla); // ortalamayı yuvarlama .
            Console.WriteLine("Ortalama :" + ogrencipuanhesapla);

            if (ogrencipuanhesapla > 45)
            {
                Console.WriteLine("Geçti ");
            }
            else
            {
                Console.WriteLine("Kaldı");
            }
            Console.ReadLine();
        }
    }
}
