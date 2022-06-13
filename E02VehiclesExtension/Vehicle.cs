using System;

namespace E02VehiclesExtension
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        protected Vehicle(double tankCapacity, double fuelQuantity, double fuelConsumptionPerKm)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public double FuelQuantity
        {
            get => fuelQuantity;
            private set
            {
                if (value > this.TankCapacity)
                {
                    fuelQuantity = 0;
                }
                else
                {

                    fuelQuantity = value;
                }
            }
        }
        public virtual double FuelConsumptionPerKm { get; protected set; }

        public double TankCapacity { get; }


        public bool CanDrive(double km)
            => this.FuelQuantity - (this.FuelConsumptionPerKm * km) >= 0;

        public bool CanRefuel(double amount)
             => this.FuelQuantity + amount <= this.TankCapacity;
        public void Drive(double km)
        {
            if (CanDrive(km))
            {
                this.FuelQuantity -= (this.FuelConsumptionPerKm * km);
            }
        }

        public virtual void Refuel(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (CanRefuel(amount))
            {
                this.FuelQuantity += amount;

            }
        }
    }
}
