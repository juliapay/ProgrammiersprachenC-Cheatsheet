namespace Todo
{
    internal abstract class TaskManager
    {
        //Collection soll nur innerhalb der Klasse
        //oder deren abgeleiteten Klasse sichtbar sein
        protected readonly List<Task> _tasks;

        //also valid options;:
        //protected List<Task> _tasks;
        //protected List<Task> Tasks { get; set; }
        //protected List<Task> Tasks { get; init; } 

        public TaskManager(List<Task> tasks)
        {
            _tasks = tasks;
        }

        //Task 6
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

        //Task 3
        private void PrintTasks()
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

        //Task 4
        private void FinishTask(int index)
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


            //alternative way to check if the index is valid:
            //if(index >= 0 && index < _tasks.Count)
            //{

            //    if (_tasks[index].Finished)
            //    {
            //        Console.WriteLine("The task is already finished");
            //    }
            //    else
            //    {
            //        _tasks[index].Finished = true;
            //        Console.WriteLine($"Congratulations on finishing your task!");
            //    }
            //}
            //else
            //{
            //    throw new ArgumentOutOfRangeException("The index is invalid");
            //}
        }


        //Task 5
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
    }
}