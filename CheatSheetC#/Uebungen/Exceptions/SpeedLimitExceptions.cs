using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatSheetC_.Uebungen.Exceptions
{
    internal class SpeedLimitExceptions: Exception
    {
        //Erstellen Sie eine eigene Ausnahmeklasse namens
        //SpeedLimitExceededException, die
        //von der Klasse Exception erbt.
       // Diese Ausnahme soll verwendet werden,
       // wenn die maximal erlaubte Geschwindigkeit
       // überschritten wird.

        public SpeedLimitExceptions(string message) :base (message)
        {
        }
    }
}
