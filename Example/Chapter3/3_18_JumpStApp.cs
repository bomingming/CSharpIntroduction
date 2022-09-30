/*using System;

namespace Problem.Chapter3
{
    internal class _3_18_JumpStApp
    {
        public static void Main()
        {
            int n, s, i;
            for(; ; )
            {
                Console.Write("Enter a number : ");
                n = Int32.Parse(Console.ReadLine()); // 받은 정수 문자열을 정수로 변환
                if (n == 0) break;
                else if (n < 0) continue;
                for (s = 0, i = 1; i <= n; ++i)
                    s = sum(s, i);
                Console.WriteLine("n = {0}, sum = {1}", n, s);
            }
            Console.WriteLine("End of Main");
        }
        static int sum(int s, int i) // 두 정수의 합을 반환하는 메소드
        {
            return s + i;
        }
    }
}
*/