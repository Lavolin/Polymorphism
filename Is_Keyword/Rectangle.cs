using System;
using System.Collections.Generic;
using System.Text;

namespace Is_Keyword
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public override void Draw()
        {
            Console.WriteLine("Rectangle draw");
        }
    }
}
