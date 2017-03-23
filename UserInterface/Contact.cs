using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace UserInterface
{
    public partial class Contact : Form
    {
        private AddressBook book;
        private Contacts contacts;

        public Contact(AddressBook book, Contacts contacts)
        {
            InitializeComponent();
            this.book = book;
            this.contacts = contacts;
        }

        private void newContactSubmit_Click(object sender, EventArgs e)
        {
            BusinessLogic.Contact newContact = new BusinessLogic.Contact();
            newContact.Name = this.nameImput.Text;
            newContact.Address = this.addressInput.Text;
            newContact.PhoneNumber = this.phoneNumInput.Text;
            this.book.AddContact(newContact);
            this.contacts.UpdateContacts();
            this.Hide();
            
        }
    }
}
