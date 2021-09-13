using System;

namespace HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girilen sayı: " + a);
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata: " + e.Message.ToString());
                
            }

            try
            {
                //int b = int.Parse(null);
                int b = int.Parse("test");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(e);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Yanlış değer girdiniz.");
                Console.WriteLine(e);
            }
        }
    }
}
