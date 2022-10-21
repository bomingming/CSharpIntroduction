using System;
using Shape;

public class NamespaceApp
{
    public static void Main()
    {
        Rectangle rect = new Rectangle();
        rect.width = 10;
        rect.height = 20;
        Console.WriteLine("rect : " + rect);
    }
}