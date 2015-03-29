namespace _01.Shapes
{
    using System;
    using System.Collections;

    public static class CalculateSurfaceTest
    {
        public static void Main()
        {
            Shape[] shapes = 
            {
                new Rectangle(3.15, 4.3),
                new Triangle(4, 5.6),
                new Square(7.16)
            };

            foreach (var item in shapes)
            {
                Console.WriteLine("Shape is {0}, surface is: {1}", item.GetType().Name, item.CalculateSurface());
            }
        }
    }
}
