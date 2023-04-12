using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace app10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // klavyeden girilen menüye göre arraylist işlemini yapan program 
            ArrayList değerler = new ArrayList(); // değerler adında bir arraylist oluşturduk 
            string secim = string.Empty;
            // hangi işlemi yapmak istiyorsak değeri seçiyoruz
            Console.WriteLine(" 1 - değer ekle ");
            Console.WriteLine(" 2 - değer listele ");
            Console.WriteLine(" 3 - değer ara ");
            Console.WriteLine(" 4 - değer düzenle ");
            Console.WriteLine(" 5 - değer sil ");
            Console.WriteLine(" 6 - uygulama çıkış ");

            do
            {
                Console.Write(" değer seçiniz : ");
                secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        int girilecekdeger;
                        Console.Write("kaç tane değer girilsin :");
                        girilecekdeger = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= girilecekdeger; i++)
                        {
                            Console.Write("eklenecek değer girin :");
                            string deger = Console.ReadLine();
                            değerler.Add(deger); // eklenen değerleri degerler listesine aldık
                        }
                        break;
                    case "2":
                        foreach (var item in değerler)
                        {
                            Console.WriteLine("değerler :" + item);
                        }
                        break;
                    case "3":
                        Console.WriteLine(" Aramak istediğiniz değeri girin :");
                        int aranacakdeger = Convert.ToInt32(Console.ReadLine());
                        bool kontrol = değerler.Contains(aranacakdeger.ToString()); // contains listede aranan değer var mı bunu kontrol eder

                        if (kontrol)
                        {
                            Console.WriteLine("Aradığınız değer bulundu ");

                        }
                        else
                        {
                            Console.WriteLine("Aradığınız değer bulunamadı ");
                        }
                        break;
                    case "4":
                        Console.Write("güncellemek istediğiniz  değer :");
                        string guncelenecekdeger = Console.ReadLine();

                        Console.Write("güncellenecek yeni değer :");
                        string yenideger = Console.ReadLine();

                        if (değerler.Contains(guncelenecekdeger))
                        {
                            int indexdegeri = değerler.IndexOf(guncelenecekdeger); // indexof güncellenecek değerin indeksini bulur
                            değerler[indexdegeri] = yenideger;
                            Console.WriteLine("değer 0} değeri ile güncellendi {", değerler[indexdegeri]);
                        }
                        else
                        {
                            Console.WriteLine("hatalı girim ");
                        }

                        break;
                    case "5":
                        Console.Write("silmek istediğiniz değer :");
                        string silinecekdeger = Console.ReadLine();

                        if (değerler.Contains(silinecekdeger))
                        {
                            değerler.Remove(silinecekdeger); // remove deger silmeye yarar
                            Console.WriteLine("{0} değeri silindi", silinecekdeger);
                        }
                        else
                        {
                            Console.WriteLine("hatalı girim");
                        }
                        break;
                    case "6":
                        Console.WriteLine("geçerli durum girilmedi ");
                        break;
                }
            } while (secim != "6");

            Console.ReadLine();
        }
    }
}
