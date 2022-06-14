using System;
using System.Collections.Generic;
using System.Text;

namespace E04WildFarm
{
    public static class FoodFactory
    {
        public static IFood CreateFood(string[] foodInfo)
        {
            IFood food = null;
            string foodName = foodInfo[0];
            int qty = int.Parse(foodInfo[1]);

            if (foodName == "Vegetable")
            {
                food = new Vegetable(qty);
            }
            else if (foodName == "Fruit")
            {
                food = new Fruit(qty);

            }
            else if (foodName == "Meat")
            {
                food = new Meat(qty);

            }
            else if (foodName == "Seeds")
            {
                food = new Seeds(qty);

            }
            return food;
        }
    }
}
