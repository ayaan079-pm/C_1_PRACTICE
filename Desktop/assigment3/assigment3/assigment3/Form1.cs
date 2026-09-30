using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try { 



            const double SALES_RATE = 7;
            const double TIPS_RATE = 15;
            string foodname1 = txtfoodname1.Text;
            string foodname2 = txtfoodname2.Text;
            double price1, price2, amounttotal, tax, totalamount, sales, tips, total, amount;
            //ceating variables and assign
            price1 = double.Parse(txtfoodname1.Text);
            price2 = double.Parse(txtfoodname2.Text);

            amounttotal = price1 + price2;
            tax = amounttotal * 7;
            totalamount = tax * 15;
            //calculate the total amount
            amount = price1 + price2;
            //now calculate the sales
            sales = amount * (SALES_RATE / 100);
            //now calculate the tips
            tips = amount * (TIPS_RATE / 100);
            //all calculate
            total = amount + sales - tips;

            //display
           lblsales.Text = sales.ToString("C");
            lbltipsamount.Text = tips.ToString("c");
            lblTotalamount.Text = total.ToString("C");
        }

            // keeping negative things

            catch {
                MessageBox.Show("plz try again invalid error");
            }
}

          

}
    }

