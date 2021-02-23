using System;

namespace Lesson3AdditionalTask_palindrome_
{
    class Program
    {

        static void Main()
        {
            //Алгоритм может быть неоптимальным.Придумал сам.С огромной долей вероятности создал велосипед.
            //Первый способ.
            Console.WriteLine("Введите строку :");
            string @string = Console.ReadLine();

            char[] charArray = @string.ToCharArray();
            char[] palindrome = new char[charArray.Length];

            char buffchar;
            char buffchar2;

            for (int i = 0; i < charArray.Length; i++)
            {
                palindrome[i] = charArray[i];
            }

            int lastchar = palindrome.Length;
            for (int i = 0; i < lastchar; i++)
            {
                buffchar = palindrome[i];
                buffchar2 = palindrome[lastchar - 1];
                palindrome[lastchar - 1] = buffchar;
                palindrome[i] = buffchar2;
                lastchar--;
            }

            int a = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (palindrome[i] != charArray[i])
                {
                    continue;
                }
                a++;
            }
            if (a == palindrome.Length)
                Console.WriteLine("Является палиндромом");
            else Console.WriteLine("Не является палиндромом");

            //Второй способ
            Console.WriteLine("Введите строку :");
            string _string = Console.ReadLine();

            char[] charArray2 = _string.ToCharArray();
            char[] charArray3 = new char[charArray2.Length];

            for (int i = 0; i < charArray2.Length; i++)
            {
                charArray3[i] = charArray2[i];
            }
            Array.Reverse(charArray3);
            int b = 0;
            for (int i = 0; i < charArray3.Length; i++)
            {
                if (charArray2[i] != charArray3[i])
                {
                    continue;
                }
                b++;
            }
            if (b == palindrome.Length)
                Console.WriteLine("Является палиндромом");
            else Console.WriteLine("Не является палиндромом");
        }
    }

}
