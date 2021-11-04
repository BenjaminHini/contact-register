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
    public partial class MainForm : Form
    {

        private CustomerManager customerManager;

        /// <summary>
        /// basic form constructor, initialize the form's component
        /// set the customerManager attribute and initialize the GUI
        /// via the updateDisplay() method
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            customerManager = new CustomerManager();
            updateDisplay();
        }
        /// <summary>
        /// create and display a ContactForm
        /// if the user press its 'OK' button, add the created customer to 
        /// customerMAnager and show it in the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_btn_Click(object sender, EventArgs e)
        {
            var form = new ContactForm("Add new customer");
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
                customerManager.add(form.GetContact());
            updateDisplay();
        }
        /// <summary>
        /// create and dispay a ContactForm
        /// if the user press its 'OK' button, replace the selected 
        /// customer from the listbox by a new customer with the data 
        /// entered in the form and show it in the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int index = customer_list.SelectedIndex;
                var form = new ContactForm("Edit customer");
                form.setContact(customerManager.getCustomer(index).CONTACT);
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                    customerManager.setCustomer(index, form.GetContact());
                updateDisplay();
            }
            catch(IndexOutOfRangeException ex) { MessageBox.Show(ex.ToString()); }
        }
        /// <summary>
        /// remove the selected customer of the listbox
        /// from customerManager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int index = customer_list.SelectedIndex;
                customerManager.deleteCustomer(index);
                updateDisplay();
            }
            catch(IndexOutOfRangeException  ex) { MessageBox.Show(ex.ToString()); }
            catch(ArgumentOutOfRangeException ex2) { MessageBox.Show(ex2.ToString()); }
        }
        /// <summary>
        /// is called after every action
        /// empty the labels showing the contact details, clear the listbox and
        /// fullfill it with the data from customerManager
        /// </summary>
        public void updateDisplay()
        {
            name_lbl.Text = string.Empty;
            address_lbl.Text = string.Empty;
            mail_lbl.Text = string.Empty;
            phone_lbl.Text = string.Empty;
            customer_list.Items.Clear();
            for (int i = 0; i < customerManager.getSize(); ++i)
                customer_list.Items.Add((100 + i) + "\r\t" + customerManager.getCustomer(i).CONTACT.FIRSTNAME
                    + "\r  " + customerManager.getCustomer(i).CONTACT.LASTNAME + "\r\t\t" +
                    customerManager.getCustomer(i).CONTACT.PHONE.Work + "\r\t" +
                    customerManager.getCustomer(i).CONTACT.EMAIL.Work);

        }
        /// <summary>
        /// called when the user click on the listbox
        /// display the data from the selected customer in the 'Customer Details'
        /// zone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customer_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = customer_list.SelectedIndex;
                name_lbl.Text = customerManager.getCustomer(index).CONTACT.FIRSTNAME + "  " +
                    customerManager.getCustomer(index).CONTACT.LASTNAME;
                address_lbl.Text = customerManager.getCustomer(index).CONTACT.ADDRESS.ToString();
                mail_lbl.Text = customerManager.getCustomer(index).CONTACT.EMAIL.ToString();
                phone_lbl.Text = customerManager.getCustomer(index).CONTACT.PHONE.ToString();
            }
            catch(IndexOutOfRangeException ex) { MessageBox.Show(ex.ToString()); }
        }

    }
}
