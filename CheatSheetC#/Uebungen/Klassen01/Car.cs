using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

namespace CheatSheetC_.Uebungen.Klassen01
{
    internal class Car
    {
        public string Color { get; set; }
        public string Model { get; init; }
        private double _fuelInTank { get; set; }
        public double FuelEfficiency { get; init; }

        //Füge eine öffentliche Eigenschaft MaxSpeed hinzu,
        //die den Zugriff auf das Feld ermöglicht,
        //aber sicherstellt, dass der Wert 300 km/h nicht überschreiten kann.
        private int _maxSpeed
        {
            get { return _maxSpeed; }

            set
            {
                if (value <= 300)
                {
                    _maxSpeed = value;
                }
                else
                {
                    Console.WriteLine("Die Geschwindigkeit darf 300 nicht überschreiten");
                }
            }
        }
        //Füge dann folgende Methoden hinzu: 
        //StartEngine, Drive, GetFuelLevel
        public void SartEngine()
        {
            Console.WriteLine("Engine started.");
        }
        //Überlade die Methode Drive, 
        //sodass sie auch die Geschwindigkeit 
        //als Parameter aufnehmen kann.
        public void Drive(int distance, int speed)
        {
            Console.WriteLine($"The car has not driven {distance} at the average speed of {speed} km.");
        }
        // Konstruktorüberladung einfach
        //public void Drive(int distance)
        //{
        //    Console.WriteLine($"The car has not driven {distance} km.");
        //}
        public override void Drive(int distance)
        {
            base.Drive(distance);
            double fuelconsumption =FuelEfficiency*
            Console.WriteLine($"The car has a  fuel consumption of{});
        }
        //F
        // Erweitere die Methode GetFuelLevel mit einem 
        // out double maxDistance Parameter.
        // Berechne die maximale Strecke, die das Auto 
        //mit dem aktuellen Kraftstoffstand fahren kann.
        public double GetFuelLevel(out double maxDistance)
        {
            maxDistance = _fuelInTank * FuelEfficiency;
            return _fuelInTank;
        }

        //Erstelle einen Konstruktor für die Klasse Car, 
        //der Parameter color, maxSpeed, 
        //model und fuelEfficieny akzeptiert

        public Car(string color, string model, double fuelEfficiency, int maxSpeed)
        {
            Color = color;
            Model = model;
            FuelEfficiency = fuelEfficiency;
            _maxSpeed = maxSpeed;
            //verfolgt die Anzahl der erstellten Car - Objekte 
            _carCount++;

        }
        //Erstelle mehrere Konstruktorversionen 
        //für die Klasse Car, die 
        //unterschiedliche Parameter akzeptieren.
        public Car(string colour, string model) : this(colour, model, 1.5, 250)
        {
        }
        public Car(int maxSpeed, double fuelEfficiency) : this("Unknown", "Standard", fuelEfficiency, maxSpeed)
        {
        }
        // Füge ein statisches Feld int _carCount hinzu, 
        //das die Gesamtanzahl der erstellten Car-Objekte verfolgt.
        // Erstelle eine statische Methode GetCarCount(), die die 
        // Anzahl der erstellten Autos zurückgibt.
        private static int _carCount;
        public int GetCount()
        {
            return _carCount;
        }
    }
    }
