using System;

namespace AdditionalTask1_QSort_
{
    class Program
    {
        static void FillArrayWithRandomValues(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 11);
                Console.Write(array[i] + " ");
            }
        }

        static void QuickSortAlgorithm(int[] array, int firstElementPosition, int lastElementPosition)
        {
            //Реализация алгоритма быстрой сортировки (QuickSort)
            int bufferElement;//буферный элемент для промежуточного swap'a элементов массива
            double baseElement = array[(lastElementPosition - firstElementPosition) / 2 + firstElementPosition];//Поиск опорного элемента(центрального элемента)
            int i = firstElementPosition;// крайний левый индекс
            int j = lastElementPosition;// крайний правый индекс

            while (i <= j) // пока крайний левый индекс меньше либо равен крйнему правому индексу ...
            {
                while (array[i] < baseElement) // пока элемент с крайним левым индексом меньше центрального элемента   - крайний левый индекс инкрементируется
                    ++i;
                while (array[j] > baseElement) // пока элемент с крайним правым индексом больше центрального элемента  - крайний правый индекс декрементируется
                    --j;
                if (i <= j)//если крайний левый индекс меньше либо равен крайнему правому индексу , то значения элементов массива крайнего левого элемента и крайнего правого меняются местами
                {
                    bufferElement = array[i];
                    array[i] = array[j];
                    array[j] = bufferElement;
                    ++i;
                    --j;
                }
            }
            if (j > firstElementPosition) // если j , больше крайнего левого индекса , то рекурсивно вызываем метод и задаем новый крайний левый индекс с предыдущим смещением влево
            {
                QuickSortAlgorithm(array, firstElementPosition, j);
            }

            if (i < lastElementPosition)// если i , больше крайнего правого индекса , то рекурсивно вызываем метод и задаем новый крайний левый индекс с предыдущим смещением вправо
            {
                QuickSortAlgorithm(array, i, lastElementPosition);
            }

        }
        static void PushArrayToConsole(int[] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static void Main()
        {
            int[] myArray = new int[15];//создаем экземпляр массива
            FillArrayWithRandomValues(myArray);//заполняем массив рандомными значениями
            QuickSortAlgorithm(myArray, 0, myArray.Length - 1);//сортируем массив при помощи вызова метода QuickSortAlgorithm
            PushArrayToConsole(myArray);//выводим отсортированнный массив в консоль при помощи метода PushArrayToConsole
        }
    }
}
