using System;

namespace Lesson3AdditionalTask_XOR_example_
{
    class Program
    {
        static void Main()
        {
            ushort secretKey = 0x0088; // Секретный ключ длиной 16 бит
            char character = 'A';
            character = (char)(character ^ secretKey);//Шифровка
            Console.WriteLine("was A ->"+character);
            character = (char)(character ^ secretKey);//Расшифровка
            Console.WriteLine("was E ->"+character);
            string STR = "ABRAKADABRA";
            char[] charr = STR.ToCharArray();
            for (int i = 0; i < charr.Length; i++)
            {
                if (charr[i] =='A')
                    charr[i] = (char)(charr[i] ^ secretKey);//Шифровка
            }
            Console.WriteLine(charr);
        }
    }
}
