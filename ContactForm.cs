using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment5
{
    public partial class ContactForm : Form
    {

        private Contact contact = new Contact();
        /// <summary>
        /// default cunstructor
        /// </summary>
        public ContactForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// constructor called by MainForm
        /// initialize its component and set its title to the value
        /// sent in parameter
        /// </summary>
        /// <param name="title">string representing the title of the form</param>
        public ContactForm(string title)
        {
            InitializeComponent();
            country_cmb.DataSource = Enum.GetValues(typeof(Countries));
            this.Text = title;

        }
        /// <summary>
        /// gets the value from the different textboxes of the form
        /// and create a Contact out of them.
        /// Check whether the contact has the minimum required data: 
        /// if no create a MessageBox saying it and cancel the closing of the form
        /// if yes quit the form with OK as DialogResult
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ok_btn_Click(object sender, EventArgs e)
        {

            Countries enu = (Countries)country_cmb.Items[country_cmb.SelectedIndex];
            var address = new Address(street_txt.Text, city_txt.Text, zip_txt.Text, enu);
            var phone = new Phone(hphone_txt.Text, cphone_txt.Text);
            var mail = new Email(bmail_txt.Text, pmail_txt.Text);
            contact = new Contact(address, mail, phone, fname_txt.Text, lname_txt.Text);
            if(!contact.CheckData())
            {
                MessageBox.Show("missing some data");
                this.DialogResult = DialogResult.None;
            }
        }
        /// <summary>
        /// display a MessageBox asking the user to confirm he wants to leave the 
        /// form without saving.
        /// if yes quit the form with Cancel as dialogResult
        /// if no stay in the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("do you want to quit", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                this.DialogResult = DialogResult.None;
        }
        /// <summary>
        /// create and return a Customer from the contact attribute
        /// </summary>
        /// <returns></returns>
        public Customer GetContact() { return new Customer(contact);}
        /// <summary>
        /// set the contact attribute to the value sent in parameter
        /// calls InitializeGUI() to fill the textboxes with the Contact's data 
        /// </summary>
        /// <param name="a">parametter setting the attribute value</param>
        public void setContact(Contact a) 
        {
            contact = a;
            InitializeGUI();
        }
        /// <summary>
        /// called by GetContact()
        /// fill the form's textboxes with the contact's data
        /// </summary>
        public void InitializeGUI()
        {
            fname_txt.Text = contact.FIRSTNAME;
            lname_txt.Text = contact.LASTNAME;
            hphone_txt.Text = contact.PHONE.Personal;
            cphone_txt.Text = contact.PHONE.Work;
            bmail_txt.Text = contact.EMAIL.Work;
            pmail_txt.Text = contact.EMAIL.Personal;
            street_txt.Text = contact.ADDRESS.STREET;
            city_txt.Text = contact.ADDRESS.CITY;
            zip_txt.Text = contact.ADDRESS.ZIP;
            country_cmb.SelectedIndex = (int)contact.ADDRESS.COUNTRY;
        }

    }
}
