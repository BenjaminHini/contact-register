using System;
using System.Collections.Generic;
using System.Text;

namespace assignment5
{
    public class Contact
    {
        private Address adress;
        private Email email;
        private Phone phone;
        private string firstname, lastname;
        /// <summary>
        /// property related to the adress attribute
        /// </summary>
        public Address ADDRESS
        {
            get { return adress; }
            set { adress = value; }
        }
        /// <summary>
        /// property related to the email attribute
        /// </summary>
        public Email EMAIL
        {
            get { return email; }
            set { email = value; }
        }
        /// <summary>
        /// property related to the phone attribute
        /// </summary>
        public Phone PHONE
        {
            get { return phone; }
            set { phone = value; }
        }
        /// <summary>
        /// property related to the firstname attribute
        /// </summary>
        public string FIRSTNAME
        {
            get { return firstname; }
            set { firstname = value; }
        }
        /// <summary>
        /// preperty related to the lastname attribute
        /// </summary>
        public string LASTNAME
        {
            get { return lastname; }
            set { lastname = value; }
        }
        /// <summary>
        /// default constructor, set all attributes values to null
        /// </summary>
        public Contact()
        {

        }
        /// <summary>
        /// constructor receiving a parameter for each of the contact attributes
        /// </summary>
        /// <param name="addr">set the adress attribute</param>
        /// <param name="mail">set the email attribute</param>
        /// <param name="phon">set the phone attribute</param>
        /// <param name="fname">set the firstname attibute</param>
        /// <param name="lname">set the lastname attribute</param>
        public Contact (Address addr, Email mail, Phone phon, string fname, string lname)
        {
            adress = addr;
            email = mail;
            phone = phon;
            firstname = fname;
            lastname = lname;
        }
        /// <summary>
        /// return true if the contact has the minimum required data
        /// to create a new customer with
        /// </summary>
        /// <returns></returns>
        public bool CheckData()
        {
            return ((firstname != string.Empty || lastname != string.Empty) && adress.CITY != string.Empty);
        }
       
    }
}
