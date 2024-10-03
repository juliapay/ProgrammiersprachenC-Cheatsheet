using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatSheetC_.Contacts
{
    internal class WorkingContactManager : ContactManager
    {
        public WorkingContactManager(Dictionary<int, Contact> contacts) : base(contacts)
        {
        }
    }
}
