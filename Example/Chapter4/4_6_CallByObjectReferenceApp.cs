/*using System;

namespace Problem.Chapter4
{
    class Integer
    {
        public int i;
        public Integer(int i) // 생성자
        {
            this.i = i;
        }
    }
    internal class _4_6_CallByObjectReferenceApp
    {
        static void Swap(Integer x, Integer y) // 객체는 참조형 변수이므로 ref 지정어 불필요
        {
            int temp = x.i; x.i = y.i; y.i = temp;
            Console.WriteLine(" Swap: x = {0}, y = {1}", x.i, y.i);
        }
        public static void Main()
        {
            Integer x = new Integer(1);
            Integer y = new Integer(2);
            Console.WriteLine("Before: x = {0}, y = {1}", x.i, y.i);
            Swap(x, y); // x, y는 참조형 변수(객체)이므로 객체에 대한 주소가 저장
            Console.WriteLine(" After: x = {0}, y = {1}", x.i, y.i);
        }
        // Swap에 의한 Main()의 값 변화 있음
    }
}
*/