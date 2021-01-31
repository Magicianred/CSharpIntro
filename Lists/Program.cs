using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] sehirler = new string[] { "Ankara", "İstanbul", "İzmir" };
            Console.WriteLine(sehirler.Length);
            sehirler = new string[4]; // new anahtar kelimesini kullandığımız zaman yeni bir dizi oluşturduğumzu için bursayı 3 indexli suıraya ekler ve diğer değerler uçar.
            sehirler[3] = "Bursa";
            foreach (var item in sehirler)
            {
                Console.WriteLine(item);
            }


            List<string> sehirler2 = new List<string>() { "Ankara", "İstanbul", "İzmir" };
            Console.WriteLine(sehirler2.Count);
            sehirler2.Add("Bursa");

            foreach (var item in sehirler2)
            {
                Console.WriteLine(item);
            }

            sehirler2.Add("Adana");
            sehirler2.Remove("İzmir");
            bool sonuc = sehirler2.Contains("İstanbul");

            

        }
    }
}
