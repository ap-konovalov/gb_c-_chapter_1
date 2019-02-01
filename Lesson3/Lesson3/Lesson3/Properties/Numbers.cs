using System;

namespace Lesson3.Properties
{
    public class Numbers
    {
        private int number;
        private int sum = 0;
        private string stringResult = string.Empty;




//        public bool IsZero()
//        {
//            return number == 0;
//        }

//        public bool IsOdd()
//        {
//            return number % 2 != 0;
//        }
//
//        public bool IsPositive()
//        {
//            return number > 0;
//        }

        public void GetValues()
        {
            while (true)
            {
                Console.WriteLine("Введите число");

                var readedValue = Console.ReadLine();

                if (readedValue == "0")
                {
                    break;
                }

                var isParsed = int.TryParse(readedValue, out var result);
                if (!isParsed)
                {
                    continue;
                }

                if (result % 2 == 0 && result <= 0)
                {
                    continue;
                }

                stringResult = $"{stringResult} {result}";

            }

        }

        public int SumOfOdd()
        {

            if (IsOdd() && IsPositive())
            {
                sum += number;
            }

            return sum;
        }

    }
}