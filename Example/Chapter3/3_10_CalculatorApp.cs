/*using System;

namespace Problem.Chapter3
{
    internal class _3_10_CalculatorApp
    {
        public static void Main()
        {
            int x, y, r = 0;
            char opr;
            Console.WriteLine("Enter an operator & two numbers = "); // 공백 없이 입력해야함
            opr = (char)Console.Read();
            x = Console.Read() - '0';
            y = Console.Read() - '0';
            switch (opr)
            {
                case '+': r = x + y;
                    Console.WriteLine(x + " + " + y + " = " + r); break;
                case '-': r = x - y;
                    Console.WriteLine(x + " - " + y + " = " + r); break;
                case '*': r = x * y;
                    Console.WriteLine(x + " * " + y + " = " + r); break;
                case '/': r = x / y;
                    Console.WriteLine(x + " / " + y + " = " + r); break;
                default: Console.WriteLine("Illegal operator");
                    break;
            }
        }
    }
}
*/