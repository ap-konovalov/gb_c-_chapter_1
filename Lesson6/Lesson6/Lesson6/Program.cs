using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Linq.Expressions;


namespace Lesson6
{

    // Описываем делегат. В делегате описывается сигнатура методов, на
    // которые он сможет ссылаться в дальнейшем (хранить в себе)
    public delegate double  FunTask1(double x, double a);

    public delegate double FunTask2(double x);


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

        public static double Load(string fileName)
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryReader bw = new BinaryReader(fs);
                double min = double.MaxValue;
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

// выводим элементы массива
                Console.WriteLine("В результате работы функции сгенерированы следующие числа: ");
                foreach (var numb in readedVal)
                {
                    Console.WriteLine(numb);
                }


                bw.Close();
                fs.Close();

                Console.WriteLine("Минимальное число:");
                return min;

            }



        #endregion

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

                    SaveFunc(delegateArr[requestFunction-1],"data.bin", a, b, 0.5);
                    Console.WriteLine(Load("data.bin"));
                }

//              TODO 1:  Пусть она возвращает минимум через параметр (с использованием модификатора out).

                #endregion

                #region Task 3

                int fivecourse = 0;
                int sixcouse = 0;

                // Создадим необобщенный список
                ArrayList list = new ArrayList();
                // Запомним время в начале обработки данных
                DateTime dt = DateTime.Now;
                StreamReader sr = new StreamReader("..\\..\\students_1.csv");


                int[] studentoncourse = new int[7];

                while(!sr.EndOfStream)
                {
                    try {
                        string[] s = sr.ReadLine().Split(';');
                        // Console.WriteLine("{0}", s[0], s[1], s[2], s[3], s[4]);
                        list.Add(s[1]+" "+s[0]);// Добавляем склееные имя и фамилию
                        int age = int.Parse(s[5]);
                        int course = int.Parse(s[6]);

                        //Если студенту от 18 до 20 в элемент массива с индексом = номер курса плюсанем 1

                        if (age >= 18 && age <= 20)
                        {
                            studentoncourse[course] = studentoncourse[course]+1;
                        }

//                      Проверим на каком курсе студент и плюсанем туда
                        switch (course)
                        {
                            case 5: fivecourse++; break;
                            case 6: sixcouse++; break;

                        }
// TODO 2: Задача 3 от п.б
                    }
                    catch
                    {
                    }

                }
                sr.Close();
                list.Sort();
                foreach (var course in studentoncourse)
                {
                    Console.WriteLine(course);
                }

                Console.WriteLine("Всего студентов:{0}", list.Count);
                Console.WriteLine("Студентов на 6 курсе:{0}", sixcouse);
                Console.WriteLine("Cтудентов на 5 курсе:{0}", fivecourse);
//                foreach (var v in list) Console.WriteLine(v);
                // Вычислим время обработки данных
                Console.WriteLine(DateTime.Now - dt);
                Console.ReadKey();


                #endregion
            }
    }
}
