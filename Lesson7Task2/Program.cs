using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson7Task2
{
    class Program
    {
        static void Main()
        {
            List<int> listOfNumbers = new List<int>() { 1, 2, 1, 4, 2, 5, 6, 3, 3, 1 ,2,1,5,7,1,2,3};
            var checkCount = listOfNumbers.OrderBy(n =>n).GroupBy(n => n).Select(n => new { num = n, count = n.Count()}).Select(n => n.count);
            var result = listOfNumbers.OrderBy(n => n).Distinct().Select(n => $"{n} Встречается {checkCount.ElementAt(n-1)} раза").ToList();
            Console.WriteLine(string.Join("\n",result));
        }
    }
}
