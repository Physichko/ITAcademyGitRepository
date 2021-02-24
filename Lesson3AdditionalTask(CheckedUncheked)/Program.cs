using System;

namespace Lesson3AdditionalTask_CheckedUncheked_
{
    class Program
    {
        static void Main()
        {
            short a = 0;
            int b = 0;
            for (int i = 0; i < 10; i++)
            {
                a += 10000;
                b += 10000;
                if (a > short.MaxValue)
                {
                    Console.WriteLine("Возникло переполнение");//Никогда не выведется, потому что полученный результат всегда будет обрезаться до 2ух быйтового числа
                }
            }
            Console.WriteLine(a);//Ахинея,потому что переполнен
            Console.WriteLine(b);//Всё работает как надо
            // В этом случае checked бы не помешал в ситуации с short и при помощи checked при компиляции выявилось бы переполнение short и программист бы задумался о смене типа данных
        }
    }
}
