using System.Security.Cryptography.X509Certificates;

namespace CheatSheetC_.Uebungen.Vererbung
{
    internal class ProgramClass
    {
        //Erstelle eine Methode MaintainVehicle(Vehicle vehicle)
        //in der Program-Klasse, die zuerst überprüft,
        //ob das übergebene Objekt vom Typ Car oder ElectricCar ist.
        //Rufe dann die spezifischen Methoden (ReplaceFuelFilter()
        //oder CheckBatteryHealth()) auf.

        Car Car = new Car();
        ElectricCar ElectricCar = new ElectricCar();

        public void MaintainanceVehicle(Vehicle vehicle)
        {
            if (vehicle is Car)
            {
                Car.ReplaceFuelFilter();
            }
            else if (vehicle is ElectricCar)
            {
                ElectricCar.CheckBatteryHealth();
            }
        }
        static void Task6()
        {
            //Erweitere die Klasse Car um die Methode ReplaceFuelFilter(), die eine Meldung ausgibt, dass der Kraftstofffilter ersetzt wurde.
            //Erweitere die Klasse ElectricCar um die Methode CheckBatteryHealth(), die eine Meldung ausgibt, dass die Batterie überprüft wurde.

            /*Erstelle eine Methode MaintainVehicle(Vehicle vehicle) in der Program Klasse, die zuerst überprüft, ob das übergebene Objekt 
             * vom Typ Car oder ElectricCar ist. Rufe dann die 
             * spezifische Methoden (ReplaceFuelFilter, oder CheckBatteryHealth) auf.
             * Teste dies, indem du sowohl ein Car als auch ein ElectricCar erstellst und diese der Methode MaintainVehicle übergibst.*/

            void MaintainVehicle(Vehicle vehicle)
            {
                if (vehicle is ElectricCar electricCar)
                {
                    Console.WriteLine("This is an electric car");
                    electricCar.CheckBatteryHealth();
                }
                else if (vehicle is Car car)
                {
                    Console.WriteLine("This is an ICE car");
                    car.ReplaceFuelFilter();
                }
                else
                {
                    Console.WriteLine("Unknown car type");
                }
            }

            MaintainVehicle(new Car());
            MaintainVehicle(new ElectricCar());

        }

        static void Task7()
        {
            //Erweitere die Klasse Vehicle um die statische methode IsFaster(Vehicle vehicle1, Vehicle vehicle2), die true zurückgibt, wenn vehicle1 schneller ist als vehicle2.
            //Erstelle eine Methode in der Program Klasse, die zwei Vehicle Objekte als Parameter bekommt und dann mit dem schnelleren Fahrzeug eine Strecke von 138 km fährt.
            //Teste dies, indem du ein Car und ein ElectricCar erstellst und die Methode mit diesen aufrufst.

            void DriveFasterVehicle(Vehicle vehicle1,Vehicle vehicle2)
            {
                if (Vehicle.IsFaster(vehicle1, vehicle2))
                {
                    vehicle1.Drive(138);
                }
                else
                {
                    vehicle2.Drive(138);
                }
            }

            DriveFasterVehicle(new Car(), new ElectricCar());
        }
        static void Task8()
        {
            //Erweitere die Klasse Vehicle um eine Methode CheckBrakes(), die eine Meldung ausgibt, dass die Bremsen überprüft wurden.
            //Erstelle eine Schnittstelle IMaintenance mit den Methoden ServiceCar().
            //Implementiere diese Schnittstelle in den Klassen Car und ElectricCar. Die Bremsen sollen übeprfüt werden und die spezifischen Methoden ReplaceFuelFilter() bzw. CheckBatteryHealth() aufgerufen werden.
            //Implementiere eine neue Methode MaintainFleet die eine unbestimmte Anzahl an Fahrzeugen übergeben bekommt und die ServiceCar Methode für jedes Fahrzeug aufruft.
            //Du kannst dafür den params Modifizierer verwenden.

            MaintanFleet(new Car(), new ElectricCar());

            void MaintanFleet(params IMaintainance[] maitainance)
            {
                foreach (var m in maitainance)
                {
                    m.ServicCar();
                }
            }
        }
    }
}
