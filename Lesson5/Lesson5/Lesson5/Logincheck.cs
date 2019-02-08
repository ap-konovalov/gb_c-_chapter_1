using System;

namespace Lesson5
{
    internal partial class Program
    {
        /// <summary>
        /// Проверяет длинну логина от 2 до 10 символов
        /// </summary>
        /// <param name="login">строка логин</param>
        /// <returns></returns>
        private static bool LoginWidthOK(string login)
        {
            if (login.Length >= 2 && login.Length <= 10)
            {
                Console.WriteLine("Все ОК с длинной логина");
                return true;
            }

            Console.WriteLine("Длинна логина должна быть от 2 до 10 символов");
            return false;
        }

        /// <summary>
        /// Проверяет что содержит только символы и цифры
        /// </summary>
        /// <param name="login">строка логин</param>
        /// <returns></returns>
        private static bool LoginIsSymbOrNumb(string login)
        {
            char[] LoginCharArr = login.ToCharArray();

            foreach (var symbol in LoginCharArr)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    Console.WriteLine("Допустимы только буквы и цифры");
                    return false;
                }
            }

            Console.WriteLine("Все ОК с символами и цифрами");
            return true;
        }

        /// <summary>
        /// Проверяет что первый символ не цифра
        /// </summary>
        /// <param name="login">строка логин</param>
        /// <returns></returns>
        private static bool FirstSymbNotNumb(string login)
        {
            char first = login[0];

            if (!char.IsLetter(first))
            {
                Console.WriteLine("Первый символ должен быть буквой");
                return false;
            }

            Console.WriteLine("Все ОК. Первый символ буква");
            return true;
        }
    }
}