using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool durum = true;
            while (durum)
            {

                Console.WriteLine("Çözümlenecek sayıyı giriniz.");
                int sayı;
                string giris = Console.ReadLine();
                bool kontrol = int.TryParse(giris, out sayı);

                if (giris == "exit")
                {

                    break;
                }
                else
                {
                    if (kontrol)
                    {

                        int a = 1;
                        int b;
                        while (sayı / Convert.ToInt32(Math.Pow(10, (a - 1))) != 0)
                        {
                            b = Convert.ToInt16(sayı % Math.Pow(10, a)) / Convert.ToInt32(Math.Pow(10, (a - 1)));
                            Console.WriteLine("{0} x {1} = {2}", b, Math.Pow(10, (a - 1)), b * Math.Pow(10, (a - 1)));
                            a++;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Lütfen sayısal bir giriş yapınız.");

                    }
                }

            }
            Console.Read();

        }
    }
}
