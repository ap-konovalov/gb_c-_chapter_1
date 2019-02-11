using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Lesson6
{
    // Описываем делегат. В делегате описывается сигнатура методов, на
    // которые он сможет ссылаться в дальнейшем (хранить в себе)
    public delegate double Fun(double x, double a);

    internal class Program
    {
        public static void Table(Fun F, double x, double b, double a)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x,a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double x,double a)
        {
            return a * Math.Pow(x,2) ;
        }

        public static double FuctSinMulti(double x, double a)
        {
            return a * Math.Sin(x) ;
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
// Упрощение(c C# 2.0).Делегат создается автоматически.
            Table(MyFunc, -2, 2,6);
            Console.WriteLine("Таблица функции FuctSinMulti(a*sin(x)):");
            Table(FuctSinMulti, -2, 2, 6);
            Console.WriteLine(Math.Sin(2));
        }

            #endregion
        }
    }
