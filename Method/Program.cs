using System;
using System.Linq;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematik matematik = new Matematik();
            int sonuc1 = matematik.Topla(3, 5);
            int sonuc2 = matematik.Topla(3, 65, 65);
            int sonuc3 = matematik.Topla(b: 65, a: 10);
            int sonuc4 = matematik.ToplaParams(1, 2, 3, 4, 5, 6, 9, 8, 54, 45);
            int sonuc5 = matematik.ToplaParams(new int[] { 2, 6, 8, 9, 4, });

            Console.WriteLine(sonuc1);
            Console.WriteLine(sonuc2);
            Console.WriteLine(sonuc3);
            Console.WriteLine(sonuc4);
            Console.WriteLine(sonuc5);
        }
    }

    // Overloading
    class Matematik
    {
        public int Topla(int a, int b)
        {
            return a + b;
        }

        public int Topla(int a, int b, int c)
        {
            return a + b + c;
        }

        public int ToplaParams(params int[] sayilar)
        {
            //int sonuc = 0;
            //foreach (var item in sayilar)
            //{
            //    sonuc += item;
            //}
            //return sonuc;

            return sayilar.Sum();
        }

        public int Cikar(int a, int b)
        {
            return a - b;
        }

    }
}
