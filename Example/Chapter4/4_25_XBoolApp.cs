/*using System;

namespace Problem.Chapter4
{
    class XBool
    {
        public bool b;
        public static explicit operator bool(XBool x)
            // XBool형을 bool형으로 명시적 변환하는 연산자 중복
        {
            Console.WriteLine("In the explicit operator bool...");
            return x.b;
        }
        public static bool operator true(XBool x)
            // XBool형에 대한 true 연산자의 중복(반환형 : bool)
        {
            Console.WriteLine("In the operator true...");
            return x.b ? true : false;
        }
        public static bool operator false(XBool x)
            // XBool형에 대한 false 연산자의 중복
        {
            Console.WriteLine("In the operator false...");
            return x.b ? false : true;
        }
    }
    internal class _4_25_XBoolApp
    {
        public static void Main()
        {
            XBool xb = new XBool();
            xb.b = false;
            if (xb)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            Console.WriteLine((bool)xb); // 명시적 변환
        }
    }
}
*/