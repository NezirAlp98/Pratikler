﻿using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 7;

            int a = y + 55;
            Console.WriteLine(a);
            int b = y / 7;
            Console.WriteLine(b);

            int c = x * 2;
            Console.WriteLine(c);

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect");
            }

            if (isSuccess || isCompleted)
            {
                Console.WriteLine("Great");
            }

            if (isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine");
            }

            int sonuc = 20 % 3;
            Console.WriteLine(sonuc);
        }
    }
}