using System;
using System.Collections.Generic;
using System.Text;

namespace E04WildFarm
{
    public abstract class Bird : Animal
    {
        public Bird(string name, double weight, double wingSize)
            : base(name, weight)
        {
            WingSize = wingSize;
        }

        public double WingSize { get; set; }

        public override string ToString()
            => $"{this.GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
    }
}
