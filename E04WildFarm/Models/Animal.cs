using System;
using System.Collections.Generic;
using System.Text;

namespace E04WildFarm
{
    public abstract class Animal : IAnimal
    {
        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            
        }

        public string Name {get;}

        public double Weight { get; protected set; }

        public int FoodEaten { get; protected set; }

        public abstract void Eat(IFood food);     

        public abstract string ProduceSound();

        protected void BaseEating( double modifier, int qty)
        {
            this.Weight += qty * modifier;
            this.FoodEaten += qty;
        }
            
    }
}
