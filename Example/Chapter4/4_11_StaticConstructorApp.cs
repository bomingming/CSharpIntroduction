/*using System;

namespace Problem.Chapter4
{
    class StaticConstructor
    {
        static int staticWithInitializer = 100;
        static int staticWithNoInitializer;
        static StaticConstructor() // Main() 함수보다 먼저 실행됨
        {
            staticWithNoInitializer = staticWithInitializer+100;
        }
        public static void PrintStaticVariable()
        {
            Console.WriteLine("field 1 = {0}, field 2 = {1}", staticWithInitializer, staticWithNoInitializer);
        }
    }
    internal class _4_11_StaticConstructorApp
    {
        public static void Main()
        {
            StaticConstructor.PrintStaticVariable(); // 클래스이름.Static메소드
        }
    }
}
*/