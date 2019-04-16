using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Preferred_Customer_Shopping_App
{
    public partial class ShopForm : Form
    {
        public ShopForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)       
            // Help Button //
        {
            // Leave Form open

            // Show the Help Form
            HelpForm Form2 = new HelpForm();
            Form2.ShowDialog();
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Catalogue' table. You can move, or remove it, as needed.
            this.catalogueTableAdapter.Fill(this.database1DataSet1.Catalogue);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Button1 is the Checkout Button //

            // Collect Information from Data TextBoxes = 
            //
            //      Name     = textBox1
            //      Address  = textBox2
            //      Phone    = textBox3
            //
            // Product Information Boxes = 
            //
            //     textBox4, textBox5, textBox6, textBox7 
            //     textBox8, textBox9, textBox10, textBox11
            //     textBox12, textBox13, textBox14, textBox15
            //     textBox16, textBox17, textBox18, textBox19
            //     textBox20, textBox21, textBox22, textBox23
            //

            string Name;
            Name = textBox1.ToString();

            // Exception handling if the user does not input any information 
            // Opens message box urging user to input contact information
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
            {
                // Creates our "person" using information provided 
                Person person = new Person(textBox1.Text, textBox2.Text, Convert.ToInt64(textBox3.Text));

                // Determines bool event if customer checked mailing list or not
                Customer customer = new Customer(checkBox1.Checked, person);

                // Creates 'Total' and assigns it a begin value of 0
                double Total = 0.00;

                // Array of the shopping list
                TextBox[,] order =
                                    {   {textBox4, textBox5, textBox6, textBox7},
                                        {textBox8, textBox9, textBox10, textBox11},
                                        {textBox12, textBox13, textBox14, textBox15},
                                        {textBox16, textBox17, textBox18, textBox19},
                                        {textBox20, textBox21, textBox22, textBox23} };

                // For loop designed to read the order and calculate Total
                for (int ROWS = 0; ROWS < 5; ROWS++)
                {
                    if (order[ROWS, 0].Text.Length > 0)
                        Total += (Convert.ToDouble(order[ROWS, 2].Text) * Convert.ToDouble(order[ROWS, 3].Text));
                }

                // Reads the total and assigns the new class 
                Preferred preferred = new Preferred(0, customer);
                
                // Determines the discount level
                if (Total > 500 && Total < 1001)
                    preferred.DiscountLevel = 0.05;
                else if (Total >= 1001)
                    preferred.DiscountLevel = 0.10;

                // Creates our pretotal value for output 
                // Then determines new total based on discount level
                double PreTotal = Total;
                Total = Total - (Total * preferred.DiscountLevel);


                // Opens Order Processing Form
                this.Hide();

                // Sends all information to the final form for output
                OrdProForm Form4 = new OrdProForm(Total, preferred, PreTotal);
                Form4.ShowDialog();
            }
            else
            {
                // Exception handling
                MessageBox.Show("Please fill in all of the information");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cancel button // 

            MessageBox.Show("Come back again soon!!");

            this.Close();
        }
    }
}
