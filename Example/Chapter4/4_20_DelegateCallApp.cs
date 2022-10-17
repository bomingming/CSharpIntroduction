/*using System;


namespace Problem.Chapter4
{
    delegate void DelegateOne();
    delegate void DelegateTwo(int i);

    class DelegateClass
    {
        public void MethodA()
        {
            Console.WriteLine("In the DelegateClass.MethodA...");
        }
        public void MethodB(int i)
        {
            Console.WriteLine("DelegateClass.MethodB, i = " + i);
        }
    }
    internal class _4_20_DelegateCallApp
    {
        public static void Main()
        {
            DelegateClass obj = new DelegateClass(); // delegate 대상이 되는 메소드를 포함하는 객체 새성
            DelegateOne d1 = new DelegateOne(obj.MethodA);
            DelegateTwo d2 = new DelegateTwo(obj.MethodB);
            d1();
            d2(10);
        }
    }
}
*/