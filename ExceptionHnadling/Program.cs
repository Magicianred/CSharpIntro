using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematik matematik = new Matematik();
            Console.WriteLine(matematik.Bol(20,0));

        }
    }

    class Matematik
    {
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public decimal Bol(decimal sayi1, decimal sayi2)
        {
            try
            {
                return sayi1 / sayi2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Bir hata oluştu.");
                throw new DivideByZeroException("Payda sıfır olamaz..");
            }
            catch (DllNotFoundException)
            {
                Console.WriteLine("Bambaşka bir hata oluştu.");
                throw new DllNotFoundException();
            }
            catch (Exception exeption)
            {
                Console.WriteLine("Hiç ön görmediğim bir hata oluştu.");
                Console.WriteLine(exeption.InnerException);
                throw;
            }
            finally
            {
                Console.WriteLine("Finally çalıştı");
            }
        }
    }

}
