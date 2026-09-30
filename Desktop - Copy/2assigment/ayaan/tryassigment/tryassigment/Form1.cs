using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tryassigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
      


            try
            {
                // variables
                const double SALES_RATE = 0.07;
                const double TIPS_RATE = 0.15;

                string food1 = txtfoodname1.Text;
                string food2 = txtfoodname2.Text;
                //convert pricesle
                double price1 = double.Parse(txtfoodname1.Text);
                double price2 = double.Parse(txtfoodname2.Text);

                // checking the prices.

                double amount = price1 + price2;
                double sales=amount * SALES_RATE;
                double tips = amount * TIPS_RATE;
                double totalamount = amount + sales + tips;
             

                // display

                lblsales.Text=sales.ToString("c");
                lbltipsamount.Text=tips.ToString("c");
                lblTotalamount.Text=totalamount.ToString("c"); 
            }

            catch
            {
                MessageBox.Show("fadlan wax sax so geli");

            }
                
                }

        private void lblTotalamount_Click(object sender, EventArgs e)
        {

        }
    }
    }


