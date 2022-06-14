using System;
using System.Collections.Generic;
using System.Text;

namespace E04WildFarm
{
    public class Owl : Bird
    {
        private const double Modifier = 0.25;
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }
        public override string ProduceSound()
        => "Hoot Hoot";


        public override void Eat(IFood food)
        {
            if (food is Meat)
            {
                BaseEating(Modifier, food.Quantity);


            }
            else
            {
                Exceptions.InvalidFoodException(this.GetType().Name, food.GetType().Name);

            }
        }

    }
}
