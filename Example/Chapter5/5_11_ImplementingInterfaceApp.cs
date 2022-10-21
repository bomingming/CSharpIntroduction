/*using System;
using System.Runtime.Remoting.Services;

namespace Problem.Chapter5_1_
{
    interface IRectangle
    {
        void Area(int width, int height);
    }
    interface ITriangle
    {
        void Area(int width, int height);
    }
    class Shape:IRectangle, ITriangle
    {
        void IRectangle.Area(int width, int height)
        {
            Console.WriteLine("Rectangle Area : " + width * height);
        }
        void ITriangle.Area(int width, int height)
        {
            Console.WriteLine("Triangle Area : " + width * height / 2);
        }
    }
    internal class _5_11_ImplementingInterfaceApp
    {
        public static void Main()
        {
            Shape s = new Shape();
            ((IRectangle)s).Area(20, 20); // 업캐스팅
            ((ITriangle)s).Area(20, 20); // 업캐스팅

            IRectangle r = s; // 인터페이스로 업캐스팅
            ITriangle t = s; // 인터페이스로 업캐스팅

            r.Area(30, 30);
            t.Area(30, 30);
        }
    }
}
*/