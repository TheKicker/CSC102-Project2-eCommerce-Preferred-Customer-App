using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preferred_Customer_Shopping_App
{
    // Creates Customer Class that is inherited from Person Class
    public class Customer : Person
    {
        public bool _isChecked;

        public bool isChecked
        {
            get { return _isChecked; }
            set { _isChecked = value; }
        }


        public Customer(bool check, string name, string add, long phone)
            : base()
        {
            isChecked = check;
            Name = name;
            Address = add;
            Phone = phone;
        }
        
        public Customer(bool check, Person p)
            : base()
        {
            isChecked = check;
            Name = p.Name;
            Address = p.Address;
            Phone = p.Phone;
        }

        public Customer()
        {
        }

        // Refers to our mailing list opt in / opt out check box
        public bool IsChecked = false;

        
    }
}
