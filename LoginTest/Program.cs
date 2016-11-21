using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_9._6
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Sisteme Hoşgeldiniz!\nLütfen kullanıcı adınızı ve parolanızı giriniz.\n\nKullanıcı Adı :");
            string username = Console.ReadLine();
            Console.Write("Şifre Giriniz :");
            string password = "";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
            }
            while (key.Key != ConsoleKey.Enter);
            Console.WriteLine();
            Console.WriteLine("\nHoşgeldin " + username + " Başarıyla giriş yaptın.");
            Console.WriteLine("-----------------------");
            Console.WriteLine("\nPAROLA TEST:" + password);
        }
    }
}
