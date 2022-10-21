/*using System;
using System.Security.Cryptography.X509Certificates;

namespace Problem.Chapter5_1_
{
    interface IX { void XMethod(int i); } // 인터페이스 선언
    interface IY { void YMethod(int i); }

    class A : IX
    {
        private int a;
        public int PropertyA
        {
            get { return a; }
            set { a = value; }
        }
        public void XMethod(int i) { a = i; } // 메소드 구현(기능 구현)
    }

    class B : A, IY
    {
        private int b;
        public int PropertyB
        {
            get { return b; }
            set
            {
                b = value;
            }
        }
        public void YMethod(int i) { b = i; } // 메소드 구현(기능 구현)
    }
    internal class _5_12_DiamondApp
    {
    public static void Main()
    {
            B obj = new B();
            obj.XMethod(5); obj.YMethod(10);
            Console.WriteLine("a = {0}, b = {1}", obj.PropertyA, obj.PropertyB);
    }
    }
}
*/