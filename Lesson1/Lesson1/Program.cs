using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
       
           Console.WriteLine("Введите имя");
           string name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите возраст");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите рост");
            int growth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите вес");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Вас зовут " + name + $" ,ваша фамилия {surname} и вам {age} годиков, а выросли вы до {growth:F} сантиметров при этом весите {weight: #.####} килограмм");

            Console.ReadKey();
        }
    }
}
