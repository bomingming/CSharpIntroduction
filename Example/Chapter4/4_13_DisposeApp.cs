/*using System;

namespace Problem.Chapter4
{
    class DisposeClass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("In the Dispose...");
            GC.SuppressFinalize(this);
        }
    }
    internal class _4_13_DisposeApp
    {
        public static void Main()
        {
            Console.WriteLine("Start of Main");
                using(DisposeClass obj = new DisposeClass())
            {
                
            }
            Console.WriteLine("End of Main");
        }
    }
}
*/