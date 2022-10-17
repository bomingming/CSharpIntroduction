/*using System;

namespace Problem.Chapter5_1_
{
    class Parent
    {
        public int variable = 273;
        public void Method()
        {
            Console.WriteLine("부모의 메소드");
            Console.WriteLine("variable = {0}", variable);
        }
    }
    class Child : Parent
    {
        public new string variable = "hiding"; // 필드 hiding
        public new void Method()
        {
            Console.WriteLine("자식의 메소드");
            base.Method(); // Base 클래스의 필드, 메소드 참조
            Console.WriteLine("base : variable = {0}", base.variable);
            Console.WriteLine("variable = {0}", variable);
        }
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Method();
            ((Parent)child).Method(); // 부모 클래스로 명시적 형변환(업 캐스팅)
        }
    }
}
*/