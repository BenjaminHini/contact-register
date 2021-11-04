using System;
using System.Collections.Generic;
using System.Text;

namespace assignment5
{
    public class Address
    {
        private string street, city, zip;
        private Countries country;
        /// <summary>
        /// property for the street attribute
        /// </summary>
        public string STREET
        {
            get { return street;  }
            set { street = value; }
        }
        /// <summary>
        /// property for the city attribute
        /// </summary>
        public string CITY
        {
            get { return city; }
            set { city = value; }
        }
        /// <summary>
        /// property for the zip attribute
        /// </summary>
        public string ZIP
        {
            get { return zip; }
            set { zip = value; }
        }
        /// <summary>
        /// property for the country attribute
        /// </summary>
        public Countries COUNTRY
        {
            get { return country; }
            set { country = value; }
        }
        /// <summary>
        /// constructor with two arguments
        /// call the constructor with every argument sending him its parameter +
        /// string.Empty for the others parameters
        /// </summary>
        /// <param name="ville">sets the city attibute</param>
        /// <param name="pays">set the country attribute</param>
        public Address(string ville, Countries pays) : this(string.Empty, ville, string.Empty, pays)
        {
        }
        /// <summary>
        /// constructer with an Address as parameter
        /// </summary>
        /// <param name="addr">sets every attribute with the one from this parameter</param>
        public Address(Address addr)
        {
            this.city = addr.CITY;
            this.street = addr.STREET;
            this.zip = addr.ZIP;
            this.country = addr.COUNTRY;
        }
        /// <summary>
        /// constructor with a parameter for every attribute
        /// </summary>
        /// <param name="rue">set the street attribute</param>
        /// <param name="ville">set the city attribute</param>
        /// <param name="code">set the zip attribute</param>
        /// <param name="pays">set the country attribute</param>
        public Address(string rue, string ville, string code, Countries pays)
        {
            street = rue;
            city = ville;
            zip = code;
            country = pays;
        }
        /// <summary>
        /// override the Object.ToString() method
        /// return a formated string describing the data from the 
        /// class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strout = street+"\n"+zip+"  "+city+"\n"+ToString(country);

            return strout;
        }
        /// <summary>
        /// called by Address.ToString()
        /// get the string representing the country and replace
        /// the eventual '_' characters by ' '
        /// </summary>
        /// <param name="country">country to be checked</param>
        /// <returns></returns>
        public string ToString(Countries country)
        {
            string str = country.ToString();
            char[] yes = str.ToCharArray();
            for (int i = 0; i < yes.Length; ++i)
                if (yes[i] == '_')
                    yes[i] = ' ';
            return new string(yes);
        }
    }
}
