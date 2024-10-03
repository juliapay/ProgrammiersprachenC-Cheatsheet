namespace Todo
{
    internal class Task
    {
        //kein Zugriffsmodifizierer vorgegeben
        //Description sol nach der Initialisierung nicht mehr veränderbar sein
        public string Description { get; init; }
        public bool Finished { get; set; }

        //keine Angabe ob beide Variablen initialisiert werden müssen
        public Task(string description)
        {
            Description = description;
        }
    }
}