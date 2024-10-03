namespace Enums
{
    internal class ElectricCar : Vehicle, IMaintenance
    {
        private double _batteryLevel { get; set; }
        public double BatteryCapacity { get; init; } //kwh
        public double EnergyConsumption { get; init; } //kwh/100km

        public ElectricCar(string colour, int maxSpeed, string model, double batteryCapacity, double energyConsumption, VehicleType type) : base(maxSpeed, model, colour, type)
        {
            Colour = colour;
            MaxSpeed = maxSpeed;
            Model = model;
            BatteryCapacity = batteryCapacity;
            EnergyConsumption = energyConsumption;
        }

        public ElectricCar(string colour, int maxSpeed, string model)
            : this(colour, maxSpeed, model, 80, 75, VehicleType.Sedan)
        { }

        public override void Drive(int distance)
        {
            base.Drive(distance);
            Console.WriteLine($"The energy consumption was {(EnergyConsumption * distance) / 100} kWh/km.");
        }

        public override void Refuel(double amount)
        {
            _batteryLevel += amount;
            Console.WriteLine($"The electric car has been charged by {amount} kWh. Current battery level: {_batteryLevel} kWh.");
        }

        public void CheckBatteryHealth()
        {
            Console.WriteLine("Battery health checked for the electric car.");
        }

        public void ServiceCar()
        {
            CheckBatteryHealth();
            CheckBrakes();
            //maybe do some other stuff
        }
    }
}
