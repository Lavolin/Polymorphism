using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class RobotKitchen : ModernKitchen, IRobotCleaner
    {
        public override void CookMeat()
        {
            Console.WriteLine("Robot Kitchen: robot i stridi");
        }

        public override void CookSalad()
        {
            Console.WriteLine("Robot Kitchen: na ti robot sas salata");
        }

      
    }
}
