/*using System;
using System.Reflection;

namespace Problem.Chapter2
{
    class Apple
    {
        public int nSeeds = 0;
        public void Ripen() { *//* ... *//* }
    }
    internal class _2_26_TypeOfOperatorApp
    {
        public static void Main()
        {
            Type t = typeof(Apple);
            string className = t.ToString();
            MemberInfo[] allMembers = t.GetMembers(); //  Type.GetMembers() 메소드 : 주어진 Type의 멤버들 반환

            Console.Write("All" + className + "Members:");
            foreach(MemberInfo member in allMembers) // MemberInfo 클래스 : 멤버 메타데이터에 액세스. Reflection
            {
                Console.WriteLine(member.ToString());
            }
        }
    }
}
*/