/*using System;

namespace Problem.Chapter4
{
    internal class _4_4_CallByValueApp
    {
        static void Swap(int x, int y)
        {
            int temp;
            temp = x; x = y; y = temp;
            Console.WriteLine(" Swap: x = {0}, y = {1}", x, y);
        }
        public static void Main()
        {
            int x = 1, y = 2;
            Console.WriteLine("Before: x = {0}, y = {1}", x, y);
            Swap(x, y);
            Console.WriteLine(" After: x = {0}, y = {1}", x, y);
        }
        // 값에 의한 호출에서 Swap() 에서 이루어지는 x, y의 값 변화는
        // Main()의 x, y에 영향을 미치지 못함
    }
}
*/