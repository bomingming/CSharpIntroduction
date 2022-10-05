/*using System;

namespace Problem.Chapter3
{
    internal class _3_19_OverflowApp
    {
        public static void Main()
        {
            int i, max = int.MaxValue;
            try
            {
                Console.WriteLine("Start of try statement");
                i = max + 1; // 디폴트 : Overflow 체크하지 않음(무시)
                Console.WriteLine("After default overflow");
                unchecked
                {
                    i = max + 1;
                }
                Console.WriteLine("After unchecked statement");
                checked
                {
                    i = max + 1;
                }
                Console.WriteLine("After checked statement");
            }catch(OverflowException e)
            {
                Console.WriteLine("caught an OverflowException");
            }
        }
    }
}
*/