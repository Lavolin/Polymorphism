using System;

namespace E02VehiclesExtension
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();
            string[] busInfo = Console.ReadLine().Split();

            double carFuelQty = double.Parse(carInfo[1]);
            double carLtPerKm = double.Parse(carInfo[2]);
            double carTankCapacity = double.Parse(carInfo[3]);

            double truckFuelQty = double.Parse(truckInfo[1]);
            double truckLtPerKm = double.Parse(truckInfo[2]);
            double truckTankCapacity = double.Parse(truckInfo[3]);

            double busFuelQty = double.Parse(busInfo[1]);
            double busLtPerKm = double.Parse(busInfo[2]);
            double busTankCapacity = double.Parse(busInfo[3]);

            Vehicle car = new Car(carTankCapacity, carFuelQty, carLtPerKm);
            Vehicle truck = new Truck(truckTankCapacity, truckFuelQty, truckLtPerKm);
            Vehicle bus = new Bus(busTankCapacity, busFuelQty, busLtPerKm);


            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                try
                {
                    string[] cmd = Console.ReadLine().Split();
                    string typeOfCommand = cmd[0];
                    string typeOfVehicle = cmd[1];
                    double value = double.Parse(cmd[2]);

                    Vehicle vehicle = GetVehickle(car, truck, bus, typeOfVehicle);

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
                    else if (typeOfCommand == "DriveEmpty")
                    {
                        bus.IsEmpty = true;
                        if (bus.CanDrive(value))
                        {
                            bus.Drive(value);
                            Console.WriteLine($"{typeOfVehicle} travelled {value} km");
                        }
                        else
                        {
                            Console.WriteLine($"{typeOfVehicle} needs refueling");
                        }
                        bus.IsEmpty = false;
                    }
                    else
                    {
                        if (vehicle.CanRefuel(value))
                        {
                        vehicle.Refuel(value);

                        }
                        else
                        {
                            Console.WriteLine($"Cannot fit {value} fuel in the tank");
                        }
                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }

        private static Vehicle GetVehickle
            (Vehicle car, Vehicle truck, Vehicle bus, string typeOfVehicle)
        {

            if (typeOfVehicle == "Truck")
            {
                return truck;
            }
            else if (typeOfVehicle == "Car")
            {
                return car;
            }

            return bus;
        }
    }
}
