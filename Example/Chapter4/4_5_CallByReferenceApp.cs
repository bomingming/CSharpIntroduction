/*using System;

namespace Problem.Chapter4
{
    internal class _4_5_CallByReferenceApp
    {
        static void Swap(ref int x, ref int y)
        {
            int temp;
            temp = x; x = y; y = temp;
            Console.WriteLine(" Swap: x = {0}, y = {1}", x, y);
        }
        public static void Main()
        {
            int x = 1, y = 2; // x, y는 초기화된 상태
            Console.WriteLine("Before: x = {0}, y = {1}", x, y);
            Swap(ref x, ref y); // x, y가 1, 2로 초기화된 상태
            Console.WriteLine(" After: x = {0}, y = {1}", x, y);
        }
        // 형식 매개변수와 실 매개변수 앞에 지정어 ref를 붙이면 참조 호출로 간주하여 주소가 전달됨
        // 호출된 메소드에서 바뀐 값이 호출한 메소드에서도 그대로 유지되는 것
        // 따라서 Swap(),에서 이루어지는 변화가 Main()의 x, y에도 영향을 미침
    }
}
*/