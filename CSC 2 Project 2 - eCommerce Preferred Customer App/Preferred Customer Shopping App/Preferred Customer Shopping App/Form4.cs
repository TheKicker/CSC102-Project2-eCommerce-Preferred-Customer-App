using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preferred_Customer_Shopping_App
{
    public partial class OrdProForm : Form
    {
        public OrdProForm(double t, Preferred p, double pt)
        {
            InitializeComponent();
            Total = t;
            Preferred preferred = p;
            PreTotal = pt;           
            discountLevel = p.DiscountLevel;
        }

        // Creates multiple variables 
        double PreTotal;
        double Total;
        double discountLevel;
              
        
        private void button1_Click(object sender, EventArgs e)
        {
            // Closes the form 
            this.Close();
        }

        private void OrdProForm_Load(object sender, EventArgs e)
        {
            // Outputs the information from the order to the text box available
            textBox1.Text = "$" + Math.Round(PreTotal, 2).ToString();
            textBox2.Text = (discountLevel * 100).ToString() + "%";
            textBox3.Text = "$" + Math.Round(Total, 2).ToString();
            

        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Ignore (Accidental click)
        }
    }
}
