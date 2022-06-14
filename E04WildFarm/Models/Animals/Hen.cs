using System;
using System.Collections.Generic;
using System.Text;

namespace E04WildFarm
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override string ProduceSound()
        => "Cluck";
    }
}
