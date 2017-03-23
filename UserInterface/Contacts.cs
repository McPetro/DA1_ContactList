using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Contacts : Form
    {
        private AddressBook book;

        public Contacts()
        {
            InitializeComponent();
            book = new AddressBook();
            this.UpdateContacts();
        }

        public void UpdateContacts() {
            this.contactList.DataSource = this.book.GetContacts();
            this.contactList.Update();
        }

        private void contactList_SelectedIndexChanged(object sender, EventArgs e)
        {
            BusinessLogic.Contact  c = this.contactList.SelectedItem as BusinessLogic.Contact;
            this.shwName.Text = c.Name;
            this.shwPhnNum.Text = c.PhoneNumber;
            this.shwAddr.Text = c.Address;
        }

        

        private void addModifyContact_Click(object sender, EventArgs e)
        {
            UserInterface.Contact contactWindow = new UserInterface.Contact(book,this);
            contactWindow.Show();
        }
    }
}
