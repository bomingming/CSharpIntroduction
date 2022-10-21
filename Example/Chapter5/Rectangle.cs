using System;

namespace Shape
{
   public class Rectangle
    {
        public int height;
        public int width;
        public override string ToString()
        {
            return String.Format("Width: {0}, Height: {1}", width, height); 
        }
    }
}
