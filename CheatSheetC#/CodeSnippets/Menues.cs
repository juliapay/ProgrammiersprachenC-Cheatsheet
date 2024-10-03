namespace CheatSheetC_.CodeSnippets
{
    internal class Menues
    {
        //EINGABE MIT STRING - STRING FALSCH NOCHEINMAL
        //zwischen folgenden Optionen wählen:
        //a) Eine Aufgabe abschließen
        //x) Zurück zur Hauptauswahl
        //zeigen Sie eine "Ungültige Eingabe" -Meldung in der Konsole an.
        //Wiederholen Sie alles, bis die Benutzerin die Option auswählt,
        //zur Hauptauswahl zurückzukehren("x").

        public void HandleTodoList()
        {
            bool goBack = false;
            while (!goBack)
            {
                PrintTasks();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("a) Finish an item");
                Console.WriteLine("x) Go back to main selection");
                string choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "a")
                {
                    AskUserToFinishTask();
                }
                else if (choice == "x")
                {
                    goBack = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }
        //EINGABE STRING - ZAHL MIT EXCEPTION
        //Benutzerin auffordern, den Index der Aufgabe einzugeben,
        //die sie erledigen möchte. Wenn die Eingabe der Benutzerin
        //keine ZAHL ist, geben Sie eine Nachricht in der Konsole aus,
        //dass die Eingabe ungültig ist. Wenn die Benutzerin eine Zahl
        //eingibt, leiten Sie sie an die in Aufgabe 4 erstellte Methode weiter. Behandeln Sie die von dieser Methode ausgelöste Exception. Die Benutzerin sollte die Eingabe wiederholen, bis eine Aufgabe erfolgreich als erledigt markiert wurde.

        private void AskUserToFinishTask()
        {
            bool hasValidInput = false;

            while (!hasValidInput)
            {
                Console.WriteLine("Enter the index of the task to finish:");
                if (int.TryParse(Console.ReadLine(), out int taskIndex))
                {
                    try
                    {
                        FinishTask(taskIndex - 1);
                        hasValidInput = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
        public void menueHauptprogramm()
        {
            bool inputNotExit = false;
            while (inputNotExit)
            {
                Console.WriteLine("MainMenu");
                Console.WriteLine("a show the private TodoList");
                Console.WriteLine("b show the work TodoList");
                Console.WriteLine("x Exit");
                string input = Console.ReadLine();
                if (input.ToLower() == "a")
                {
                    privateTasks.ChooseTheTaskOption();
                }
                else if (input.ToLower() == "b")
                {
                    workTasks.ChooseTheTaskOption();
                }
                else if (input.ToLower() == "x")
                {
                    inputNotExit = true;
                    break;
                }
                else
                {
                    Console.WriteLine("No valid input");
                    continue;
                }
            }
        }
    }
}



