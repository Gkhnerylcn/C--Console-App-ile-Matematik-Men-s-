using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52_Matematik_Menüsü_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARİTMETİK İŞLEMLER Menüsüne Hoşgeldiniz...");
            Console.WriteLine();

            Console.WriteLine("************ MENÜ *******************");
            Console.WriteLine();

            Console.WriteLine("1-Aritmetik Dört İşlem ");
            Console.WriteLine("2-Üs Alma");
            Console.WriteLine("3-Kök Alma");
            Console.WriteLine("4-Karenin Çevre Ve Alan Hesabı");
            Console.WriteLine("5-Dikdörtgenin Çevre Ve Alan Hesabı");
            Console.WriteLine("6-Eşkenar Üçgende Çevre");

            Console.WriteLine();

            Console.WriteLine("**************************************");

            int islem;

            Console.WriteLine("İşlem Yapmak İstediğiniz Alan'ın Numarasını Girin");
            islem = Convert.ToInt16(Console.ReadLine());

            if (islem == 1)
            {
                Console.WriteLine("1-Aritmetik Dört İşlem ");

                int sayi1, sayi2, toplam, fark, carpım, bolum;

                Console.WriteLine("Sayı 1 Girin");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sayı 2 Girin");
                sayi2 = Convert.ToInt32(Console.ReadLine());

                toplam = sayi1 + sayi2;
                fark = sayi1 - sayi2;
                carpım = sayi1 * sayi2;
                bolum = sayi1 / sayi2;

                Console.WriteLine("Toplam:" + toplam);
                Console.WriteLine("Fark:" + fark);
                Console.WriteLine("Çarpım:" +carpım);
                Console.WriteLine("Bölüm:" +bolum);

            }

            if (islem==2)
            {
                Console.WriteLine("2-Üs Alma");

                double sayi, us, sonuc;

                Console.WriteLine("Sayı Girin");
                sayi = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Üs Sayısını Girin");
                us = Convert.ToDouble(Console.ReadLine());

                sonuc = Math.Pow(sayi, us);
                Console.WriteLine("Üs Alma İşleminin Sonucu:" + sonuc);

            }

            if (islem==3)
            {
                Console.WriteLine("3-Kök Alma");

                double sayi, kok;

                Console.WriteLine("Sayı Giriniz");
                sayi = Convert.ToDouble(Console.ReadLine());

                kok = Math.Sqrt(sayi);

                Console.WriteLine("Kök İşlemi Sonucu:" + kok);
               

            }

            if (islem==4)
            {
                Console.WriteLine("4-Karenin Çevre Ve Alan Hesabı");

                int kenar, alan, cevre;

                Console.WriteLine("Karenin Kenarını Girin");
                kenar = Convert.ToInt32(Console.ReadLine());

                alan = kenar * kenar;
                cevre = kenar * 4;

                Console.WriteLine("Karenin Alanı:" + alan);
                Console.WriteLine("Karenin Çevresi:" + cevre);
             
            }

            if (islem==5)
            {
                Console.WriteLine("5-Dikdörtgenin Çevre Ve Alan Hesabı");

                int kısakenar, uzunkenar, alan, cevre;

                Console.WriteLine("Kısa Kenar Girin");
                kısakenar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Uzun Kenar Girin");
                uzunkenar = Convert.ToInt32(Console.ReadLine());

                alan = kısakenar * uzunkenar;
                cevre = kısakenar + kısakenar + uzunkenar + uzunkenar;

                Console.WriteLine("Dikdörtgen Alanı:" + alan);
                Console.WriteLine("Dikdörtgen Çevresi:" + cevre);




            }

            if (islem==6)
            {
                Console.WriteLine("6-Eşkenar Üçgende Çevre");

                int kenar, cevre;

                Console.WriteLine("Kenar Değeri Girin");
                kenar = Convert.ToInt32(Console.ReadLine());

                cevre = kenar * 3;

                Console.WriteLine("Eşkenar Üçgen Çevresi:" + cevre);

            }
            Console.Read();










        }
    }
}
