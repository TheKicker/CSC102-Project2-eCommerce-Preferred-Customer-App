using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preferred_Customer_Shopping_App
{
    // Create 'public' class called customer
    public class Person
    {
        public string _name;
        public string _address;
        public long _phone;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public long Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        
        public Person(string n, string a, long p)
        {
            Name = n;
            Address = a;
            Phone = p;
        }

        public Person()
        {

        }
    }
}
