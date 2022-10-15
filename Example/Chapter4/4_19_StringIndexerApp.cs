/*using System;

namespace Problem.Chapter4
{
    // 배열의 인덱서로 서로 다른 자료형을 갖는 다차원 배열 형식을 인덱서로 정의하여 사용
    // 인덱서와 대응하는 필드 배열이 없는 경우에 가능
    class StringIndexer
    {
        public char this[string str, int index]
        {
            get { return str[index]; } // 문자열 내 특정 위치 글자 반환
        }
        public string this[string str, int index, int len]
        {
            get { return str.Substring(index, len); } // 문자열 내 특정 위치에서 임의의 개수 글자 반환
        }
    }
    internal class _4_19_StringIndexerApp
    {
        public static void Main()
        {
            string str = "Hello";
            StringIndexer s = new StringIndexer();
            for (int i = 0; i < str.Length; i++)
                Console.WriteLine("{0}[{1}] = {2}", str, i, s[str, i]); // s : 객체에 대한 참조 변수(객체명), str의 i번째 문자 반환
            Console.WriteLine("Substring of {0} is {1}", str, s[str, 2, 3]);
        }
    }
}
*/