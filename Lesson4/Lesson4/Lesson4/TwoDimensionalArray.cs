using System;

namespace Lesson4
{
    class TwoDimensionalArray
    {

     public int[,] Array;

        /// <summary>
        /// Создает двумерный массив
        /// </summary>
        /// <param name="a">Количество строк</param>
        /// <param name="b">Количество столбцов</param>
     public TwoDimensionalArray(int a, int b)
    {
         Array = new int[a, b];
    }

        public void SetVales()
        {
            int[,] Arr = Array;
            for (int i = 0; i < Array.GetLength(0);i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Arr[i, j] = 0;
                }
            }


        }


    }
}