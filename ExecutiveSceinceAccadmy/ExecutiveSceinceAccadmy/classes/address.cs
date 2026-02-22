using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutiveSceinceAccadmy.classes
{
    internal class Address
    {
        private string cityName;
        private string address;
        private string country;
        private string city;
        public Address
            () { }
        public Address(string cityName, string address, string country, string city)
        {
            this.cityName = cityName;
            this.address = address;
            this.country = country;
            this.city = city;

        }
        public string City
            { get { return this.cityName; }
            set { this.cityName = value; }
        }
        public string AddressLine
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string Country
            {
            get { return this.country; }
            set { this.country = value; }
        }
        public string CityName
        {
            get { return this.city; }
            set { this.city = value; }
        }
        public override string ToString()
        {
            return $"{this.address}, {this.cityName}, {this.country}";
        }
    }
}
