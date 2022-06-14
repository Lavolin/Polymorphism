using System;
using System.Collections.Generic;

namespace E04WildFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                try
                {
                    string[] animalInfo = input.Split();

                    string[] foodInfo = Console.ReadLine().Split();

                    IAnimal animal = AnimalFactory.CreateAnimal(animalInfo);
                    IFood food = FoodFactory.CreateFood(foodInfo);

                    Console.WriteLine(animal.ProduceSound());

                    animals.Add(animal);

                    animal.Eat(food);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
