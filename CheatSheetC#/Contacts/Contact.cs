using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatSheetC_.Contacts
{
    internal class Contact
    {
        public string name {  get; init; }
        public string email { get; set; }

        public Contact(string name)
        {
            this.name = name;
        }
    }
}
