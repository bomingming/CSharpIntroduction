/*using System;

namespace Problem.Chapter4
{
    class Color
    {
        private string[] color = new string[5]; // 문자 배열 형식의 필드
        public string this[int index]
        {
            get { return color[index]; } // Color 배열[i] 반환
            set { color[index] = value; } // Color 배열[i]에 저장
        }
    }
    internal class _4_18_IndexerApp
    {
        public static void Main()
        {
            Color c = new Color();
            c[0] = "WHITE"; // 인덱서를 사용하지 않을 경우 별도의 Setter 메소드 정의가 필요
            c[1] = "RED";
            c[2] = "YELLOW";
            c[3] = "BLUE";
            c[4] = "BLACK";
            for (int i = 0; i < 5; i++)
                Console.Write("Color is " + c[i]);
        }
    }
}
*/