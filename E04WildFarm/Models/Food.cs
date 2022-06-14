using System;
using System.Collections.Generic;
using System.Text;

namespace E04WildFarm
{
    public abstract class Food : IFood
    {
        protected Food(int quantity)
        {
            Quantity = quantity;
        }

        public int Quantity {get; }
    }
}
