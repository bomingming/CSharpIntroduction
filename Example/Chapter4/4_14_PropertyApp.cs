/*using System;

namespace Problem.Chapter4
{
    // 프로퍼티 : 메소드이지만 필드처럼 사용되는 클래스 멤버
    class Fraction
    {
        private int numerator;
        private int denominator;
        public int Numerator // 프로퍼티는 필드와 유사하지만 다른 이름 사용(필드의 첫 글자를 대문자 처리)
            // private 접근자를 갖는 필드에 대해 참조와 할당 기능을 제공
        {
            get { return numerator; }
            set { numerator = value; } // 배정 연산에서 할당되는 값 value
        }
        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }
        override public string ToString()
        {
            return (numerator + "/" + denominator);
        }
    }
    internal class _4_14_PropertyApp
    {
        public static void Main()
        {
            Fraction f = new Fraction(); int i;
            f.Numerator = 1; // 왼쪽 : set
            i = f.Numerator + 1; // 오른쪽 : get
            f.Denominator = i;
            Console.WriteLine(f.ToString());
        }
    }
}
*/