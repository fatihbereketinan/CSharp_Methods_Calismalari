using System;

namespace BoyKiloEndeksi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhabalar, Boy-Kilo endeksi uygulamasına hoş geldiniz..");
            while (true)
            {
                double sonuc = endeksHesap(boy(), kilo());

                if (sonuc <= 18)
                {
                    Console.WriteLine("Zayıf");
                }
                else if (sonuc > 18 && sonuc < 25)
                {
                    Console.WriteLine("Normal");
                }
                else
                {
                    Console.WriteLine("Obez");
                }
            }
        }
        static double boy()
        {
            Console.Write("Lütfen boyunuzu giriniz: ");
            double boyDegeri = Convert.ToDouble(Console.ReadLine());
            return boyDegeri;
        }
        static double kilo()
        {
            Console.Write("Lütfen kilonuzu giriniz: ");
            double kiloDegeri = Convert.ToDouble(Console.ReadLine());
            return kiloDegeri;
        }
        static double endeksHesap(double boy, double kilo)
        {
            double endekshesabi = kilo / (boy * boy);
            return endekshesabi;
        }
    }
}
