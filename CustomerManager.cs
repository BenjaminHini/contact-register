using System;
using System.Collections.Generic;
using System.Text;

namespace assignment5
{
    public class CustomerManager
    {
        private List<Customer> customers = new List<Customer>();
        /// <summary>
        /// default constructor
        /// </summary>
        public CustomerManager()
        {

        }
        /// <summary>
        /// delete the customer at the specified index of the list
        /// </summary>
        /// <param name="index">index of the customer to be deleted</param>
        public void deleteCustomer(int index)
        {
                customers.RemoveAt(index);
        }
        /// <summary>
        /// return the customer at the specified index of the list
        /// </summary>
        /// <param name="index">index of the customer to be returned</param>
        /// <returns></returns>
        public Customer getCustomer(int index)
        {
            return customers.ToArray()[index];
        }
        /// <summary>
        /// replace the customer at the specified index of the list
        /// by the customer sent in parameter
        /// </summary>
        /// <param name="index">index of the customer to be replaced</param>
        /// <param name="customer">new customer</param>
        public void setCustomer(int index,Customer customer)
        {
            customers.RemoveAt(index);
            customers.Add(customer);
        }
        /// <summary>
        /// add a new customer to the list
        /// </summary>
        /// <param name="customer">Customer to be added</param>
        public void add(Customer customer)
        {
            customers.Add(customer);
        }
        /// <summary>
        /// return the size of the list
        /// </summary>
        /// <returns></returns>
        public int getSize() { return customers.Count; }
    }
}
