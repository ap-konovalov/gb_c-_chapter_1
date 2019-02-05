using System;
using System.Collections;

namespace Lesson4
{
    class TwoDimensionalArray
    {
        private static Random rndnumb = new Random();

        int[,] Array;

        /// <summary>
        /// Создает двумерный массив и заполняет его цифрами
        /// </summary>
        /// <param name="a">Количество строк</param>
        /// <param name="b">Количество столбцов</param>
        public TwoDimensionalArray(int a, int b)
        {
            Array = new int[a, b];

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Array[i, j] = rndnumb.Next(0, 90);
                }
            }
        }

        /// <summary>
        /// Минимальный элемент массива
        /// </summary>
        public int Min
        {
            get
            {
                int min = Array[0, 0];
                foreach (var number in Array)
                {
                    if (number < min)
                    {
                        min = number;
                    }
                }

                return min;
            }
        }

        /// <summary>
        /// Максимальный элемент массива
        /// </summary>
        public int Max
        {
            get
            {
                int max = Array[0, 0];
                foreach (var number in Array)
                {
                    Console.WriteLine(number);
                    if (number > max)
                    {
                        max = number;
                    }
                }

                return max;
            }
        }

        public void SumOfElem()
        {
            int sum = 0;

            foreach (var number in Array)
            {
                sum += number;
            }

            Console.WriteLine($"Сумма элементов массива = {sum}");
        }

        /// <summary>
        /// Выводит сумму элементов двумерного числового  массива
        /// </summary>
        /// <param name="min">Минимальный элемент от которого считается сумма</param>
        /// <returns>Сумма элементов массива</returns>
        ///
        public void SumOfElem(int min)
        {
            int sum = 0;

            foreach (var number in Array)
            {
                if (number > min)
                {
                    sum += number;
                }
            }

            Console.WriteLine($"Сумма элементов массива больше {min} = {sum} ");
        }


       /// <summary>
       /// Вернет индекс максимального элемента массива
       /// </summary>
       /// <param name="maxI">Размерность массива 0</param>
       /// <param name="maxJ">Размерность массива 1</param>
        public void MaxElemNumb(ref int maxI, ref int maxJ)
        {
            int max = Array[0, 0];

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (Array[i, j] > max )
                    {
                        max = Array[i, j];
                        maxI = i;
                        maxJ = j;
                    }
                }
            }
        }
    }
}