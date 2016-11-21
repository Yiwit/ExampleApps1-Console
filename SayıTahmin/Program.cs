using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int puan = 1000;
            int toplam = 0;
            int tahmin = 0;
            int tahminSayisi = 0;
            Random rndm = new Random();
            int kolayZorluk = rndm.Next(1, 10);
            int ortaZorluk = rndm.Next(1, 100);
            int zorZorluk = rndm.Next(1, 1000);
           

            Console.WriteLine("Sayı Tahmin Oyununa Hoşgeldiniz!! Zorluk Seviyesi Seçmek İçin Bir Tuşa Basınız..");
            Console.ReadKey();

            Console.WriteLine("Lütfen aşağıdaki zorluk seviyelerinden birisini seçiniz :");

            Console.WriteLine("1. Kolay seviye için 1'i tuşlayın.(1-10 Arasında) \n2. Orta seviye için 2'yi tuşlayın(1-100 Arasında)\n3. Zor seviye için 3'ü tuşlayın(1-1000 Arasında)");
            int giris = int.Parse(Console.ReadLine());
            

   
            if (giris == 1)
            {
                Console.Clear();
                Console.WriteLine("1. seviyeyi seçtiniz.");
                while (tahminSayisi < kolayZorluk)
                {
                    
                    tahminSayisi++;
                    Console.WriteLine("Şimdik tahmininizi giriniz :");
                    tahmin = int.Parse(Console.ReadLine());

                    if(tahmin > 10)
                    {
                        Console.WriteLine("Lütfen 1 ile 10 arasında bir sayı giriniz..");
                    }


                    if (tahmin != kolayZorluk)
                    {
                        if ((tahminSayisi - kolayZorluk >= tahmin) || (kolayZorluk - tahminSayisi >= tahmin)) Console.WriteLine("Soğuk ");
                        else if ((tahminSayisi - kolayZorluk >= tahmin) || (kolayZorluk - tahminSayisi >= tahmin)) Console.WriteLine("Ilık");
                        else if ((tahminSayisi - kolayZorluk >= 0) || (kolayZorluk - tahminSayisi >= 0)) Console.WriteLine("Sıcak");
                    }
                    if (tahmin == kolayZorluk)
                    {
                        toplam = puan / tahminSayisi;
                        Console.WriteLine("Tebikler!! " + kolayZorluk + " doğru tahmin!\nOyunu " + tahminSayisi + " tahminde bitirdiniz! Puanınız :" + toplam);
                        break;
  
                    }
                }

            }

            if (giris == 2)
            {
                Console.Clear();
                Console.WriteLine("2. seviyeyi seçtiniz.");
                while (tahminSayisi < ortaZorluk)
                {
                    tahminSayisi++;
                    Console.WriteLine("Şimdik tahmininizi giriniz :");
                    tahmin = int.Parse(Console.ReadLine());

                    if (tahmin > 100)
                    {
                        Console.WriteLine("Lütfen 1 ile 100 arasında bir sayı giriniz..");
                    }

                    if (tahmin != ortaZorluk)
                    {
                        if ((tahminSayisi - ortaZorluk >= tahmin) || (ortaZorluk - tahminSayisi >= tahmin)) Console.WriteLine("Soğuk ");
                        else if ((tahminSayisi - ortaZorluk >= tahmin) || (ortaZorluk - tahminSayisi >= tahmin)) Console.WriteLine("Ilık");
                        else if ((tahminSayisi - ortaZorluk >= 0) || (ortaZorluk - tahminSayisi >= 0)) Console.WriteLine("Sıcak");
                    }

                    if (tahmin == ortaZorluk)
                    {
                        Console.WriteLine("Tebikler!! " + ortaZorluk + " doğru tahmin!\nOyunu " + tahminSayisi + " tahminde bitirdiniz! Puanınız :" + toplam);
                        break;
                    }
                }
            }

            if (giris == 3)
            {
                Console.Clear();
                Console.WriteLine("3. seviyeyi seçtiniz.");
                while (tahminSayisi < zorZorluk)
                {
                    tahminSayisi++;
                    Console.WriteLine("Şimdik tahmininizi giriniz :");
                    tahmin = int.Parse(Console.ReadLine());

                    if (tahmin > 1000)
                    {
                        Console.WriteLine("Lütfen 1 ile 1000 arasında bir sayı giriniz..");
                    }

                    if (tahmin != zorZorluk)
                    {
                        if ((tahminSayisi - zorZorluk >= tahmin) || (zorZorluk - tahminSayisi >= tahmin)) Console.WriteLine("Soğuk ");
                        else if ((tahminSayisi - zorZorluk >= tahmin) || (zorZorluk - tahminSayisi >= tahmin)) Console.WriteLine("Ilık");
                        else if ((tahminSayisi - zorZorluk >= 0) || (zorZorluk - tahminSayisi >= 0)) Console.WriteLine("Sıcak");
                    }


                    if (tahmin == zorZorluk)
                    {
                        Console.WriteLine("Tebikler!! " + zorZorluk + " doğru tahmin!\nOyunu " + tahminSayisi + " tahminde bitirdiniz!Puanınız :" + toplam);
                        break;
                    }
                }


            }
        }
    }


}