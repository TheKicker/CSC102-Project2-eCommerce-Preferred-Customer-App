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
    public partial class WelcForm : Form
    {
        public WelcForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

            // Continue button //
        {
            // Hide Welcome Form
            this.Hide();
            
            // Open the Shop Form
            ShopForm Form3 = new ShopForm();
            Form3.ShowDialog();

            // Closes the form
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
           
            // Help Link //
        {
            // Leave Form open
            
            // Show the Help Form
            HelpForm Form2 = new HelpForm();
            Form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Close Button //

            // Display message box, close application
            MessageBox.Show("Come back again soon!!");
            this.Close();
        }
    }
}
