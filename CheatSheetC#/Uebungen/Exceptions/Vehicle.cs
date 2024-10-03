using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CheatSheetC_.Uebungen.Exceptions
{
    internal abstract class Vehicle
    {
        public string Color { get; set; }
        public string Model { get; init; }
        private int _maxSpeed;

 //***********************   03   ****************************************

        //Ändern Sie den Setter der MaxSpeed-Eigenschaft in der
        //Vehicle-Klasse so, dass anstelle einer Konsolenausgabe
        //eine SpeedLimitExceededException geworfen wird, wenn die
        //Geschwindigkeit größer als 300 km/h ist. Die geworfene Ausnahme
        //sollte eine entsprechende Fehlermeldung enthalten.
        public int MaxSpeed
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
                    throw new SpeedLimitExceptions("The maximum speed is 300");
                }
            }
        }

        public virtual void Drive(int distance, int speed)
        {
            Console.WriteLine($"The car has not driven {distance} at the average speed of {speed} km.");
        }
//***********************   02   ****************************************

        //Ändern Sie die Drive-Methode der Klasse Vehicle so,
        //dass sie eine ArgumentException
        //wirft, wenn die übergebene Distanz negativ ist.
        //Die geworfene Exception sollte die Fehlermeldung
        //enthalten, dass die Distanz nicht negativ sein darf.

        public virtual void Drive(int distance)
        {
            if( distance < 0)
            {
                throw new ArgumentException("The distance cannot be negative");
            }
            Console.WriteLine($"The {Color} {Model} has driven {distance} km.");
        }

        public Vehicle(string color, string model, int maxSpeed)
        {
            Color = color;
            Model = model;
            _maxSpeed = maxSpeed;
        }

        protected Vehicle()
        {
        }

        public abstract void Refuel(double amount);

        public static bool IsFaster(Vehicle vehicle, Vehicle vehicle1)
        {
            return vehicle.MaxSpeed >vehicle1.MaxSpeed;
        }

        public void CheckBrakes()
        {
            Console.WriteLine("The brakes were checked.");
        }
    }
}
