using System;
using System.Collections.Generic;
using System.Text;

namespace E04WildFarm
{
    public class Mouse : Mammal
    {
        private const double Modifier = 0.10;
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }
        public override string ProduceSound()
            => "Squeak";
        public override void Eat(IFood food)
        {
            if (food is Vegetable || food is Fruit)
            {
                BaseEating(Modifier, food.Quantity);


            }
            else
            {
                Exceptions.InvalidFoodException(this.GetType().Name, food.GetType().Name);

            }
        }

        public override string ToString()
            => $"{this.GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}
