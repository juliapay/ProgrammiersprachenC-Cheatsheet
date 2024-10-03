using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatSheetC_.Contacts
{
    internal class PrivateContactManager : ContactManager
    {
        public PrivateContactManager(Dictionary<int, Contact> contacts) : base(contacts)
        {
        }
    }
}
