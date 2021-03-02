using System;
using System.Text.RegularExpressions;

namespace Lesson5Task2_WithRegex_
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку :");
            string @string = Console.ReadLine();
            string target = "А";
            Regex regex = new Regex(@"а");
            Regex regex1 = new Regex(@"[а,и,е,у,я,э,ю,ы,о]");
            string result = regex.Replace(@string, target);
            MatchCollection matches = regex1.Matches(@string);
            if (matches.Count > 0)
            {
                Console.WriteLine($"Количество гласных в предложении : {matches.Count}");
                Console.WriteLine($"Предложение в котором символ \'а\' переведен в верхний регистр :\n{result}");
            }
            else
            {
                Console.WriteLine("Гласных нет");
            }
        }
    }
}
