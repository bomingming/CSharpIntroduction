/*using System;

namespace Problem.Chapter5_1_
{
    class BaseClass
    {
        protected int a = 1;
        protected int b = 2;
    }
    class DerivedClass : BaseClass
    {
        new int a = 3;
        new double b = 4.5;
        public void Output()
        {
            Console.WriteLine("BaseClass : a={0}, DerivedClass : a={1}", base.a, a);
            Console.WriteLine("BaseClass : b={0}, DerivedClass : b={1}", base.b, b);
        }
    }
    internal class _5_1_HiddenNameApp
    {
        public static void Main()
        {
            DerivedClass obj = new DerivedClass();
            obj.Output();
        }
    }
}
*/