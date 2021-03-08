using System;

namespace Lesson6Task2
{
    class Program
    {
        static void Main()
        {
            MyString myString = new MyString('h','e','l','l','o') ;
            MyString myString1 = new MyString('w', 'o', 'r', 'l', 'd');
            MyString my = myString + myString1;
            Console.WriteLine(my.ShowMyString());
            Console.WriteLine(my.Length);
            Console.WriteLine(my.Contains('w'));
            Console.WriteLine(my.Contains('W'));
            Console.WriteLine(my.IndexOf('r'));
            Console.WriteLine(my.IndexOf('b'));
            my += '!';
            Console.WriteLine(my.ShowMyString());
            MyString oneMoreString = new MyString();
            oneMoreString += 'L';
            Console.WriteLine(oneMoreString.ShowMyString());
        }
    }
}
