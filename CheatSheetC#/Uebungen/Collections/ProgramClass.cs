namespace Collections
{
    internal class ProgramClass
    {
        static void Task1()
        {
            //Erstelle eine List<Vehicle>, um eine Flotte von verschiedenen Fahrzeugen zu verwalten.
            //Füge verschiedene Fahrzeuge der Typen Car und ElectricCar zur Liste hinzu.
            //Implementiere eine Methode PrintFleetDetails(), die durch die Liste iteriert und
            //Details zu jedem Fahrzeug ausgibt, wie Modell,
            //Typ und Maximalgeschwindigkeit.

            List<Vehicle> list = new List<Vehicle>();

            list.Add(new Car("Rot", 150, "Alpha", 6.5, VehicleType.Cabriolet));
            list.Add(new ElectricCar("Blau", 120, "Tesla", 85, 20, VehicleType.Truck));

            void PrintfleetDetails(List<Vehicle> vehicles)
            {
                foreach (Vehicle vehicle in list)
                {
                    Console.WriteLine($"{vehicle.Model}, {vehicle.Colour}");
                }
            }

            //Implementieren Sie eine Methode, die alle Fahrzeuge eines bestimmten Typs
            //(Car oder ElectricCar) aus der Liste entfernt.

            void RemoveVehicleType<T>(List<Vehicle> vehicles) where T : Vehicle
            {
                for (int i = vehicles.Count - 1; i >= 0; i--)
                {
                    if (vehicles[i] is T)
                    {
                        vehicles.RemoveAt(i);
                    }
                }
            }
            //****************************+  02 *********************************
            //Erstellen Sie ein Dictionary, das Fahrzeugmodelle
            //als Schlüssel und die entsprechenden Fahrzeugobjekte
            //als Werte speichert.
            // Fügen Sie Fahrzeuge zum Dictionary hinzu, wobei der
            // Modellname als Schlüssel verwendet wird.

            Dictionary<string, Vehicle> vehicles = new Dictionary<string, Vehicle>();

            vehicles.Add("Alpha", new Car("Rot", 150, "Alpha", 6.5, VehicleType.SUV));
            vehicles.Add("Tesla", new ElectricCar("Blau", 120, "Tesla", 85, 20, VehicleType.Truck));


            //Implementieren Sie eine Methode FindVehicleByModel,
            //die ein Fahrzeug anhand seines Modells aus dem Dictionary
            //zurückgibt. Nutzen Sie die Methode TryGetValue, um
            //sicherzustellen, dass der Schlüssel existiert, bevor auf
            //das Fahrzeug zugegriffen wird.

            void FindVehicleByModel(string model)
            {
                if (vehicles.TryGetValue(model, out Vehicle vehicle))
                {
                    Console.WriteLine($"Fahrzeug wurde gefunden: {vehicle.Model} - Max Geschwindigkeit: {vehicle.MaxSpeed} km/h");

                }
                else
                {
                    Console.WriteLine("vehicle not found");
                }
            }

            //Implementieren Sie eine Methode RemoveVehicleByModel,
            //die Fahrzeuge aus der Sammlung anhand des Modells entfernt.

            void RemoveVehicleByModel(string model)
            {
                if (vehicles.Remove(model))
                {
                    Console.WriteLine($"Fahrzeug {model} erfolgreich entfernt.");
                }
                else
                {
                    Console.WriteLine($"Fahrzeug {model} nicht gefunden.");
                }
            }

        }
    }
}
