using System;
using System.IO;

namespace Lesson4
{
    public struct Account
    {
        public string[] Login;
        private string[] Password;

        /// <summary>
        /// Создает структуру с массивами логинов и паролей
        /// </summary>
        /// <param name="ArraySize">Количество записей логина и пароля в создаваемых массивах</param>
        public Account(int ArraySize)
        {
            Login = new string[ArraySize];
            Password = new string[ArraySize];
        }

        /// <summary>
        /// Считает и добавит в массив Login все из файла
        /// </summary>
        /// <param name="filename">Имя файла с логинами</param>
        public void AddLoginsFromFile(string filename)
        {
            int index = 0;

            StreamReader sr = new StreamReader("..\\..\\" + filename);

            while (!sr.EndOfStream)
            {
                string login = sr.ReadLine();
                Login[index] = login;
                index++;
            }
        }

        /// <summary>
        /// Считает и добавит в массив Password все из файла
        /// </summary>
        /// <param name="filename">Имя файла с паролями</param>
        public void AddPasswordsFromFile(string filename)
        {
            int index = 0;

            StreamReader sr = new StreamReader("..\\..\\" + filename);

            while (!sr.EndOfStream)
            {
                string password = sr.ReadLine();
                Password[index] = password;
                index++;
            }
        }


        /// <summary>
        /// Сопоставит логин и пароль с тем что есть в массивах и предоставит доступ
        /// </summary>
        public void TryToLogin()
        {
            int CoutOfAttempts = 3;
            do
            {
                Console.WriteLine("Введите логин");
                string enterLogin = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string enterPassword = Console.ReadLine();

                for (int i = 0; i < Login.Length ; i++)
                {
                    if (enterLogin == Login[i])
                    {
                        if (enterPassword == Password[i])
                        {
                            Console.WriteLine("Доступ разрешен");
                            return;
                        }
                    }
                }
                Console.WriteLine($"Доступ запрещен.\nОсталось попыток: {CoutOfAttempts-1}");

                CoutOfAttempts--;
            } while (CoutOfAttempts > 0);

        }
    }
}