using System;
using System.Collections.Generic;
using System.Text;

namespace E04WildFarm
{
    public static class Exceptions
    {
        public static void InvalidFoodException(string animalType, string foodType)
        {
            throw new ArgumentException
                    ($"{animalType} does not eat {foodType}!");
        }
    }
}
