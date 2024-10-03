namespace CheatSheetC_.Uebungen.TodoUebung
{
    internal class ProgramTodo
    {
        public static void MainMenu()
        {
            List<Task> privateTask = new List<Task>();
            privateTask.Add(new Task("shopping"));
            privateTask.Add(new Task("learning"));
            privateTask.Add(new Task("cleaning"));
            privateTask.Add(new Task("feeding cats"));
            privateTask.Add(new Task("cooking"));
            PrivateTasks privateTasks = new PrivateTasks(privateTask);

            List<Task> workingTask = new List<Task>();
            privateTask.Add(new Task("testing"));
            privateTask.Add(new Task("coding"));
            privateTask.Add(new Task("teammeeting"));
            privateTask.Add(new Task("timing"));
            privateTask.Add(new Task("installing"));

            WorkTasks workTasks = new WorkTasks(workingTask);
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
