/*using System;

namespace Problem.Chapter4
{
    internal class _4_15_RWOnlyPropertyApp
    {
        private int readOnlyField = 100;
        private int writeOnlyField;
        public int ReadOnlyProperty
        {
            get
            {
                Console.WriteLine("In the ReadOnlyProperty...");
                return readOnlyField;
            }
        }
        public int WriteOnlyProperty
        {
            set
            {
                Console.WriteLine("In the WriteOnlyProperty...");
                writeOnlyField = value;
            }
        }
        public static void Main()
        {
            _4_15_RWOnlyPropertyApp obj = new _4_15_RWOnlyPropertyApp();
            obj.WriteOnlyProperty = obj.ReadOnlyProperty;
            Console.WriteLine("value = " + obj.writeOnlyField);
        }
    }
}
*/