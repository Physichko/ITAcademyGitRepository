using System;

namespace Lesson3AdditionalTask_Xor_without_Xor_
{
    class Program
    {

        static int XorWithoutXor(int someint1, int someint2)
        {
            someint1 = ~someint1;
            int firstoperation = someint1 | someint2;
            int secondoperation = someint1 & someint2;
            int result = (~firstoperation) | (secondoperation);
            return result;

        }
        static void Main()
        {
            int someint1 = int.Parse(Console.ReadLine());
            int someint2 = int.Parse(Console.ReadLine());

            int result1 = someint1 ^ someint2;
            Console.WriteLine("С Xor");
            Console.WriteLine(result1);
            Console.WriteLine("Теперь без XOR");
            int result2 = XorWithoutXor(someint1, someint2);
            Console.WriteLine(result2);
            while (someint1 < 150)
            {
                someint1++;
                someint2++;
                result1 = someint1 ^ someint2;
                result2 = XorWithoutXor(someint1, someint2);
                Console.WriteLine("with Xor   " + result1);
                Console.WriteLine("without Xor" + result2);
            }
        }

    }
}
