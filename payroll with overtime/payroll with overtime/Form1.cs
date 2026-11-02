using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll_with_overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btncalculate_Click_1(object sender, EventArgs e)
        {
            //creating variables
            double hours, rate, grosspay;

            hours=double.Parse(txthoursworked.Text);
            rate=double.Parse(txtpayrate.Text);

            //checked

            if (hours <= 40)
            grosspay = hours * rate;

            else
            {
                grosspay = (40 * rate) + (
                  (hours - 40) * rate * 1.5);

            }


            
                txtgrosspay.Text = grosspay.ToString("c2");
        }

     

        private void btnclear_Click(object sender, EventArgs e)
        {
            txthoursworked.Clear();
            txtpayrate.Clear();
            txtgrosspay.Clear();
        }


        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
