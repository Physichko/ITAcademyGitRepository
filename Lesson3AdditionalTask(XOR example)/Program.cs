using System;

namespace Lesson3AdditionalTask_XOR_example_
{
    class Program
    {
        static char[] Encryptor(char[] chArr, short secretChar)//Шифратор
        {
            for (int i = 0; i < chArr.Length; i++)
            {
                if (chArr[i] == 'A')
                {
                    chArr[i] = (char)(chArr[i] ^ secretChar);

                }

            }
            return chArr;
        }
        static char[] Decriptor(char[] chArr, short secretChar)//Дешифратор
        {
            for (int i = 0; i < chArr.Length; i++)
            {
                if ((char)(chArr[i] ^ secretChar) == 'A')
                {
                    chArr[i] = 'A';
                }
            }
            return chArr;
        }
        static void Main()
        {
            Console.WriteLine("Введите сообщение с символом A(английская)(например ABRAKADABRA):");

            string str = Console.ReadLine();
            char[] chArr = str.ToCharArray();
            chArr = Encryptor(chArr, 0x0088);
            Console.WriteLine(chArr);
            chArr = Decriptor(chArr, 0x0088);
            Console.WriteLine(chArr);

        }
    }
}
