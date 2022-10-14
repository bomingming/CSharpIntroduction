/*using System;

namespace Problem.Chapter4
{
    class Fraction
    {
        int numerator;
        int denominator;
        public Fraction() // 디폴트 생성자
        {
            numerator = 0;
            denominator = 1;
        }
        public Fraction(int n)
        {
            numerator = n;
            denominator = 1;
        }
        public Fraction(int n, int d)
        {
            numerator = n;
            denominator=d;
        }
        override public String ToString() // 기존의 ToString() 메소드를 override 함
        {
            return (numerator + "/" + denominator);
        }
    }
    internal class _4_10_OverloadedConstructorApp
    {
        public static void Main()
        {
            Fraction f1 = new Fraction(), f2 = new Fraction(2), f3 = new Fraction(1, 2);
            Console.WriteLine("f1 = {0}, f2 = {1}, f3 = {2}", f1, f2, f3);
        }
    }
}
*/