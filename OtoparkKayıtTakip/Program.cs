using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_9._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string car, motorcycle, van, truck;
            double saat;
            bool kontrol = true;
            bool kontrol2 = true;


            Console.WriteLine("Lütfen aşağıda belirtilen seçeneklerden aracınızı seçiniz.\n\nOtomobil için 1'e basınız.\nMotosiklet için 2'ye basınız.\nMinibüs için 3'e basınız.\nKamyon ( ve diğer ticari araçlar) için 4'e basınız.");

            int giris = int.Parse(Console.ReadLine());

            if (giris == 1)
            {

                while (kontrol)
                {

                    Console.WriteLine("Araç park alanında ne kadar kaldı?");
                    string inputsaat = Console.ReadLine();
                    kontrol2 = double.TryParse(inputsaat, out saat);
                    if (kontrol2 == false)
                    {

                        Console.WriteLine("Lütfen geçerli bir sayı yazınız!");
                    }
                    else
                    {

                        if (saat > 0 && saat <= 2)
                        {
                            Console.WriteLine("Ödenmesi gereken tutar : 5 TL");
                        }
                        else if (saat > 2 && saat <= 6)
                        {
                            Console.WriteLine("Ödenmesi gereken tutar : 10 TL");
                        }

                        else if (saat > 6 && saat <= 12)
                        {
                            Console.WriteLine("Ödenmesi gereken tutar : 20 TL");
                        }
                        else if (saat > 12 && saat <= 24)
                        {
                            Console.WriteLine("Ödenmesi gereken tutar : 30 TL");
                        }
                        break;
                    }
                }
            }
            if (giris == 2)
            {
                while (kontrol)
                {

                    Console.WriteLine("Araç park alanında ne kadar kaldı?");
                    string inputsaat = Console.ReadLine();
                    kontrol2 = double.TryParse(inputsaat, out saat);
                    if (kontrol2 == false)
                    {
                        Console.WriteLine("Lütfen geçerli bir sayı yazınız!");
                    }
                    else
                    {

                        if (saat > 0 && saat <= 2)
                        {
                            Console.WriteLine("Ödenmesi gereken tutar : Ücretsiz");
                        }
                        else if (saat > 2 && saat <= 6)
                        {
                            Console.WriteLine("Ödenmesi gereken tutar : 3 TL");
                        }

                        else if (saat > 6 && saat <= 12)
                        {
                            Console.WriteLine("Ödenmesi gereken tutar : 6 TL");
                        }
                        else if (saat > 12 && saat <= 24)
                        {
                            Console.WriteLine("Ödenmesi gereken tutar : 12 TL");
                        }
                        break;
                    }
                }
            }

            if (giris == 3)
            {
                while (kontrol)
                {

                    Console.WriteLine("Araç park alanında ne kadar kaldı?");
                    string inputsaat = Console.ReadLine();
                    kontrol2 = double.TryParse(inputsaat, out saat);
                    if (kontrol2 == false)
                    {
                        Console.WriteLine("Lütfen geçerli bir sayı yazınız!");
                    }
                    else
                    {


                        if (saat > 0 && saat <= 2)
                        {
                            Console.WriteLine("Ödenmesi gereken tutar : 8 TL");
                        }
                        else if (saat > 2 && saat <= 6)
                        {
                            Console.WriteLine("Ödenmesi gereken tutar : 16 TL");
                        }

                        else if (saat > 6 && saat <= 12)
                        {
                            Console.WriteLine("Ödenmesi gereken tutar : 32 TL");
                        }
                        else if (saat > 12 && saat <= 24)
                        {
                            Console.WriteLine("Ödenmesi gereken tutar : 45 TL");
                        }
                        break;
                    }
                }
            }
            if (giris == 4)
            {
                while (kontrol)
                {

                    Console.WriteLine("Araç park alanında ne kadar kaldı?");
                    string inputsaat = Console.ReadLine();
                    kontrol2 = double.TryParse(inputsaat, out saat);
                    if (kontrol2 == false)
                    {
                        Console.WriteLine("Lütfen geçerli bir sayı yazınız!");
                    }
                    else
                    {

                        if (saat > 0 && saat <= 2)
                        {
                            Console.WriteLine("Ödenmesi gereken tutar : 15 TL");
                        }
                        else if (saat > 2 && saat <= 6)
                        {
                            Console.WriteLine("Ödenmesi gereken tutar : 30 TL");
                        }

                        else if (saat > 6 && saat <= 12)
                        {
                            Console.WriteLine("Ödenmesi gereken tutar : 60 TL");
                        }
                        else if (saat > 12 && saat <= 24)
                        {
                            Console.WriteLine("Ödenmesi gereken tutar : 100TL");
                        }
                        break;
                    }
                }
            }
        }
    }
}
