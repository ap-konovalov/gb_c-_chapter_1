using System;

namespace Lesson3.Properties
{
    public struct Fraction
    {
        private int a;
        private int b;

        public Fraction(int _a, int _b)
        {
            a = _a;
            b = _b;
        }

        public static Fraction Sum(Fraction f1, Fraction f2)
        {
            var suma = (f1.a + f2.a);
            var sumb = (f1.b+f2.b);
            return new Fraction(suma,sumb);
        }
        
        public string Print()
        {
            return $"{a}/{b}";
        }
    }
}