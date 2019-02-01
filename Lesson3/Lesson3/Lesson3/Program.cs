using System;
using Lesson3.Properties;

// Коновалов А.П.
// Задание 1
//  а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
//  б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;

#region StructComplex

struct Complex
{
  public double im;
  public double re;

  // Вычетание комплексных чисел
  public Complex Minus(Complex x)
  {
    Complex y;
    y.im = im - x.im;
    y.re = re - x.re;
    return y;
  }


  //  в C# в структурах могут храниться также действия над данными
  public Complex Plus(Complex x)
  {
    Complex y;
    y.im = im + x.im;
    y.re = re + x.re;
    return y;
  }

  //  Пример произведения двух комплексных чисел
  public Complex Multi(Complex x)
  {
    Complex y;
    y.im = re * x.im + im * x.re;
    y.re = re * x.re - im * x.im;
    return y;
  }
  public string ToString()
  {
    return re + "+" + im + "i";
  }

  public string ToMinusString()
  {
    return re + "" + im + "i";
  }

}

#endregion

#region ClassComplex

class ComplexClass
{
  // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
  public double im;
  public double re;

  public ComplexClass Plus(ComplexClass x2)
  {
    ComplexClass x3 = new ComplexClass();
    x3.im = x2.im + this.im;
    x3.re = x2.re + this.re;
    return x3;
  }

  /// <summary>
  /// Вычетание комплексных чисел
  /// </summary>
  /// <param name="x2">вычетаемое комплексное число</param>
  /// <returns>Разность двух комплесных чисел</returns>
  public ComplexClass Minus(ComplexClass x2)
  {
    ComplexClass x4 = new ComplexClass();
    x4.im = this.im- x2.im ;
    x4.re =  this.re - x2.re;
    return x4;
  }

  public ComplexClass Multi(ComplexClass x2)
  {
    ComplexClass x5 = new ComplexClass();
    x5.im = re * x2.im + im * x2.re;
    x5.re = re * x2.re - im * x2.im;
    return x5;
  }

  public string ToString()
  {
    return re + "+" + im + "i";
  }

  public string ToMinusString()
  {
    return re + "" + im + "i";
  }
}

#endregion


class Program
{
  static void Main(string[] args)
  {

    #region StructComplexEx

    Complex complex1;
    complex1.re = 1;
    complex1.im = 1;

    Complex complex2;
    complex2.re = 2;
    complex2.im = 2;

    Console.WriteLine("Структура");

    Complex result = complex1.Plus(complex2);
    Console.WriteLine("Сложение  " + result.ToString());
    result = complex1.Minus(complex2);
    Console.WriteLine("Вычетание  " + result.ToMinusString());
    result = complex1.Multi(complex2);
    Console.WriteLine("Умножение  " + result.ToString());

    #endregion

    #region ClassComplexEx

    ComplexClass complex3 = new ComplexClass();
    complex3.re = 1;
    complex3.im = 1;

    ComplexClass complex4 = new ComplexClass();
    complex4.re = 2;
    complex4.im = 2;

    Console.WriteLine("\nКласс");

    ComplexClass result2 = complex3.Plus(complex4);
    Console.WriteLine("Сложение  " + result2.ToString());

    result2 = complex3.Minus(complex4);
    Console.WriteLine("Вычетание  " + result2.ToMinusString());

    result2 = complex3.Multi(complex4);
    Console.WriteLine("Умножение  " + result2.ToString());

    #endregion

    #region SumOfOddNumbers


    var inputNumber = new Numbers();

    inputNumber.GetValues();
    Console.WriteLine(inputNumber.SumOfOdd());

//    do
//    {
////      Console.WriteLine("Введите число");
//      InputNumber.GetValue();
//      InputNumber.number = Convert.ToInt32(Console.ReadLine());
//
//    } while (!InputNumber.IsZero());


//    if (InputNumber.IsOdd())
//    {
//      Console.WriteLine("Нечетное число");
//    }
//
//    if (InputNumber.IsZero())
//    {
//      Console.WriteLine("Вы ввели 0");
//    }


    #endregion

  }
};


