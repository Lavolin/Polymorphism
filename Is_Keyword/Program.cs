using System;

namespace Is_Keyword
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape shape;
            if (new Random().Next()% 2 == 0)
            {
                shape = new Circle();
            }
            else
            {
                shape = new Rectangle();
            }

            shape.Draw();

            if (shape is Circle)
            {
                //Circle circle = (Circle)shape;
                //int radius = circle.Radius;

                int radius = ((Circle)shape).Radius;

                Console.WriteLine($"Radius: {radius}");
            }
        }
    }
}
