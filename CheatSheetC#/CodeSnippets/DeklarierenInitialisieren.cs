using CheatSheetC_.Uebungen.TodoUebung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo;

namespace CheatSheetC_.CodeSnippets
{
    internal class DeklarierenInitialisieren
    {

        //++++++++++       DICTIONARY
        public void InitialisierungDictionary()
        {
            Dictionary<string, Vehicle> vehicles = new Dictionary<string, Vehicle>();

            vehicles.Add("Alpha", new Car("Rot", 150, "Alpha", 6.5, VehicleType.SUV));
            vehicles.Add("Tesla", new ElectricCar("Blau", 120, "Tesla", 85, 20, VehicleType.Truck));
        }
        //+++++++++         LIST 

        public void InitialisierungListe()
        {

            List<Task> privateTask = new List<Task>();
            privateTask.Add(new Task("shopping"));
            privateTask.Add(new Task("learning"));
            privateTask.Add(new Task("cleaning"));
            privateTask.Add(new Task("feeding cats"));
            privateTask.Add(new Task("cooking"));
            PrivateTasks privateTasks = new PrivateTasks(privateTask);

            PrivateTaskManager privateTasks = new PrivateTaskManager(new List<Task>()
            {
                new Task("Wash the dishes"),
                new Task("Clean the windows"),
                new Task("Write a letter"),
                new Task("Read a book"),
                new Task("Go for a walk")
            });

        }
        public void InitialisierungArray()
        {
            string[] weekdays = 
            { 
                "Monday", 
                "Tuesday", 
                "Wednesday", 
                "Thrusday", 
                "Friday", 
                "Saturday", 
                "Sunday" 
            };
        }

    }
}
