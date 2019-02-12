using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq.Expressions;


namespace Lesson6
{

    // Описываем делегат. В делегате описывается сигнатура методов, на
    // которые он сможет ссылаться в дальнейшем (хранить в себе)
    public delegate double  FunTask1(double x, double a);

    public delegate double FunTask2(double x);

    #region T3

    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;

        public Student(string firstName, string lastName, string university, string faculty, string department, int course,int age, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }

    }

    #endregion

    internal class Program
    {
        #region T1

        public static void Table(FunTask1 F, double x, double b, double a)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, a));
                x += 1;
            }

            Console.WriteLine("---------------------");
        }

        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double x, double a)
        {
            return a * Math.Pow(x, 2);
        }

        public static double FuctSinMulti(double x, double a)
        {
            return a * Math.Sin(x);
        }

        #endregion

        #region T2


        public static double F(double x)
        {
            return x * x-50*x+10;
        }

        public static double F2(double x)
        {
            return x * x - 40*x + 20;
        }

        public static void SaveFunc(FunTask2 delegateFunc,string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(delegateFunc(x));
                x += h; // x=x+h;
            }

            bw.Close();
            fs.Close();
        }

        public static double[] Load(string fileName, out double min)
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryReader bw = new BinaryReader(fs);
                min = double.MaxValue;
                double d;

                // определяем количество чисел в двоичном потоке
                long n=fs.Length/8;
                //создаем массив длинной в количествол цифр, чтобы класть в него считтанные цифры
                double[] readedVal = new double[n];

                for (int i = 0; i < fs.Length / sizeof(double); i++)
                {
                    // Считываем значение и переходим к следующему
                    d = bw.ReadDouble();

                    //кладем считанное значение в массив
                    readedVal[i] = d;

                    if (d < min) min = d;
                }
                bw.Close();
                fs.Close();

                return readedVal;

            }



        #endregion

static int MyDelegatByName(Student st1, Student st2)          // Создаем метод для сравнения для экземпляров
        {
            return String.Compare(st1.firstName, st2.firstName);          // Сравниваем две строки
        }

        static int MyDelegatByAge(Student st1, Student st2)
        {
            return st1.age.CompareTo(st2.age);
        }

        public static void Main(string[] args)
            {
                //Коновалов А.

                #region Task 1

//            Задание
//            Изменить программу вывода таблицы функции так, чтобы можно было передавать функции
//            типа double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).

// Создаем новый делегат и передаем ссылку на него в метод Table
                Console.WriteLine("Таблица функции MyFunc(a*x^2):");
                Table(MyFunc, -2, 2, 6);

                Console.WriteLine("Таблица функции FuctSinMulti(a*sin(x)):");
                Table(FuctSinMulti, -2, 2, 6);

                #endregion

                #region Task 2

//            Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
//            а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на
//            каком отрезке находить минимум. Использовать массив (или список) делегатов, в котором хранятся различные функции.
//            б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.
//            Пусть она возвращает минимум через параметр (с использованием модификатора out).


                FunTask2[] delegateArr = new FunTask2[2];
                delegateArr[0] = F;
                delegateArr[1] = F2;

                Console.WriteLine("Напишите функцию для которой ищем минимум:\n1. x * x-50*x+10\n2. x * x - 40*x + 20");
                int requestFunction = Int32.Parse(Console.ReadLine());
                if (requestFunction > delegateArr.Length || requestFunction < 0 )
                {
                    Console.WriteLine("Вы ввели номер функции которой не существует");
                }
                else
                {
                    Console.WriteLine("Введите а = начало отрезка, для которого считаем минимум :");
                    int a = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Введите b = конец отрезка, для которого считаем минимум :");
                    int b = Int32.Parse(Console.ReadLine());

                    double min;
                    SaveFunc(delegateArr[requestFunction-1],"data.bin", a, b, 0.5);

                    //Выводим данные из возвращенного нам из Load массива
                    foreach (var numb in Load("data.bin",out min))
                    {
                        Console.WriteLine(numb);
                    }

                    //Выводим минимальное число, значение которого передано нам по ссылке из Load
                    Console.WriteLine($"Минимальное число: {min}");

                }

                #endregion

                #region Task 3

//                Переделать программу Пример использования коллекций для решения следующих задач:
//                а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
//                б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
//                в) отсортировать список по возрасту студента;
//                г) *отсортировать список по курсу и возрасту студента;


                int fivecourse = 0;
                int sixcouse = 0;


                List<Student> list = new List<Student>();

                // Запомним время в начале обработки данных
                DateTime dt = DateTime.Now;
                StreamReader sr = new StreamReader("..\\..\\students_1.csv");


                int[] studentoncourse = new int[6];

                while(!sr.EndOfStream)
                {
                    try {
                        string[] s = sr.ReadLine().Split(';');
                        list.Add(new Student(s[0],s[1],s[2],s[3],s[4],int.Parse(s[5]),int.Parse(s[6]),int.Parse(s[7]),s[8]));// Добавляем склееные имя и фамилию

                        int age = int.Parse(s[5]);
                        int course = int.Parse(s[6]);

                        //Если студенту от 18 до 20 в элемент массива с индексом = номер курса плюсанем 1 пишем course-1 потому что нулевого курса нет

                        if (age >= 18 && age <= 20)
                        {
                            studentoncourse[course-1] = studentoncourse[course-1]+1;
                        }

//                      Проверим на каком курсе студент и плюсанем туда
                        switch (course)
                        {
                            case 5: fivecourse++; break;
                            case 6: sixcouse++; break;

                        }

                    }
                    catch
                    {
                    }

                }
                sr.Close();

                //отсортируем студентов по возрасту
                list.Sort(MyDelegatByAge);

                //выводим сколько студентов от 18 до 20 на каком курсе учатся
                foreach (var count in studentoncourse)
                {
                    Console.WriteLine($"На {Array.IndexOf(studentoncourse,count) + 1} курсе {count} студентов от 18 до 20");
                }

                Console.WriteLine("Всего студентов:" + list.Count);
                Console.WriteLine("Студентов на 6 курсе:{0}", sixcouse);
                Console.WriteLine("Cтудентов на 5 курсе:{0}", fivecourse);

                // Вычислим время обработки данных
                Console.WriteLine(DateTime.Now - dt);

                foreach (var v in list) Console.WriteLine(v.firstName);

                Console.ReadKey();

                #endregion
            }
    }
}
