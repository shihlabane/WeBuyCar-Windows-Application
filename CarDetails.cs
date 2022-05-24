using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeBuyCars
{
    public partial class CarDetails : Form
    {
        public CarDetails()
        {
            InitializeComponent();

            double deposit = double.Parse(textBox_Deposit.Text);
            double interest_rate = double.Parse(textBox_InterestRate.Text);
        }

        public double CalculatePrice(double carPrice)
        {
            int months = 0;
            double totalPrice = 0;
            if (radioButton1.Checked)
            {
                months = 36;
                
            }

            totalPrice = carPrice - 

        }
        private void label9_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label_InterestRate_Click(object sender, EventArgs e)
        {

        }

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            // calculate
        }

        private void label_NormalPrice_Click(object sender, EventArgs e)
        {
            
        }
    }
}
