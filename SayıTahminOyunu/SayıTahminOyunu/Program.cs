using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayıTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            void Oyun()
            {
                Random rastgeleSayiUret = new Random();
                int uretilenSayı = rastgeleSayiUret.Next(1, 100);
                bool sayiKontrol = false;
                Console.WriteLine("1 ile 100 arasında bir sayı tuttum :) Tahmin et!");
                while (!sayiKontrol)
                {
                    
                    int tahmin = Convert.ToInt32(Console.ReadLine());

                    if (uretilenSayı > tahmin)
                    {
                        Console.WriteLine("Yukarı çık");
                    }
                    else if (uretilenSayı < tahmin)
                    {
                        Console.WriteLine("Aşağı in");
                    }
                    else
                    {
                        Console.WriteLine("Buldun ;)");
                        sayiKontrol = true;
                    }
                }
            }
            Oyun();
            Console.WriteLine("Oyun bitti :( Yeni oyun istersen E tuşuna basabilirsin.");
            string yeniOyun = Console.ReadLine();

            if(yeniOyun=="e" || yeniOyun=="E")
            {
                Oyun();
            }
        }
    }
}
