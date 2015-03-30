// Problem 1. Shapes
// Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
// Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure 
// (height * width for rectangle and height * width/2 for triangle).
// Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement 
// the CalculateSurface() method.
// Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, 
// Triangle) stored in an array.

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
