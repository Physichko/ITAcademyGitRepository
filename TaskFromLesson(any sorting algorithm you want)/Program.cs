using System;

namespace TaskFromLesson_any_sorting_algorithm_you_want_
{
    class Program
    {
        static void SelectionSort(int[] array)
        {
            int buffElement;//Буферный элемент для перестановки элементов в массиве

            //Реализация алгоритма SelectionSort
            for (int i = 0; i < array.Length - 1; i++) // Length-1 потому что последний и так к последней итерации станет старшим элементов в массиве
            {
                for (int j = i + 1; j < array.Length; j++)//i+1 чтобы не сравнивать каждый раз iый элемент с самим собой,а брать следующий от i элемент
                {
                    if (array[i] > array[j])
                    {
                        buffElement = array[i];
                        array[i] = array[j];
                        array[j] = buffElement;
                    }
                }
            }
        }
        static void Main()
        {
            int[] myArray = new int[15];//Создаем массив элементов типа int c идентификатором myArray размерностью 10 элементов
            Random random = new Random();//Создаем экземпляр класса Random c идентификатором random

            for (int i = 0; i < myArray.Length; i++)// Заполняем в цикле массив myArray рандомнымы значениями и выводим в консоль 
            {
                myArray[i] = random.Next(1, 11);//random.Next(1,11) - может выдать значения от 1 до 10 , число 11 никогда не появится(Дополнительно проверил на первом занятии.Если взять random.Next(10,11),то результатом всегда будет 10.)
                Console.Write(myArray[i] + "  ");//Вывод заполненного элемента массива в строку
            }

            Console.WriteLine();// Пустая строка в консоли,чтобы оттенить заполненный массив

            SelectionSort(myArray);// Вызов метода , который реализует SelectionSort алгоритм

            for (int i = 0; i < myArray.Length; i++)//Вывод отсортированного массива
            {
                Console.Write(myArray[i] + "  ");
            }
        }
    }
}
