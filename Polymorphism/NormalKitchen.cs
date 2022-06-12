using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class NormalKitchen : Kitchen
    {
        public override void CleanKitchen()
        {
            Console.WriteLine("Normal Kitchen: izmii sadovete");
        }

        public override void CookMeat()
        {
            Console.WriteLine("Normal Kitchen: sgotvi mesoto");

        }

        public override void CookVegetarian()
        {
            Console.WriteLine("Normal Kitchen: takova gotvya poniakoga");

        }
    }
}
