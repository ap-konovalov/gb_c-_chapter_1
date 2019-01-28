using System;
using System.Security.Cryptography;
using System.Xml.Schema;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Коновалов А.П.

//             Задание 1
//             Написать метод, возвращающий минимальное из трёх чисел.

            Console.WriteLine(MaxNumber(1, 3, 5));

//            Задание 2
//            Написать метод подсчета количества цифр числа.

            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(NumbsInNumber(number));

        }

        /// <summary>
        /// Возвращает максимум из трех чисел
        /// </summary>
        /// <param name="a">число 1</param>
        /// <param name="b">число 2</param>
        /// <param name="c">число 3</param>
        /// <returns>Максимум из трех чисел</returns>
        public static int MaxNumber(int a, int b, int c)
        {
            int max = 0;

            if (a >= b) max = a;
            else max = b;

            if (c > max)
                return c;
            else
                return max;
        }

        /// <summary>
        /// Определяет количество цифр в числе
        /// </summary>
        /// <param name="number"> Целое число </param>
        /// <returns></returns>
        public static int NumbsInNumber(int number)
        {
            int count = 0;

            while (number != 0)
            {
            number = number / 10;
            count++;
            }

            return count;
        }
    }
}