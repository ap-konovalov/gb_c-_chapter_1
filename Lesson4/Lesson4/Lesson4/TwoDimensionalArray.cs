using System;
using System.IO;

namespace Lesson4
{
    class TwoDimensionalArray
    {
        private static Random rndnumb = new Random();

        int[,] Array;
        private int[] filemassive;

        /// <summary>
        /// Создает двумерный массив и заполняет его цифрами
        /// </summary>
        /// <param name="a">Количество строк</param>
        /// <param name="b">Количество столбцов</param>
        public TwoDimensionalArray(int a, int b)
        {
            Array = new int[a, b];

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Array[i, j] = rndnumb.Next(0, 90);
                }
            }
        }

        /// <summary>
        /// Минимальный элемент массива
        /// </summary>
        public int Min
        {
            get
            {
                int min = Array[0, 0];
                foreach (var number in Array)
                {
                    if (number < min)
                    {
                        min = number;
                    }
                }

                return min;
            }
        }

        /// <summary>
        /// Максимальный элемент массива
        /// </summary>
        public int Max
        {
            get
            {
                int max = Array[0, 0];
                foreach (var number in Array)
                {
                    if (number > max)
                    {
                        max = number;
                    }
                }

                return max;
            }
        }

        public void SumOfElem()
        {
            int sum = 0;

            foreach (var number in Array)
            {
                sum += number;
            }

            Console.WriteLine($"Сумма элементов массива = {sum}");
        }

        /// <summary>
        /// Выводит сумму элементов двумерного числового  массива
        /// </summary>
        /// <param name="min">Минимальный элемент от которого считается сумма</param>
        /// <returns>Сумма элементов массива</returns>
        ///
        public void SumOfElem(int min)
        {
            int sum = 0;

            foreach (var number in Array)
            {
                if (number > min)
                {
                    sum += number;
                }
            }

            Console.WriteLine($"Сумма элементов массива больше {min} = {sum} ");
        }


       /// <summary>
       /// Вернет индекс максимального элемента массива
       /// </summary>
       /// <param name="maxI">Размерность массива 0</param>
       /// <param name="maxJ">Размерность массива 1</param>
        public void MaxElemNumb(ref int maxI, ref int maxJ)
        {
            int max = Array[0, 0];

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (Array[i, j] > max )
                    {
                        max = Array[i, j];
                        maxI = i;
                        maxJ = j;
                    }
                }
            }
        }

        /// <summary>
        /// Создаем массив считывая для него данные из текстового файла
        /// </summary>
        /// <param name="filename">имя файла из которого читаем данные</param>
        public TwoDimensionalArray(string filename)
        {
            //Выдаст ошибку, если неправильно указали имя файла
            try
            {
                StreamReader srd = new StreamReader("..\\..\\" + filename);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("ОШИБКА: Нет такого файла");
            }

            StreamReader sr = new StreamReader("..\\..\\" + filename);

            //Выдаст ошибку если в файле записано не число
            try
            {

                // Считываем 2 первых строки = размерность двумерного массива
                int I = int.Parse(sr.ReadLine());
                int J = int.Parse(sr.ReadLine());

                int[,] filemassive = new int[I, J];

                for (int i = 0; i < I; i++)
                {
                    for (int j = 0; j < J; j++)
                    {
                        filemassive[i, j] = int.Parse(sr.ReadLine());
                    }
                }

            }

            catch (FormatException format)
            {
                Console.WriteLine("ОШИБКА: В файле записано не число");
            }

            sr.Close();
        }

        public string ArrToStr
        {
            get
            {
                string stringArr = string.Empty;

                for (int i = 0; i < Array.GetLength(0); i++)
                {
                    for (int j = 0; j < Array.GetLength(1); j++)
                    {
                        stringArr += Array[i, j] + " ";
                    }

                    stringArr += "\n";
                }

                return stringArr;
            }
        }

       /// <summary>
       /// Сохраняет массив в текстовый файл
       /// </summary>
       /// <param name="filename">имя файла в который сохраняем</param>
        public void SaveArr(string filename)
       {
           FileStream fstream = null;

           // Открыли поток, выполнинли сохранение, в конце закрыли поток
           try
           {
               fstream = new FileStream(@"..\\..\\" + filename, FileMode.OpenOrCreate);

               // преобразуем строку в байты
               byte[] array = System.Text.Encoding.Default.GetBytes(ArrToStr);
               // запись массива байтов в файл
               fstream.Write(array, 0, array.Length);
               Console.WriteLine("Текст записан в файл");
           }
           catch (Exception e)
           {
               Console.WriteLine(e);
           }
           finally
           {
               if (fstream != null)
               {
                   fstream.Close();
               }
           }

        }

    }
}