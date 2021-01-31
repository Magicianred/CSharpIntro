using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] krediler = new string[7];
            //krediler[0] = "kredi 1";
            //krediler[1] = "kredi 2";
            //krediler[2] = "kredi 3";
            //krediler[3] = "kredi 4";
            //krediler[4] = "kredi 5";
            //krediler[5] = "kredi 6";
            //krediler[6] = "kredi 7";

            
            //for (int i = 0; i < krediler.Length; i++)
            //{
            //    string sonuc;
            //    sonuc = krediler[i];
            //    Console.WriteLine(sonuc + " For");
            //}

            //foreach (var item in krediler)
            //{
            //    Console.WriteLine(item + " Foreach");
            //}

            //int j = 0;
            //while (j < krediler.Length)
            //{
            //    string sonuc2;
            //    sonuc2 = krediler[j];
            //    Console.WriteLine(sonuc2 + " While");
            //    j++;
            //}

            //int l = 0;
            //do
            //{
            //    Console.WriteLine("Ben her zaman çalışırım");
            //    Console.WriteLine(krediler[l]);
            //    l++;

            //} while (l < krediler.Length);

            int sayi1;
            int sayi2;
            int sonuc1 = 0;
            int sonuc2 = 0;
            sayi1 = 200;
            sayi2 = 284;

            for (int i = 1; i < sayi1; i++)
            {
                if (sayi1 % i == 0)
                {
                    sonuc1 = sonuc1 + i;
                }


            }

            for (int i = 1; i < sayi2; i++)
            {
                if (sayi2 % i == 0)
                {
                    sonuc2 = sonuc2 + i;
                }
            }

            if (sayi1 == sonuc2 && sayi2 == sonuc1)
            {
                Console.WriteLine("Sayılar arkadaş sayılardır.");
            }
            else
            {
                Console.WriteLine("Sayılar arkadaş sayılar değildir.");
            }
        }
    }
}
