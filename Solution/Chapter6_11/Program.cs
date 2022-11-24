using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_11
{
    class gSwap<T>
    {
        public T x, y;
        public void swap()
        {
            T temp;
            temp = x; x = y; y = temp;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            gSwap<int> i = new gSwap<int>();
            i.x = 1; i.y = 2;
            Console.WriteLine("x: " + i.x + " y: " + i.y);
            i.swap();
            Console.WriteLine("x: " + i.x + " y: " + i.y);
            gSwap<double> d = new gSwap<double>();
            d.x = 1.0; d.y = 2.0;
            Console.WriteLine("x: " + d.x + " y: " + d.y);
            d.swap();
            Console.WriteLine("x: " + d.x + " y: " + d.y);
        }
    }
}
