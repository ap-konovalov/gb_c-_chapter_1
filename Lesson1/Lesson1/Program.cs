using System;

namespace Lesson1
{
    class Program
    {
//            Коновалов А.

        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите возраст");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите рост");
            double growth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите вес");
            double weight = Convert.ToInt32(Console.ReadLine());

            CreateProfile(name,surname,age,growth,weight);

            BodyMassIndexCalculation(weight, growth);

        }

//            Задание 1
//            Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
//            а) используя  склеивание;
//            б) используя форматированный вывод;
//            в) используя вывод со знаком $.

        public static void CreateProfile(string _name, string _surname, int _age, double _growth, double _weight)
        {
            Console.WriteLine("Вас зовут " + _name + $" ,ваша фамилия {_surname} и вам {_age} годиков, а выросли вы до {_growth:F} сантиметров при этом весите {_weight: #.####} килограмм");
        }

//            Задание 2
//            Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле /k’I
//            =m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

        private static void BodyMassIndexCalculation(double m, double h)
        {
            double BodyMassIndex = m/(h*h);
            Console.WriteLine($"Ваш ИМТ = {BodyMassIndex:0.0000}");
        }
    }
}
