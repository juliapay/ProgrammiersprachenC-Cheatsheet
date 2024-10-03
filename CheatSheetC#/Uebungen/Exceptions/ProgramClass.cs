namespace CheatSheetC_.Uebungen.Exceptions
{
    internal class ProgramClass
    {
        static void Task1()
        {
            /* Erstellen Sie eine Instanz der Klasse Car und fragen Sie den Benutzer, welche Distanz er mit dem Auto fahren möchte(in Kilometern).
             * Verwenden Sie einen try-catch-Block, um zu überprüfen, ob der Benutzer eine gültige Zahl eingegeben hat. 
             * Fangen Sie eine eine Exception des entsprechendes Typs, falls eine ungültige Eingabe(z.B.Buchstaben anstelle von Zahlen) erfolgt.
             * Falls der Benutzer eine gültige Zahl eingibt, rufen Sie die Methode Drive des Autos auf, um die angegebene Distanz zu fahren.
             * Im catch-Block soll eine Fehlermeldung ausgegeben werden, wenn der Benutzer eine ungültige Eingabe macht.*/
            try
            {
                Console.Write("Enter the distance in km you want to drive: ");
                int distance = Convert.ToInt32(Console.ReadLine());
                Car car = new Car();
                car.Drive(distance);

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
            }
        }
        static void Task2()
        {
            /* Ändere die Drive Methode der Klasse Vehicle so, dass sie 
             * eine ArguementException wirft, wenn die übergebene 
             * Distanz negativ ist.
             * Die geworfene Exception sollte die Fehlermeldung enthalten, dass die Distanz nicht negativ sein darf.
             * Fange die entsprechende Exception beim Aufruf der Methode 
             * Drive, und gebe die ensprechende Fehlermeldung auf der 
             * Konsole aus.
             */

            try
            {
                Console.Write("Enter the distance in km you want to drive: ");
                int distance = Convert.ToInt32(Console.ReadLine());
                Car car = new Car();
                car.Drive(distance);

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
