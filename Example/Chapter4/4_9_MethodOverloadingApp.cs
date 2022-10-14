/*using System;

namespace Problem.Chapter4
{
    internal class _4_9_MethodOverloadingApp
    {
        void SomeThing() // Non-static (객체 생성 이후에만 메모리에 존재)
        {
            Console.WriteLine("SomeThing() is called.");
        }
        void SomeThing(int i)
        {
            Console.WriteLine("SomeThing(int) is called.");
        }
        void SomeThing(int i, int j)
        {
            Console.WriteLine("SomeThing(int, int) is called.");
        }
        void SomeThing(double d)
        {
            Console.WriteLine("SomeThing(double) is called.");
        }
        public static void Main()
        {
            _4_9_MethodOverloadingApp obj = new _4_9_MethodOverloadingApp();
            obj.SomeThing();
            obj.SomeThing(526);
            obj.SomeThing(54, 526);
            obj.SomeThing(5.26);
        }
    }
}
*/