namespace CheatSheetC_.CodeSnippets
{
    internal class IterationDurchCollections
    {
        static void list()
        {



            //LIST NUMMERNZUWEISUNG

             void PrintTasks()
            {
                for (int i = 0; i < _tasks.Count; i++)
                {
                    Console.Write($"{i + 1}. {_tasks[i].Description}");
                    Console.WriteLine(_tasks[i].Finished ? " [FINISHED]" : " [NOT FINISHED]");
                }

                //alternative way to print tasks:
                //foreach (Task task in _tasks)
                //{
                //    Console.Write($"{_tasks.IndexOf(task) + 1}. {task.Description}");
                //    if (task.Finished)
                //    {
                //        Console.WriteLine(" [FINISHED]");
                //    }
                //    else
                //    {
                //        Console.WriteLine(" [NOT FINISHED]");
                //    }
                //}
            }

             void FinishTask(int index)
            {
                if (index < 0 || index >= _tasks.Count)
                {
                    throw new ArgumentOutOfRangeException("The index is invalid");
                }

                if (_tasks[index].Finished)
                {
                    Console.WriteLine("The task is already finished");
                }
                else
                {
                    _tasks[index].Finished = true;
                    Console.WriteLine($"Congratulations on finishing your task!");
                }

                // LIST REMOVE NACH ENUMTYPE

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
        }

        static void dictionary()
        {
            //DICTIONARY ERSTELLEN 

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
        public void WhileLoop()
        {
            //++++++   mit COUNTER
            int counter = 0;
            while (counter < 5)
            {
                Console.WriteLine($"The counter value now is {counter}");
                counter++;
            }
            //+++++++   NO COUNTER
            Console.WriteLine("The magic number is: ");
            int input = Convert.ToInt32(Console.ReadLine());
            while (input != 42)
            {
                Console.WriteLine($"No, {input} is not the magic number!");
                Console.WriteLine("The magic number is: ");
                input = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("That's right. The magic number is 42");

            //++++++++   DOWHILE
            int input;
            do
            {
                Console.Write("The magic number is: ");
                input = Convert.ToInt32(Console.ReadLine());

                if (input != 42)
                {
                    Console.WriteLine($"No, {input} is not the magic number!\n");
                }


            } while (input != 42);
            Console.WriteLine("That's right. The magic number is 42.");


            //++++++++   DOWHILE WITH BREAK
            int input;
            do
            {
                Console.Write("The magic number is: ");
                input = Convert.ToInt32(Console.ReadLine());

                if (input == 42)
                {
                    break;
                }
                Console.WriteLine($"No, {input} is not the magic number!\n");

            } while (true);
            Console.WriteLine("That's right. The magic number is 42.");

        }
    }

}

