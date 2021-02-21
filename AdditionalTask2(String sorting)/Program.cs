using System;

namespace ITAcademyGitRepository
{
    class Program
    {
        static void SubStringsShuffle(string[] subStringsArray)
        {
            string bufferElement;//Буферный элемент для промежуточного swap'a элементов массива

            //Реализация алгоритма SelectionSort
            for (int i = 0; i < subStringsArray.Length - 1; i++) // Length-1 потому что последний и так к последней итерации станет старшим элементов в массиве
            {
                for (int j = i + 1; j < subStringsArray.Length; j++)//i+1 чтобы не сравнивать каждый раз iый элемент с самим собой,а брать следующий от i элемент
                {
                    if (subStringsArray[i].Length > subStringsArray[j].Length)
                    {
                        bufferElement = subStringsArray[i];
                        subStringsArray[i] = subStringsArray[j];
                        subStringsArray[j] = bufferElement;
                    }
                }
            }
        }

        static void PushNewStringToConsole(string[] subStringsArray)
        {
            string finalString = "";//Oбъединим массив подстрок в строку
            for (int i = 0; i < subStringsArray.Length; i++)//Производим процесс конкатенации окончательной сроки для вывода с каждым элементом массива подстрок
            {
                finalString += (subStringsArray[i] + " ");
            }
            Console.WriteLine(finalString);//Выводим финальную строку
        }

        static void Main()
        {
            Console.WriteLine("Введите строку :");
            string @string = Console.ReadLine();//Записываем считанную с консоли строку и записываем ее в переменную строкового типа @string

            string[] subStrings = @string.Split(" ");//Разбиение массива строк на подстроки с разделителем в виде пробела
            SubStringsShuffle(subStrings);//Перемешиваем массив подстрок по длине подстрок от меньшего к большему

            PushNewStringToConsole(subStrings);//Объединяем массив подстрок в строку и выводим ее на экран

        }
    }
}
