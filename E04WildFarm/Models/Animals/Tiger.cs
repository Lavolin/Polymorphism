using System;
using System.Collections.Generic;
using System.Text;

namespace E04WildFarm
{
    public class Tiger : Feline
    {
        private const double Modifier = 1.00;
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }
        public override string ProduceSound()
         => "ROAR!!!";

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
