namespace CheatSheetC_.Uebungen.Exceptions
{
    internal class ElectricCar : Vehicle, IMaintainance
    {
        public double BatteryCapacity { get; set; }

        public double EnergyConsumption { get; set; }
        private double _batteryLevel { get; set; }


        public ElectricCar(string color, string model, int maxSpeed, double batteryCapacity, double energyConsumption)
            : base(color, model, maxSpeed)
        {
            Color = color;
            Model = model;
            MaxSpeed = maxSpeed;
            BatteryCapacity = batteryCapacity;
            EnergyConsumption = energyConsumption;

        }

        public ElectricCar(string color, string model, int maxSpeed)
            : this(color, model, maxSpeed, 75.0, 15.0) // Standardwerte: 75 kWh, 15 kWh/100km
        {
            // Hier keine weiteren Zuweisungen nötig, da der andere Konstruktor aufgerufen wird
        }
        public override void Drive(int distance)
        {
            base.Drive(distance);
            Console.WriteLine($"The EnergyConsumption is{(EnergyConsumption * distance) / 100}");
        }


        public override void Refuel(double amount)
        {
            _batteryLevel += (double)amount;
        }

        public void CheckBatteryHealth()
        {
            Console.WriteLine("Battery health checked for the electric car.");
        }

        public ElectricCar()
        {
        }
        public void ServicCar()
        {

        }
    }
}
