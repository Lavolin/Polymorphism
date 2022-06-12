using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public interface IRobotCleaner
    {
        virtual void RobotClean()
        {
            Console.WriteLine("gaz");
        }
    }
}
