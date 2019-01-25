using System;
using System.ComponentModel.DataAnnotations;

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

            Console.Write("Введите координаты точки x1\n");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты точки x2\n");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты точки y1\n");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты точки y2\n");
            double y2 = Convert.ToDouble(Console.ReadLine());

            PointsDistance(x1, x2, y1, y2);

            VariableExchange();

            Console.WriteLine("Введите город проживания");
            string city = Console.ReadLine();

            PrintOnCenter(name,surname,city);

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
            double bodyMassIndex = m/(h*h);
            Console.WriteLine($"Ваш ИМТ = {bodyMassIndex:0.0000}");
        }

//            Задание 3
//        а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
//        б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

        private static void PointsDistance (double _x1, double _x2, double _y1, double _y2)
        {
            double r = Math.Sqrt(Math.Pow(_x2-_x1,2) + Math.Pow(_y2 - _y1,2));
            Console.WriteLine($"Расстояние между точками = {r:F2}");
        }

//            Задание 4
//        Написать программу обмена значениями двух переменных:
//        а) с использованием третьей переменной;
//        б) *без использования третьей переменной.

        private static void VariableExchange()
        {
            Console.WriteLine("Введите число 1 для обмена значенями:");
            int variable1 = Convert.ToInt32(Console.ReadLine()) ;

            Console.WriteLine("Введите число 2 для обмена значенями:");
            int variable2 = Convert.ToInt32(Console.ReadLine()) ;

            Console.WriteLine($"Вы ввели:{variable1} и {variable2}");

            int variable3 = variable2;
            variable2 = variable1;
            variable1 = variable3;

            Console.WriteLine($"Результат обмена:{variable1} и {variable2}");

            //Обмен с 2 переменными

            variable1 = variable1 + variable2;
            variable2 = variable1 - variable2;
            variable1 = variable1 - variable2;

            Console.WriteLine($"Результат обратного обмена:{variable1} и {variable2}");

        }

//            Задание 5
//        а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//        б) *Сделать задание, только вывод организовать в центре экрана.
//        в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).

        private static void PrintOnCenter(string _name, string _family, string _city)
        {
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine($"Вас зовут {_name}, ваша фамилия {_family}, город проживания {_city}");
        }

    }
}
