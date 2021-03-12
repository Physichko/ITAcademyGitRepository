using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson7Task1
{
    class Program
    {
        static void Main()
        {
            List<int> listOfNumbers = new List<int>() { 23, 7, 324, 46,255,32 , 6 ,4, 8, 15 ,16,23,42 };
            var result = listOfNumbers.Select(n => n.ToString()).Select(n => n.Last()).ToList();
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
