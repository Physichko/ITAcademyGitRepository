using System;

namespace Lesson5Task1_Arrays_
{
    class Program
    {
        static void Main()
        {
            MethodsAndProperties methodsAndProperties = new MethodsAndProperties(new Random().Next(3, 10), new Random().Next(3, 10), new Random().Next(3, 10));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(new string('-', 120));
            Console.WriteLine("Часть 1. Эта часть программы посвящена поиску последнего отрицательного значения в массиве : ");
            Console.WriteLine(new string('-', 120));
            int[] intArray = new int[8];
            methodsAndProperties.ToFillArrayWithRandomNumbers(intArray);
            Console.WriteLine(methodsAndProperties.ShowArray(intArray));
            Console.WriteLine(methodsAndProperties.ToFindLastIndexOfNegativeNumberInArray(intArray));
            Console.WriteLine(new string('-', 120));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('-', 120));
            Console.WriteLine("Часть 2. Эта часть про обнуление оставшихся символов в строке двумерного массива после нахождения старшего в строке : ");
            Console.WriteLine(new string('-', 120));
            int[,] twoDimentsionalArray = new int[methodsAndProperties.HeightForTwoDimensional, methodsAndProperties.WidthForTwoDimensional];
            methodsAndProperties.ToFillArrayWithRandomNumbers(twoDimentsionalArray);
            Console.WriteLine("Изначальный массив :");
            Console.WriteLine(new string('-', 120));
            Console.WriteLine(methodsAndProperties.ShowArray(twoDimentsionalArray));
            methodsAndProperties.FillWithZeroAfterMaxValue(twoDimentsionalArray);
            Console.WriteLine(new string('-', 120));
            Console.WriteLine("Двумерный массив после нахождения старших элементов в строках и удаления всех элементов идущих после старших :");
            Console.WriteLine(new string('-', 120));
            Console.WriteLine(methodsAndProperties.ShowArray(twoDimentsionalArray));
            Console.WriteLine(new string('-', 120));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(new string('-', 120));
            Console.WriteLine("Часть 3. Эта часть про обнуление оставшихся символов в строке зубчатого массива после нахождения старшего в строке : ");
            Console.WriteLine(new string('-', 120));
            int[][] jaggedArray = new int[methodsAndProperties.AmountOfSubArrays][];
            methodsAndProperties.ToFillArrayWithRandomNumbers(jaggedArray);
            Console.WriteLine("Изначальный массив :");
            Console.WriteLine(new string('-', 120));
            Console.WriteLine(methodsAndProperties.ShowArray(jaggedArray));
            methodsAndProperties.FillWithZeroAfterMaxValue(jaggedArray);
            Console.WriteLine(new string('-', 120));
            Console.WriteLine("Зубчатый массив после нахождения старших элементов в строках и удаления всех элементов идущих после старших :");
            Console.WriteLine(new string('-', 120));
            Console.WriteLine(methodsAndProperties.ShowArray(jaggedArray));
            Console.WriteLine(new string('-', 120));
            Console.ResetColor();
        }
    }
}
