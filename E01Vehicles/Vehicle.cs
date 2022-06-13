namespace E01Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumptionPerKm)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public double FuelQuantity { get; set; }

        public virtual double FuelConsumptionPerKm { get; set; }

        public bool CanDrive (double km)
            => this.FuelQuantity - (this.FuelConsumptionPerKm * km) >= 0;
        

        public void Drive(double km)
        {
            if (CanDrive(km))
            {
                this.FuelQuantity -= (this.FuelConsumptionPerKm * km);
            }
        }

        public virtual void Refuel (double amount)
        {
            this.FuelQuantity += amount;
        }
    }
}
