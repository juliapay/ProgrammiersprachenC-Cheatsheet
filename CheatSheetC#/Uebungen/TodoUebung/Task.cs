using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatSheetC_.Uebungen.TodoUebung
{
    internal class Task
    {
        public string Descritpion {  get; init; }
        public bool Finished { get; set; }

        public Task(string descritpion)
        {
            Descritpion = descritpion;
            Finished = false;
        }
    }
}
