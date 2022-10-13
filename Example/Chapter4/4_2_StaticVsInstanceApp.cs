/*using System;

namespace Problem.Chapter4
{
    internal class StaticVsInstanceApp
    {
        int instanceVariable;
        static int staticVariable;
        public static void Main()
        {
            StaticVsInstanceApp obj = new StaticVsInstanceApp();
            obj.instanceVariable = 10; // 객체 이름
            // 동일 클래스 내 non-static(instance) private 필드에 접근은
            // 자신에 대한 객체 생성 후(obj) 멤버 접근자(.)로 접근 가능
            StaticVsInstanceApp.staticVariable = 20; // 클래스 이름
            // static 멤버이기 때문에 클래스 이름으로 바로 접근
            Console.WriteLine("instance variable = {0}, static variable = {1}",
                obj.instanceVariable, StaticVsInstanceApp.staticVariable);
        }
    }
}
*/