using System;

namespace Lesson4Task1_PrimeNumbers_
{
    class Program
    {
        static bool IsPrime(int iter) //Метод проверяющий число на простоту
        {
            bool isPrime = true;
            for (int i = 2; i <= iter/2; i++)
            {
                if (iter % i == 0)
                {
                    isPrime = false;
                    break;
                }
                else continue;
            }
            return isPrime;
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
                    Console.Write(IsPrime(i) ?$"{i} - простое число\n" :"");
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
                    Console.Write(IsPrime(i) ?$"{i} - простое число\n":"");
                }
            }
            else Console.WriteLine("Введено не число или число меньше 0");
            //Закончилась часть программы через while
            #endregion
            
        }
    }
}
