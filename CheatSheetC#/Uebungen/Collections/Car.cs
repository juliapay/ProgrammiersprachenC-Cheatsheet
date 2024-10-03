
namespace Collections
{

    internal class Car : Vehicle, IMaintenance
    {
        private static int _count;

        private double _fuelInTank;


        public double FuelEfficiency { get; init; }


        public Car(string colour, int maxSpeed, string model, double fuelEfficiency, VehicleType type) : base(maxSpeed, model, colour, type)
        {
            Colour = colour;
            MaxSpeed = maxSpeed;
            Model = model;
            FuelEfficiency = fuelEfficiency;
            _count++;
        }

        public Car(string colour, string model) : this(colour, 150, model, 5, VehicleType.Sedan)
        {
        }

        public Car(int maxSpeed, double fuelEfficiency) : this("Unknown", maxSpeed, "Standard", fuelEfficiency, VehicleType.Sedan)
        {

        }

        public Car() : this("Red", 180, "Alpha", 4.5, VehicleType.Sedan)
        {
        }


        public override void Drive(int distance)
        {
            base.Drive(distance);
            Console.WriteLine($"The fuel consumption was {(FuelEfficiency * distance) / 100} liters.");
        }


        public void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }


        public double GetFuelLevel(out double maxDistance)
        {
            maxDistance = _fuelInTank * FuelEfficiency;
            return _fuelInTank;
        }

        public int GetCount() => _count;

        public override void Refuel(double amount)
        {
            _fuelInTank += amount;
            Console.WriteLine($"The  car has been refueld by {amount} liters. Current fuel level is: {_fuelInTank} liters.");
        }

        public void ReplaceFuelFilter()
        {
            Console.WriteLine("Fuel filter has been replaced in the car.");
        }

        public void ServiceCar()
        {
            ReplaceFuelFilter();
            CheckBrakes();
            //maybe do some other stuff
        }
    }


}
