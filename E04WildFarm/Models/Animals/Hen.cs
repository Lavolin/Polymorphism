using System;
using System.Collections.Generic;
using System.Text;

namespace E04WildFarm
{
    public class Hen : Bird
    {
        private const double Modifier = 0.35;
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        

        public override string ProduceSound()
        => "Cluck";

        public override void Eat(IFood food)
        {
            BaseEating(Modifier, food.Quantity);


        }
    }
}
