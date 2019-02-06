using System;


namespace Lesson4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Коновалов А.


            #region Task 4

//            *а) Реализовать класс для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами. Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out)
//            *б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
//                Дополнительные задачи
//            в) Обработать возможные исключительные ситуации при работе с файлами.

            TwoDimensionalArray tda = new TwoDimensionalArray(2, 3);
            int  maxI = 0 , maxJ = 0;

            tda.SumOfElem();
            tda.SumOfElem(30);
            tda.MaxElemNumb(ref maxI, ref maxJ);

            Console.WriteLine($"Минимальный элемент массива: {tda.Min}");
            Console.WriteLine($"Максимальный элемент массива: {tda.Max}");
            Console.WriteLine($"Номер максимального элемента:[{maxI},{maxJ}]");

            TwoDimensionalArray file = new TwoDimensionalArray("data.txt");

            tda.SaveArr("note.txt");

            #endregion





        }
    }
}