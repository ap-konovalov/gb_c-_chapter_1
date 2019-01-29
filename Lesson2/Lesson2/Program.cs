using System;
using System.ComponentModel.Design;
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

            Console.WriteLine("Введите число для подсчета количества цифр в нем");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(NumbsInNumber(number));

//            Задание 3
//            С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечётных положительных чисел.

            CounOfOddNumbers();

//            Задание 4
//            Реализовать метод проверки логина и пароля. На вход подается логин и пароль.
//            На выходе истина, если прошел авторизацию, и ложь, если не прошел
//            (Логин: root, Password: GeekBrains). Используя метод проверки логина и
//            пароля, написать программу: пользователь вводит логин и пароль, программа
//            пропускает его дальше или не пропускает. С помощью цикла do while ограничить
//            ввод пароля тремя попытками.

            int CoutOfAttempts = 3;
            do
            {
                Console.WriteLine("Введите логин");
                string login = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string password =  Console.ReadLine();
                if(IsRightPassword(login, password)) break ;
                Console.WriteLine($"Осталось попыток: {CoutOfAttempts-1} ");
                CoutOfAttempts--;

            } while (CoutOfAttempts > 0);

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

        /// <summary>
        ///  Подсчитывает сумму всех нечётных положительных чисел
        /// </summary>
        public static void CounOfOddNumbers()
        {

            int number = 1;
            int sum = 0;

            while (number != 0)
            {
                Console.WriteLine("Enter number. For exit press 0");
                number = Convert.ToInt32(Console.ReadLine());
                if (number > 0 && number % 2 != 0) sum += number;
            }

            Console.WriteLine($"Sum of odd numbers = {sum}");
        }

        /// <summary>
        /// Проверка логина и пароля
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns></returns>
        private static bool IsRightPassword(string login, string password)
        {
            if (login == "root" && password == "GeekBrains")
            {
                Console.WriteLine("Добро пожаловать!");
                return true;
            }
            return false;
        }

    }
}