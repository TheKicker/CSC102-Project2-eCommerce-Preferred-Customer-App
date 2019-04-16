using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preferred_Customer_Shopping_App
{
    // Creates Preffered Class that is inherited from Customer Class
    // Inheritance Chaining states Preferred is also inherited to Person
    public class Preferred : Customer
    {
        // Creates the level of discount based on total purchase
        // Basic  = $0 to $500    at a discount of 00%
        // Silver = $501 to $1000 at a discount of 05%
        // Gold   = $1001 to MORE at a discount of 10%

        public double _discountLevel;

        public double DiscountLevel
        {
            get { return _discountLevel; }
            set { _discountLevel = value; }
        }

        public Preferred(double dl, bool check, string name, string add, long phone)
            : base()
        {
            DiscountLevel = 0.00;
            isChecked = check;
            Name = name;
            Address = add;
            Phone = phone;
        }

        public Preferred(double dl, Customer c)
            : base()
        {
            DiscountLevel = dl;
            isChecked = c.isChecked;
            Name = c.Name;
            Address = c.Address;
            Phone = c.Phone;
        }

    }
}
