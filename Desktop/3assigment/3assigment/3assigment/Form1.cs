using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3assigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {

            try
            {
                // const values
                const double taxes = 0.07;
                const double fixedcharge = 5.0;

                // variables
                string customerName = txtCustomer.Text;
                double previousreading = double.Parse(txtPrevious.Text);
                double currentreading = double.Parse(txtcurrent.Text);
                double unitprice = double.Parse(txtunitprice.Text);


                // calculate electricity usage
                double usageunits = currentreading - previousreading;

                // calculate bill
                double basebill = usageunits * unitprice;

                // calculate tax 
                double taxamount = basebill * taxes;

                // calculate fixed charges

                double totalbill = basebill + taxamount + fixedcharge;

                // display
                 lblelect.Text = usageunits.ToString();
                lblamount.Text = taxamount.ToString("c");
                lbltotal.Text = totalbill.ToString("c");
               

            }
            // handle invalid input
            catch
            {
                MessageBox.Show("please so geli xog saxan!");
            }




        }
    }
}
