using System;

namespace Lesson3.Properties
{
    public class Numbers
    {
        private int number;
        private int sum = 0;
        private string stringResult = "";

            /// <summary>
            /// Запрашивает ввод с консоли. Считает сумму положительных нечетных чисел.
            /// </summary>
        public void GetValues()
        {
            Console.WriteLine("Считаем сумму положительных нечетных чисел.\nДля выхода и просмотра результата введите 0");
            
            while (true)
            {
                Console.WriteLine("Введите число:");

                var readedValue = Console.ReadLine();

                if (readedValue == "0")
                {
                    Console.WriteLine($"Введенные положительных нечетные числа:{stringResult}");
                    Console.WriteLine($"Их сумма равна: {sum}");
                    break;
                }

                var isParsed = int.TryParse(readedValue, out var result);
                if (!isParsed)
                {
                    Console.WriteLine("Вы ввели не целое число");
                    continue;
                }

                if (result % 2 == 0 || result <= 0)
                {
                    continue;
                }

                sum += result;
                stringResult = $"{stringResult} {result}";
                
            }

        }

    }
}