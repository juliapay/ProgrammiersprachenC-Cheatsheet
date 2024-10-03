using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CheatSheetC_.Uebungen.Vererbung
{
    internal abstract class Vehicle
    {
        public string Color { get; set; }
        public string Model { get; init; }
        private int _maxSpeed;
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
                    Console.WriteLine("Die Geschwindigkeit darf 300 nicht überschreiten");
                }
            }
        }

        public virtual void Drive(int distance, int speed)
        {
            Console.WriteLine($"The car has not driven {distance} at the average speed of {speed} km.");
        }
        //Ändere die Methode Drive in der Klasse Vehicle,
        //sodass sie die Information über das Modell und die Farbe ausgibt.


        public virtual void Drive(int distance)
        {
            Console.WriteLine($"The {Model} has the color {Color}");
        }

        //Füge in der Basisklasse Vehicle einen Konstruktor hinzu, 
        //der nur MaxSpeed, Model und Colour als Parameter übernimmt.
        public Vehicle(string color, string model, int maxSpeed)
        {
            Color = color;
            Model = model;
            _maxSpeed = maxSpeed;
        }

        protected Vehicle()
        {
        }


        //Füge der Klasse Vehicle eine abstrakte Methode Refuel(double amount)
        //hinzu, die in abgeleiteten Klassen implementiert werden muss.

        public abstract void Refuel(double amount);


//*****************************  07  ************************************
        //Erweitere die Klasse Vehicle um die statische Methode
        //IsFaster(Vehicle vehicle1, Vehicle vehicle2), die true
        //zurückgibt, wenn vehicle1 schneller ist als vehicle2.

        public static bool IsFaster(Vehicle vehicle, Vehicle vehicle1)
        {
            return vehicle.MaxSpeed >vehicle1.MaxSpeed;
        }

        //*****************************  08  ************************************
        //Erweitere die Klasse Vehicle um eine Methode CheckBrakes(),
        //die eine Meldung ausgibt, dass die Bremsen überprüft wurden.

        public void CheckBrakes()
        {
            Console.WriteLine("The brakes were checked.");
        }
    }
}
