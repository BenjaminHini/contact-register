using System;
using System.Collections.Generic;
using System.Text;

namespace assignment5
{
    public class Phone
    {
        private string ophone, pphone;
        /// <summary>
        /// property for the ophone attribute
        /// </summary>
        public string Work
        {
            get { return ophone; }
            set { ophone = value; }
        }
        /// <summary>
        /// property for the pphone attribute
        /// </summary>
        public string Personal
        {
            get { return pphone; }
            set { pphone = value; }
        }
        /// <summary>
        /// constructor with parameters for every attributes
        /// </summary>
        /// <param name="home">set the ophone attribute</param>
        /// <param name="personal">set the pphone attribute</param>
        public Phone(string home, string personal) 
        {
            ophone = home;
            pphone = personal;
        }
        /// <summary>
        /// override Object.ToString()
        /// retrun a formated string representing the data from the Phone class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strout = "Phone Number\n";
            
            strout += string.Format("{0,-10} {1,-10}\n", "Private", pphone);
            strout += string.Format("{0,-10} {1,-10}\n", "Office", ophone);

            return strout;

        }
    }
}
