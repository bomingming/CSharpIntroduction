/*using System;

namespace Problem.Chapter4
{
    public class Color
    {
        public const int FULL = 0xFF; // constant 멤버. 컴파일 시 초기화
        public const int EMPTY = 0x00; // constant 멤버. 컴파일 시 초기화
        private byte red, green, blue;

        public static readonly Color Red = new Color(FULL, EMPTY, EMPTY);
        public static readonly Color Green = new Color(EMPTY, FULL, EMPTY);
        public static readonly Color Blue = new Color(EMPTY, EMPTY, FULL);
        public Color(byte r, byte g, byte b)
        {
            red = r;
            green = g;
            blue = b;
        }
        public static void PrintColor(Color c)
        {
            Console.WriteLine("red value={0}, green value={1}, blue value={2}",
                c.red, c.green, c.blue);
        }
    }
    internal class _4_3_ConstVsReadOnlyApp
    {
        public static void Main()
        {
            Console.WriteLine("FULL = " + Color.FULL);
            Color.PrintColor(Color.Red);
        }
    }
}
*/