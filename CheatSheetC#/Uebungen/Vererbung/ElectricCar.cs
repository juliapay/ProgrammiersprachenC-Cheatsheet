namespace CheatSheetC_.Uebungen.Vererbung
{
    internal class ElectricCar : Vehicle, IMaintainance
    {
        public double BatteryCapacity { get; set; }

        public double EnergyConsumption { get; set; }
        private double _batteryLevel { get; set; }

        // SO WENN BASECLASS KEINEN KONSTRUKTOR HAT

        //public ElectricCar(string color, string model, int maxSpeed,double batteryCapacity)
        //{
        //    Color = color;
        //    Model = model;
        //    MaxSpeed = maxSpeed;
        //    BatteryCapacity = batteryCapacity;
        //}

        // SO WENN BASECLASS EINEN KONSTRUKTOR HAT

        //Füge in der Basisklasse Vehicle einen Konstruktor hinzu,
        //der nur MaxSpeed, Model und Colour als Parameter übernimmt.

        public ElectricCar(string color, string model, int maxSpeed, double batteryCapacity, double energyConsumption)
            : base(color, model, maxSpeed)
        {
            Color = color;
            Model = model;
            MaxSpeed = maxSpeed;
            BatteryCapacity = batteryCapacity;
            EnergyConsumption = energyConsumption;

        }
        //Implementiere eine Konstruktorverkettung in ElectricCar, 
        //bei der ein Konstruktor ohne batteryCapacity und energyConsumption 
        //Parameter einen Standardwert für die Akkukapazität verwendet 
        //und dabei den anderen Konstruktor aufruft.

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

        //Erweitere die Klasse ElectricCar um die Eigenschaft BatteryLevel.
        //Implementiere die Methode Refuel in der Klasse ElectricCar,
        //sodass sie den Ladezustand der Batterie um den gegebenen
        //Betrag (kWh) erhöht. Gib den aktuellen Ladezustand auf der
        //Konsole aus.


        public override void Refuel(double amount)
        {
            _batteryLevel += (double)amount;
        }
        //Erweitere die Klasse ElectricCar um die Methode CheckBatteryHealth(),
        //die eine Meldung ausgibt, dass die Batterie überprüft wurde.

        public void CheckBatteryHealth()
        {
            Console.WriteLine("Battery health checked for the electric car.");
        }

        public ElectricCar()
        {
        }
        public void ServicCar()
        {
            CheckBatteryHealth();
            CheckBrakes();
        }
    }
}
