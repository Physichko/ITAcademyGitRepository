using System;

namespace Lesson4Task1_PrimeNumbers_
{
    class Program
    {
        static bool IsPrime(int iter) //Метод проверяющий число на простоту
        {
            for (int i = 2; i <= iter/2; i++)
            {
                if (iter % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main()
        {
            #region Часть через for
            //Часть программы через for
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Сделано при помощи цикла for :");
            Console.WriteLine(new string('-',40));

            int value;
            bool intParse;

            Console.WriteLine("Введите целое число, которое больше 0 :");
            intParse = int.TryParse(Console.ReadLine(), out value);

            if (intParse && value > 0)
            {
                for (int i = 1; i <= value; i++)
                {
                    Console.Write(IsPrime(i) ? new string($"{i} - простое число\n") : new string(""));
                }
            }
            else Console.WriteLine("Введено не число или число меньше 0");
            //Закончилась часть программы через for
            #endregion
            #region Часть через while
            //Часть программы через while
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Сделано при помощи цикла while :");
            Console.WriteLine(new string('-', 40));

            int value1;
            bool intParse1;

            Console.WriteLine("Введите целое число, которое больше 0 :");
            intParse1 = int.TryParse(Console.ReadLine(), out value1);

            if (intParse1 && value1 > 0) 
            {
                int i = 0;
                while (value1 > i)
                {
                    i++;
                    Console.Write(IsPrime(i) ? new string($"{i} - простое число\n"):new string(""));
                }
            }
            else Console.WriteLine("Введено не число или число меньше 0");
            //Закончилась часть программы через while
            #endregion
            Console.WriteLine();
            Console.WriteLine();
            // Использование цикла for и замена for на while было представлено выше.
            // Cейчас будет представлена работа с операторами break и continue
            
            int a = 0;
            while (a < 1000) 
            {
                a++;
                Console.WriteLine("значение a увеличилось до {0}",a);
                if (a < 15) 
                {
                    Console.WriteLine("a = {0} (благодаря continue (Должно быть должно быть увеличение до 15) )",a);
                    continue;
                }
                    
                for (int i = 0; i < 10; i++)
                {
                    a += 5;
                    Console.WriteLine("Значение a благодаря увеличению а на значение 5 в цикле for вырасло до значения {0} (Пока а < 100 )", a);
                    if (a > 100)
                    {
                        Console.WriteLine("a > 100 , значит при помощи break выходим из цикла for");
                        break;
                    }
                }
                Console.WriteLine("а вышло из цикла for повысив свое значение до {0}",a);
                if (a > 100)
                {
                    Console.WriteLine($"{a} > 100, значит выходим из цикла while (хотя условие while : a < 1000)");
                    break;
                }
            }
        }
    }
}
