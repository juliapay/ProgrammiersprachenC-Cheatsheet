using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatSheetC_.Contacts
{
    internal abstract class ContactManager
    {
        protected Dictionary<int, Contact> _contacts;

        public ContactManager(Dictionary<int, Contact> contacts)
        {
            _contacts = contacts;
        }


        public void AddContact(int phonenumber, Contact contact)
        {

        }
    }   
}
