using System;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RobotKitchen robotKitchen = new RobotKitchen();
            IRobotCleaner robotCleaner = robotKitchen;
            Kitchen baseKitchen = robotKitchen;
            

            Console.WriteLine("What kitchen do you want to use");
            string typeOfKitchen = Console.ReadLine();

            Kitchen kitchen = null;

            if (typeOfKitchen == "old")
            {
                kitchen = new OldKitchen();
            }
            else if (typeOfKitchen == "normal")
            {
                kitchen = new NormalKitchen();

            }
            else if (typeOfKitchen == "modern")
            {
                kitchen = new ModernKitchen();

            }
            else if (typeOfKitchen == "robot")
            {
                kitchen = new RobotKitchen();

            }

            while (true)
            {
                Console.WriteLine("What is your order");

                var order = Console.ReadLine();

                if (order == "meat")
                {
                    kitchen.CookMeat();
                }
                if (order == "salad")
                {
                    kitchen.CookSalad();
                }
                if (order == "veggie")
                {
                    kitchen.CookVegetarian();
                }
                if (order == "clean")
                {
                    kitchen.CleanKitchen();
                }

                if (order == "robot clean")
                {
                    if (kitchen is RobotKitchen)
                    {
                        ((RobotKitchen)kitchen).RobotClean();
                    }
                    else
                    {
                        Console.WriteLine("Kuhniata ti e stara");
                    }
                }
                if (order == "change kitchen")
                {
                    //TODO: change ;
                }
            }
        }
    }
}
