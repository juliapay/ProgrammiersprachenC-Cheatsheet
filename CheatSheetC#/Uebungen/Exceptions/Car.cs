using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CheatSheetC_.Uebungen.Exceptions
{
        internal class Car: Vehicle, IMaintainance
        {
            public string Color { get; set; }
            public string Model { get; init; }
            private double _fuelInTank { get; set; }
            public double FuelEfficiency { get; init; }

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

            public void SartEngine()
            {
                Console.WriteLine("Engine started.");
            }

            public void Drive(int distance, int speed)
            {
                Console.WriteLine($"The car has not driven {distance} at the average speed of {speed} km.");
            }

            public override void Drive(int distance)
            {
                base.Drive(distance);
            double fuelconsumption = FuelEfficiency * distance;
                Console.WriteLine($"The car has a  fuel consumption of{fuelconsumption}");
            }

            public double GetFuelLevel(out double maxDistance)
            {
                maxDistance = _fuelInTank * FuelEfficiency;
                return _fuelInTank;
            }


            public Car(string color, string model, double fuelEfficiency, int maxSpeed)
            {
                Color = color;
                Model = model;
                FuelEfficiency = fuelEfficiency;
                _maxSpeed = maxSpeed;
                //verfolgt die Anzahl der erstellten Car - Objekte 
                _carCount++;

            }

            public Car(string colour, string model) : this(colour, model, 1.5, 250)
            {
            }
            public Car(int maxSpeed, double fuelEfficiency) : this("Unknown", "Standard", fuelEfficiency, maxSpeed)
            {
            }

            private static int _carCount;
            public int GetCount()
            {
                return _carCount;
            }

        public override void Refuel(double amount)
        {
            _fuelInTank += amount;
            Console.WriteLine($"The Car has now {_fuelInTank} liter gas");
        }
 
        public void ReplaceFuelFilter()
        {
            Console.WriteLine("Fuel filter has been replaced in the car.");
        }

        public Car()
        {
        }
        public void ServicCar()
        {

        }

    }
    }

