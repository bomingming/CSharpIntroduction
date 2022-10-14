/*using System;

namespace Problem.Chapter4
{
    internal class Lesson_48_GenericMethodApp
    {
        static void Swap<DataType>(ref DataType x, ref DataType y)
            // 값형 인자 - 원본 변경의 반영을 위하여 call-by-reference 위해 ref 지정어로 선언
        {
            DataType temp;
            temp = x; x = y; y = temp;
        }
        public static void Main()
        {
            int a = 1, b = 2; double c = 1.5, d = 2.5;
            Console.WriteLine("Before: a = {0}, b = {1}", a, b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("After: a = {0}, b = {1}", a, b);
            Console.WriteLine("Before: c = {0}, b = {1}", c, d);
            Swap<double>(ref c, ref d);
            Console.WriteLine("After: c = {0}, d = {1}", c, d);
        }
    }
}
*/