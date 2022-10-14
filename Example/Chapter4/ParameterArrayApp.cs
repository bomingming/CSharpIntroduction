/*using System;

namespace Problem.Chapter4
{
    internal class ParameterArrayApp
    {
        static void ParameterArray(params object[] obj)
            // 배열 역시 참조형 변수이므로 ref 지정어 불필요
            // object형은 모든 자료형 혹은 클래스를 대입 가능
            // 값형은 boxing 처리
        {
            for(int i= 0; i < obj.Length; i++)
                Console.WriteLine(obj[i]);
        }
        public static void Main()
        {
            ParameterArray(123, "Hello", true, 'A');
        }
    }
}
*/