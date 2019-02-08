using System;

namespace Lesson5


{
    internal partial class Program
    {
        public static void Main(string[] args)
        {
            // Коновалов А.

            #region Task1

//            Создать программу, которая будет проверять корректность ввода логина.
//            Корректным логином будет строка от 2 до 10 символов, содержащая только
//            буквы латинского алфавита или цифры, при этом цифра не может быть первой:
//            а) без использования регулярных выражений;
//            б) **с использованием регулярных выражений.

            Console.WriteLine("Введите логин");
            string login = Console.ReadLine();

            if (LoginWidthOK(login) && LoginIsSymbOrNumb(login) && FirstSymbNotNumb(login))
            {
                Console.WriteLine("Логин одобрен");
            }
            else
            {
                Console.WriteLine("Логин не подходит");
            }
            #endregion

        }
    }
}