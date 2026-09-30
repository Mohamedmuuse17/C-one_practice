using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tip_tax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get food 1
            string food1 = textBox1.Text;

            // Get price 1
            double price1 = double.Parse(textBox2.Text);

            // Get food 2
            string food2 = textBox3.Text;

            // Get price 2
            double price2 = double.Parse(textBox4.Text);

            // Calculate subtotal
            double subtotal = price1 + price2;

            // Calculate 10% sales tax
            double salesTax = subtotal * 0.07;

            // Calculate total
            double total = subtotal + salesTax;

            // Display sales tax
            textBox6.Text = salesTax.ToString("");

            // Display total
            textBox7.Text =  total.ToString("");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
