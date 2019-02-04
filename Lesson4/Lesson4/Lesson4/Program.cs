using System;

namespace Lesson4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TwoDimensionalArray arr = new TwoDimensionalArray(2,3);
            arr.SetVales();
            Console.WriteLine(arr);
        }
    }
}