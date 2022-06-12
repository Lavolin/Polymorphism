using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class ModernKitchen : Kitchen
    {
        public override void CleanKitchen()
        {
            Console.WriteLine("Modern Kitchen: izvikai metachite");
        }

        public override void CookMeat()
        {
            Console.WriteLine("Modern Kitchen: padpadaci na tigan");

        }

        public override void CookVegetarian()
        {
            Console.WriteLine("Modern Kitchen: za tebe vinagi");

        }

        public override void CookSalad()
        {
            Console.WriteLine("Gotvya gurme salata");
        }

        public void RobotClean()
        {
            Console.WriteLine("Modern Kitchen: E gi robotite chistqt");
        }
    }
}
