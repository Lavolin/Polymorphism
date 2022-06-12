using System;
using System.Collections.Generic;
using System.Text;

namespace Is_Keyword
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public override void Draw()
        {
            Console.WriteLine("Circle draw");
        }
    }
}
