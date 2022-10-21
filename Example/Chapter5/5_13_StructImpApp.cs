/*using System;

namespace Problem.Chapter5_1_
{
    interface IVector
    {
        void Insert(int n); // 배열에 원소를 삽입
        void ScalarSum(int n); // 배열의 각 원소에 스칼라 값을 더함
        void PrintVector(); // 배열에 있는 모든 원소 출력
    }
    struct Vector : IVector // 인터페이스를 상속한 구조체
    {
        private int[] v;
        private int index, size;
        public Vector(int size) // 생성자(반환형 void 없음)
        {
            v = new int[size];
            this.size = size; // 이름 혼동 방지 this 사용
            index = 0;
        }
        // 인터페이스에서 정의된 메소드들 구현
        public void Insert(int n)
        {
            if (index >= size)
                Console.WriteLine("Error : array overflow");
            else
                v[index++] = n;
        }
        public void ScalarSum(int n)
        {
            for (int i = 0; i < index; i++)
                v[i] += n;
        }
        public void PrintVector()
        {
            Console.Write("Contents:");
            for (int i = 0; i < index; i++)
                Console.Write(" " + v[i]);
            Console.WriteLine();
        }
    }
    internal class _5_13_StructImpApp
    {
        public static void Main()
        {
            Vector a = new Vector(100); // 구조체 생성(스택 영역)
            int n;
            while (true)
            {
                n = Console.Read() - '0';
                if (n == 0) break;
                a.Insert(n);
            }
            a.PrintVector();
            a.ScalarSum(10); // 배열의 각 원소에 10 더함
            a.PrintVector();
        }
    }
}
*/