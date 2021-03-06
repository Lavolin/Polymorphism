using System;
using System.Collections.Generic;
using System.Text;

namespace E04WildFarm
{
    public class Dog : Mammal
    {
        private const double Modifier = 0.40;
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }


        public override string ProduceSound()
            => "Woof!";
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

        public override string ToString()
            => $"{this.GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}
