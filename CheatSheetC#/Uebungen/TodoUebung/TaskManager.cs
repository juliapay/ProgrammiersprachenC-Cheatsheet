namespace CheatSheetC_.Uebungen.TodoUebung
{
    internal abstract class TaskManager
    {
        protected List<Task> _tasks;

        public TaskManager(List<Task> tasks)
        {
            _tasks = tasks;
        }

        private void NumberTheTasks()
        {
            string done;
            for (int i = 0; i < _tasks.Count; i++)
            {
                if (_tasks[i].Finished)
                {
                    done = "finished";
                }
                else
                {
                    done = "unfinished";
                }
                Console.WriteLine($"{i + 1}. {_tasks[i].Descritpion} - {done}");
            }
        }
        private void MarkTaskAsFinished(int index)
        {
            if (index < 1 || index > _tasks.Count + 1)
            {
                throw new Exception("Index out of Bound");
            }
            else
            {
                if (_tasks[index].Finished)
                {
                    Console.WriteLine("Task alreadxy finished!");
                }
                else
                {
                    _tasks[index].Finished = true;
                    Console.WriteLine($"Task {_tasks[index + 1].Descritpion} alreadxy finished!");
                }

            }
        }
        private void EnterTheIndexForMarkTaskAsFinished()
        {
            bool hasValidInput = false;
            do
            {
                Console.WriteLine("enter the indexnumber of the task you want to mark as finished");

                if (int.TryParse(Console.ReadLine(), out int taskIndex))
                {
                    try
                    {
                        MarkTaskAsFinished(taskIndex - 1);
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
            } while (!hasValidInput);
        }
        public void ChooseTheTaskOption()
        {
            bool exitToMainMenu = false;
            while(!exitToMainMenu)
            {
                NumberTheTasks();
                Console.WriteLine("Choose an Option:");
                Console.WriteLine("a  Mark a task from the list as finished");
                Console.WriteLine("x  exit to the Mainmenu");
                string input = Console.ReadLine();
                if (input.ToLower() == "a")
                {
                    EnterTheIndexForMarkTaskAsFinished();
                }else if(input.ToLower() == "x")
                {
                    exitToMainMenu = true;
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
