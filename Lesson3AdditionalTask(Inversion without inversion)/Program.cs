using System;

namespace Lesson3AdditionalTask_Inversion_without_inversion_
{
    class Program
    {
        static int Invertor(int variable)
        {
            variable = variable ^ (-1);
            return variable;
        }
        static void Main()
        {
            int a = 5;
            int b = Invertor(a);
            a = ~a;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
