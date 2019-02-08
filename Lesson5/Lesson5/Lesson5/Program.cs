using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace Lesson5


{
    internal class Program
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

            if (LoginWidthOK(login) && LoginIsSymbol(login))
            {
                Console.WriteLine("Все ОК полность");
            }
            else
            {
                Console.WriteLine("Все плохо полность");
            }

            #endregion


        }

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

        private static bool LoginIsSymbol(string login)
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
    }

    }

