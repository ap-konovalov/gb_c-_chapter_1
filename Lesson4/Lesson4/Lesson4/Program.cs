using System;
using System.IO;

namespace Lesson4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TwoDimensionalArray tda = new TwoDimensionalArray(2, 3);
            int  maxI = 0 , maxJ = 0;

            tda.SumOfElem();
            tda.SumOfElem(30);
            tda.MaxElemNumb(ref maxI, ref maxJ);

            Console.WriteLine($"Минимальный элемент массива: {tda.Min}");
            Console.WriteLine($"Максимальный элемент массива: {tda.Max}");
            Console.WriteLine($"Номер максимального элемента:[{maxI},{maxJ}]");

            TwoDimensionalArray file = new TwoDimensionalArray("data.txt");

            foreach (var VARIABLE in file)
            {
                Console.WriteLine(VARIABLE);
            }

        }
    }
}