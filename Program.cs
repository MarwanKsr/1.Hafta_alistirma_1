using System;

namespace alistirma_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi, soyad;
            Console.Write("Adiniz: ");
            adi = Console.ReadLine();
            Console.Write("Soyadiniz: ");
            soyad = Console.ReadLine();
            Console.WriteLine("Merhaba " + adi + " " + soyad);
        }
    }
}