using System;
using System.Collections.Generic;
using System.Text;

namespace assignment5
{
    public class Customer
    {
        private Contact contact;
        /// <summary>
        /// property for the contact attribute
        /// </summary>
        public Contact CONTACT
        {
            get { return contact; }
            set { contact = value; }
        }
        /// <summary>
        /// default constructor
        /// </summary>
        public Customer()
        {

        }
        /// <summary>
        /// contructor with a contact as parameter
        /// </summary>
        /// <param name="a">set the contact attribute</param>
        public Customer(Contact a)
        {
            contact = a;
        }
    }
}
