using System;

namespace MantıksalDeğişkenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mantıksal Veri Tipi(bool)
            bool deger = true;

            double piyasaDun = 115000.6;
            double piyasaBugun = 116000;
            bool sonuc = piyasaBugun > piyasaDun; // True veya false döner.

            string mesajArtış = "Artış oku"; // Bir değişkene tanımlarsak tek bir yerden değiştirdiğimizde bütün kullanılan yerlerde değişmiş olur.
            string mesajAzalış = "Azalış oku";
            string mesajAyni = "Sabit oku";

            if (piyasaBugun > piyasaDun) // true dönersebu bloga girer.
            {
                Console.WriteLine(mesajArtış);
            }
            else if (piyasaBugun == piyasaDun) // true dönerse bu bloga girer.
            {
                Console.WriteLine(mesajAyni);
            }
            else // ilk bloglara girmez ise bu bloga girer.
            {
                Console.WriteLine(mesajAzalış);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
