﻿/*using System;

namespace Problem.Chapter5_1_
{
    class BaseClass
    {
        public int a, b;
        public BaseClass()
        {
            a = 1; b = 2;
        }
        public BaseClass(int a, int b)
        {
            this.a = a; this.b = b;
        }
    }

    class DerivedClass : BaseClass
    {
        public int c;
        public DerivedClass()
        {
            c = 1;
        }
        public DerivedClass(int a, int b, int c) : base(a, b) // 매개변수를 갖는 base() 생성자 - 명시적 호출 필요.
            // 생성자 뒤에 : 적고 호출 (생략 시 베이스 클래스 기본 생성자 호출)
        {
            this.c = c;
        }
    }
    internal class _5_3_BaseCallApp
    {
        public static void Main()
        {
            DerivedClass obj1 = new DerivedClass();
            DerivedClass obj2 = new DerivedClass(1, 2, 3);
            Console.WriteLine("a = {0}, b = {1}, c = {2}", obj1.a, obj1.b, obj1.c);
            Console.WriteLine("a = {0}, b = {1}, c = {2}", obj2.a, obj2.b, obj2.c);
        }
    }
}
*/