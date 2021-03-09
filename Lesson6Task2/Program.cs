using System;

namespace Lesson6Task2
{
    class Program
    {
        static void Main()
        {
            MyString myString1 = new MyString("ЛяляТополя");
            MyString myString2 = new MyString('h', 'e', 'l', 'l', 'o');
            MyString myString3 = new MyString();

            myString1 += myString2;
            myString2 += '!';
            myString3 += "papaShlyapa";

            Console.WriteLine($"Содердит ли myString1 символ 'o' : { myString1.Contains('o')}");
            Console.WriteLine($"Содердит ли myString1 массив символов \"hell\" : { myString1.Contains("hell".ToCharArray())}");
            Console.WriteLine($"Индекс символа 'h' в myString1 : { myString1.IndexOf('h')}");
            Console.WriteLine(myString1.ShowMyString());
            Console.WriteLine(myString2.ShowMyString());
            Console.WriteLine(myString3.ShowMyString());
            Console.WriteLine(myString2[2]);
        }
    }
}
