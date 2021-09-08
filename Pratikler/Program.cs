using System;

namespace Pratikler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İlk c# pratiğim");

            Console.WriteLine("Bir ad giriniz: ");
            string name = Console.ReadLine();

            Console.WriteLine("Bir soyad giriniz: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Ad-soyad: " + name + " " + surname );

        }
    }
}
