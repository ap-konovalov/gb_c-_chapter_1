using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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

//            б) **с использованием регулярных выражений.

            Regex loginmask = new Regex("^[a-zA-Z]{1}[a-zA-Z1-9]{1,9}");
            if (loginmask.Equals(login))
            {
                Console.WriteLine("\nЛогин одобрен regexp");
            }
            else
            {
                Console.WriteLine("\nЛогин не одобрен regexp");
            }

            #endregion

            #region Task 2

            string message = "один два я пошли сереневый";
            Console.WriteLine($"Введена строка {message}");

            //удалит из строки все слова короче 10 символов
            Message.CutWordsFromString(message);

            Message.DelWordsEndWith(message, "а");

            //найдет самое длинное слово в строке
            Console.WriteLine($"Самое длинное слово  в строке: {Message.IsLongestWord(message)}");


            //строка из самых длинных слов
            Message.LongestWordString(message);


            string forcoutmess = "я пошел гулять я и не я";
            string[] wordsforcounter = new string[]{"я",
                "пошел",
                "спать"
            };
            
            Message.WordsCounter(forcoutmess,wordsforcounter);

            #endregion

            #region Task 3
            
//            *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
//            Например:
//            badc являются перестановкой abcd.

            Message.backToFrontString("asdf","fssa");

            #endregion
            
        }
    }
}