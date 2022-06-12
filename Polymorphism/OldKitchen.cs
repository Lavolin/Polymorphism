using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class OldKitchen : Kitchen
    {
        public override void CleanKitchen()
        {
            Console.WriteLine("Old Kitchen: Izhvarli vsichko i izgoni kotkata");
        }

        public override void CookMeat()
        {
            Console.WriteLine("Old Kitchen: izpechi prase na oganya");

        }

        public override void CookVegetarian()
        {
            Console.WriteLine("Old Kitchen: takova ne gotvya");

        }
    }
}
