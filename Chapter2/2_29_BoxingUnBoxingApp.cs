/*using System;

namespace Problem.Chapter2
{
    internal class _2_29_BoxingUnBoxingApp
    {
        public static void Main()
        {
            int foo = 526; // 원래 형
            object bar = foo; // 박싱. foo is boxed to bar
            Console.WriteLine(bar);
            try
            {
                //double d = (short)bar; -> 오류 발생(박싱 결과를 언박싱 시 원래 형으로 언박싱 해야 함)
                double d = (int)bar;
                Console.WriteLine(d);
            }catch(InvalidCastException e)
            {
                Console.WriteLine(e + "Error");
            }
        }
    }
}
*/