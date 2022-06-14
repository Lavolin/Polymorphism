using System;
using System.Collections.Generic;
using System.Text;

namespace E04WildFarm
{
    public class Cat : Feline
    {
        private const double Modifier = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override string ProduceSound()
            => "Meow";

        public override void Eat(IFood food)
        {
            if (food is Vegetable || food is Meat)
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
