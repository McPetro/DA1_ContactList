using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public delegate void UpdateList();

    public class AddressBook
    {
        public UpdateList UpdateMethod { get; set; }
        private List<Contact> contacts;

        public AddressBook()
        {
            contacts = new List<Contact>(10);


            for (int i = 1; i <= 5; i++)
            {
                var theContact = new Contact();
                theContact.Name = ""+i;
                theContact.PhoneNumber = ""+(i+1);
                theContact.Address = ""+(i+2);
                contacts.Add(theContact);
            }
            
        }

        public List<Contact> GetContacts()
        {
            return this.contacts;
        }

        public void AddContact( Contact newContact)
        {
            this.contacts.Add(newContact);
            this.UpdateMethod();
        }


    }
}
