namespace Collections
{
    internal abstract class Vehicle
    {
        private int _maxSpeed;
        public int MaxSpeed
        {
            get { return _maxSpeed; }
            set
            {
                if (value <= 300)
                    _maxSpeed = value;
                else
                    throw new SpeedLimitExceededException("The maximum speed may not exceed 300 km/h.");
            }
        }

        public string Model { get; init; }

        public string Colour { get; set; }

        public VehicleType Type { get; init; }

        public Vehicle(int maxSpeed, string model, string colour, VehicleType type = VehicleType.Sedan)
        {
            MaxSpeed = maxSpeed;
            Model = model;
            Colour = colour;
            Type = type;
        }

        protected Vehicle()
        {
        }

        public virtual void Drive(int distance)
        {
            if(distance < 0)
            {
                throw new ArgumentException("The distance may not be negative");
            }
            Console.WriteLine($"The {Colour} {Model} has driven {distance} km.");
        }

        public virtual void Drive(int distance, int speed)
        {
            Console.WriteLine($"The {Colour} {Model} car has driven {distance} at the average speed of {speed} km.");
        }

        public abstract void Refuel(double amount);

        public static bool IsFaster(Vehicle vehicle1, Vehicle vehicle2)
        {
            return vehicle1.MaxSpeed > vehicle2.MaxSpeed;
        }

        public void DescribeVehicle()
        {
            switch (Type)
            {
                case VehicleType.Sedan:
                    Console.WriteLine("This is a Sedan.");
                    break;
                case VehicleType.SUV:
                    Console.WriteLine("This is an SUV.");
                    break;
                case VehicleType.Truck:
                    Console.WriteLine("This is a Truck.");
                    break;
                default:
                    Console.WriteLine("This is a vehicle.");
                    break;
            }
        }

        public void CheckBrakes()
        {
            Console.WriteLine("The brakes are in good condition.");
        }
    }


}
