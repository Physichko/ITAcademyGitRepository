﻿using System;

namespace Lesson3AdditionalTask_XOR_example_
{
    class Program
    {
        static void Main()
        {
            ushort secretKey = 0x0088; // Секретный ключ длиной 16 бит
            char character = 'A';
            character = (char)(character ^ secretKey);//Шифровка
            Console.WriteLine(character);
            character = (char)(character ^ secretKey);//Расшифровка
            Console.WriteLine(character);
        }
    }
}