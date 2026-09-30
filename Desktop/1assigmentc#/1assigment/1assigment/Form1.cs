using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1assigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dayoftheweek, month, dayofthemonth, year, showdata;
            dayoftheweek = txtdayofweek.Text;
            month = txtmonth.Text;
            dayofthemonth = txtdayofmonth.Text;
            year = txtyear.Text;
            showdata = dayoftheweek + " " + month + " " + dayofthemonth + "" + year;
            dateoutput.Text = showdata;

                }

        private void button2_Click(object sender, EventArgs e)
        {
            txtdayofweek.Clear();
            txtmonth.Clear();
            txtdayofmonth.Clear();
            txtyear.Clear();
            dateoutput.Text = " ";
        }
    }
}
