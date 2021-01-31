using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] krediler = new string[7];
            krediler[0] = "kredi 1";
            krediler[1] = "kredi 2";
            krediler[2] = "kredi 3";
            krediler[3] = "kredi 4";
            krediler[4] = "kredi 5";
            krediler[5] = "kredi 6";
            krediler[6] = "kredi 7";

            string sonuc;

            foreach (var item in krediler)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(krediler[0]);

            int[] sayilar = new int[3];

            sayilar[0] = 3;
            sayilar[1] = 2;
            sayilar[2] = 7;

            Console.WriteLine(sayilar[2] + " Enbüyük sayi");
            Console.WriteLine(sayilar[1] + " En küçük sayi");
            Console.WriteLine(sayilar[0] + " Ortanca sayi");
        }
    }
}
