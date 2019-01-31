using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Коновалов А.П.

            #region Task1

 //             Задание 1
//             Написать метод, возвращающий минимальное из трёх чисел.

            Console.WriteLine(MinNumber(1, 3, 5));


            #endregion

            #region Task2

//            Задание 2
//            Написать метод подсчета количества цифр числа.

            Console.WriteLine("Введите число для подсчета количества цифр в нем");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(NumbsInNumber(number));

            #endregion

            #region Task3

//            Задание 3
//            С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечётных положительных чисел.

            CounOfOddNumbers();

            #endregion

            #region Task4

////            Задание 4
////            Реализовать метод проверки логина и пароля. На вход подается логин и пароль.
////            На выходе истина, если прошел авторизацию, и ложь, если не прошел
////            (Логин: root, Password: GeekBrains). Используя метод проверки логина и
////            пароля, написать программу: пользователь вводит логин и пароль, программа
////            пропускает его дальше или не пропускает. С помощью цикла do while ограничить
////            ввод пароля тремя попытками.

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

            #endregion

            #region Task5

//            Задание 5
//             а) Написать программу, которая запрашивает массу и рост человека,
//                вычисляет его индекс массы и сообщает, нужно ли человеку
//                похудеть, набрать вес или все в норме;
//
//            б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

            BodyMassIndexCheck();


            #endregion

            #region Task7

//         a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);

            FromAtoB(2,5);

            #endregion
        }

        /// <summary>
        /// Возвращает минимум из трех чисел
        /// </summary>
        /// <param name="a">число 1</param>
        /// <param name="b">число 2</param>
        /// <param name="c">число 3</param>
        /// <returns>Максимум из трех чисел</returns>
        public static int MinNumber(int a, int b, int c)
        {
            int min;

            if (a <= b) min = a;
            else min = b;

            if (c < min)
            {
                return c;
            }

            return min;
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
                Console.WriteLine("Подсчитываем сумму всех нечётных положительных чисел. Введите число \n Для выхода введите 0");
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

        /// <summary>
        /// Вычисляет ИМТ и говорит сколько сбросить или набрать
        /// </summary>
        public static void BodyMassIndexCheck()
        {
            Console.WriteLine("Введите свою массу");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите свой рост");
            double growth = Convert.ToDouble(Console.ReadLine());

            var bodyMassIndex = weight/Math.Pow((growth/100),2) ;

            if (bodyMassIndex >= 18.5 && bodyMassIndex <= 25)
            {
                Console.WriteLine("Нормальная масса тела");
            }
            else if (bodyMassIndex < 18.5)
            {
                var massDifference = 18.5 * Math.Pow((growth / 100), 2);
                Console.WriteLine($"Недостаточная (дефицит) масса тела, нужно набрать {massDifference - weight} кг.");
            }
            else
            {
                var massDifference = 25 * Math.Pow((growth / 100), 2);
                Console.WriteLine($"Избыточная масса тела, нужно сбросить {weight - massDifference} кг.");
            }

        }

        /// <summary>
        /// Выводит числа от a до b
        /// </summary>
        /// <param name="a">Введите число "от"</param>
        /// <param name="b">Введите число "до"</param>
        public static void FromAtoB(int a, int b)
        {
            if (a <= b)
            {
                Console.Write(a + " ");
                a++;
                FromAtoB(a, b);
            }
        }


    }
}