using System;

namespace E01Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();

            double carFuelQty = double.Parse(carInfo[1]);
            double carLtPerKm = double.Parse(carInfo[2]);

            double truckFuelQty = double.Parse(truckInfo[1]);
            double truckLtPerKm = double.Parse(truckInfo[2]);

            Vehicle car = new Car(carFuelQty, carLtPerKm);
            Vehicle truck = new Truck(truckFuelQty, truckLtPerKm);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split();
                string typeOfCommand = cmd[0];
                string typeOfVehicle = cmd[1];
                double value = double.Parse(cmd[2]);

                Vehicle vehicle = null;
                if (typeOfVehicle == "Truck")
                {
                    vehicle = truck;
                }
                else
                {
                    vehicle = car;
                }

                if (typeOfCommand == "Drive")
                {
                    if (vehicle.CanDrive(value))
                    {
                        vehicle.Drive(value);
                        Console.WriteLine($"{typeOfVehicle} travelled {value} km");
                    }
                    else
                    {
                        Console.WriteLine($"{typeOfVehicle} needs refueling");
                    }
                }
                else
                {
                    
                    vehicle.Refuel(value);
                }

            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");

        }
    }
}
