/*using System;

namespace Problem.Chapter4
{
    internal class Lesson_41
    {

        static void Main(string[] args)
        {
            int[] val = new int[] { 100, 200, 300 }; // 배열 선언 및 초기화
            // 배열의 주소를 넘김 : 배열 이름 -> 참조형 변수
            Push10(val); // 배열 이름 : 참조형

            Console.WriteLine("Val={0}:{1} :{2}", val[0], val[1], val[2]);

            Push100(ref val[1]); // 배열 요소 1개 : 값형

            Console.WriteLine("Val[1]={0}", val[1]);
        }
        static void Push10(int[] val) // 배열이 인자 (배열 이름 : 참조 변수)
        {
            for (int i = 0; i < 3; i++)
                val[i] += 10;
        }
        static void Push100(ref int val) // 배열 요소가 인자(ref 필요)
        {
            val += 100;
        }

    }
    
}
*/