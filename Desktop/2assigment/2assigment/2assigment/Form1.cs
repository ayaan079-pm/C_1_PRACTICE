using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2assigment
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

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            string name, department, semester, showinformation;
            int studentid;
            name = txtname.Text;
            studentid = int.Parse(txtstudentid.Text);
            department = txtdepartment.Text;
            semester = txtsemester.Text;

            showinformation = name + " " + studentid + " " + department + " " + semester;

            lbloutput.Text = showinformation;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();
            lbloutput.Text = "";

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
