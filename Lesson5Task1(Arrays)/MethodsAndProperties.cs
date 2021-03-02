using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5Task1_Arrays_
{
    class MethodsAndProperties
    {
        public int HeightForTwoDimensional { get; }
        public int WidthForTwoDimensional { get; }
        public int AmountOfSubArrays { get; }


        private Random random;

        public MethodsAndProperties(int HeightForTwoDimensional, int WidthForTwoDimensional, int AmountOfSubArrays)
        {
            this.HeightForTwoDimensional = HeightForTwoDimensional;
            this.WidthForTwoDimensional = WidthForTwoDimensional;
            this.AmountOfSubArrays = AmountOfSubArrays;
            random = new Random();
        }
        public void ToFillArrayWithRandomNumbers(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-3, 4);
            }
        }
        public void ToFillArrayWithRandomNumbers(int[,] array)
        {
            for (int i = 0; i < HeightForTwoDimensional; i++)
            {
                for (int j = 0; j < WidthForTwoDimensional; j++)
                {
                    array[i, j] = random.Next(-5, 10);
                }
            }
        }
        public void ToFillArrayWithRandomNumbers(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[random.Next(1, 10)];
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = random.Next(-5, 10);
                }
            }
        }
        public string ToFindLastIndexOfNegativeNumberInArray(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] < 0)
                {
                    int lastIndexOfNegative = Array.LastIndexOf(array, array[i]);
                    return new string($"Индекс последнего отрицательного значения внутри массива : {lastIndexOfNegative}");
                }
            }
            return new string("В массиве отсутствуют отрицательные значения");
        }
        public void FillWithZeroAfterMaxValue(int[,] array)
        {
            int max = -5;
            int indexOfMax = 0;
            for (int i = 0; i < HeightForTwoDimensional; i++)
            {
                for (int j = 0; j < WidthForTwoDimensional; j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        indexOfMax = j;
                    }
                }
                for (int j = indexOfMax; j < WidthForTwoDimensional; j++)
                {
                    if (j > indexOfMax)
                        array[i, j] = 0;
                }
                max = 0;
            }
        }
        public void FillWithZeroAfterMaxValue(int[][] array)
        {
            int max = -5;
            int indexOfMax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] > max)
                    {
                        max = array[i][j];
                        indexOfMax = j;
                    }
                }
                for (int j = indexOfMax; j < array[i].Length; j++)
                {
                    if (j > indexOfMax)
                        array[i][j] = 0;
                }
                max = 0;
            }
        }
        public string ShowArray(int[,] array)
        {
            string fullArray = "";
            for (int i = 0; i < HeightForTwoDimensional; i++)
            {
                for (int j = 0; j < WidthForTwoDimensional; j++)
                {
                    fullArray += "\t" + array[i, j];
                }
                fullArray += "\n\n";
            }
            return fullArray;
        }
        public string ShowArray(int[] array)
        {
            string fullArray = "";
            for (int i = 0; i < array.Length; i++)
            {
                fullArray += ($"Значение элемента с индексом {i} = {array[i]}\n");
            }
            return fullArray;
        }

        public string ShowArray(int[][] array)
        {
            string fullArray = "";
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    fullArray += "\t" + array[i][j];
                }
                fullArray += "\n\n";
            }
            return fullArray;
        }
    }
}
