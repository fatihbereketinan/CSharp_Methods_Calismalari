using System;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                hesapMakinesi();
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    toplamaİslemi(degeralma1(), degeralma2());
                }
                else if (secim == 2)
                {
                    cikarmaİslemi(degeralma1(), degeralma2());
                }
                else if (secim == 3)
                {
                    carpmaİslemi(degeralma1(), degeralma2());
                }
                else if (secim == 4)
                {
                    bolmeİslemi(degeralma1(), degeralma2());
                }
                else if (secim == 5)
                {
                    modalmaİslemi(degeralma1(), degeralma2());
                }
                else if (secim == 6)
                {
                    karesiİslemi(degeralma1());
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız!!!");
                }
                Console.WriteLine("*****************************");
            }
        }

        static void hesapMakinesi() //Paremetresiz ve geriye değer döndürmeyen tip metot.
        {
            Console.WriteLine("Hangi işlemi yapmak istersiniz: ");
            Console.WriteLine("1-Toplama islemi");
            Console.WriteLine("2-Çıkarma islemi");
            Console.WriteLine("3-Çarpma islemi");
            Console.WriteLine("4-Bölme islemi");
            Console.WriteLine("5-Mod Alma islemi");
            Console.WriteLine("6-Karesini alma islemi");
        }
        static void toplamaİslemi(double sayi1, double sayi2) //Paremetreli ve geriye değer dönürmeyen tip metot.
        {
            double topla = sayi1 + sayi2;
            Console.WriteLine("Sayilarin toplami: " + topla);
        }
        static void cikarmaİslemi(double sayi1, double sayi2)
        {
            double cikar = sayi1 - sayi2;
            Console.WriteLine("Çıkarma İşlemi Sonucu: " + cikar);
        }
        static void carpmaİslemi(double sayi1, double sayi2)
        {
            double carp = sayi1 * sayi2;
            Console.WriteLine("Çarpma İşlemi Sonucu: " + carp);
        }
        static void bolmeİslemi(double sayi1, double sayi2)
        {
            double bol = sayi1 / sayi2;
            Console.WriteLine("Bölme İşlemi Sonucu: " + bol);
        }
        static void modalmaİslemi(double sayi1, double sayi2)
        {
            double modal = sayi1 % sayi2;
            Console.WriteLine("Mod alma İşlemi Sonucu: " + modal);
        }
        static void karesiİslemi(double sayi1)
        {
            double karesi = sayi1 * sayi1;
            Console.WriteLine("Karesi İşlemi Sonucu: " + karesi);
        }
        static double degeralma1() //Paremetreli ve geriye değer döndüren tip metot.
        {
            Console.Write("Lütfen bir sayi giriniz: ");
            double deger1 = Convert.ToDouble(Console.ReadLine());
            return deger1;

        }
        static double degeralma2()
        {
            Console.Write("Lütfen bir sayi giriniz: ");
            double deger2 = Convert.ToDouble(Console.ReadLine());
            return deger2;

        }
    }
}
