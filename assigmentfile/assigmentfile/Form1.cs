using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigmentfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //creatingfiles


            StreamWriter lines;
            // Write text inside the file
            lines = File.CreateText("myfile.desktop");
            lines.WriteLine("ether functions of reading include");
            lines.WriteLine("welcome to jamhuuriya");
            lines.WriteLine("class ca244");
            lines.WriteLine("this is my first project");
            MessageBox.Show("File successfully created and written!");

            //closing the lines

            lines.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the file exists 

            if (File.Exists("myfile.desktop"))

                // loop using foreach
            {
                foreach (string line in File.ReadLines("myfile.desktop"))
                {
                    listBox1.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("File not found Please click 'WriteLine' first ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            if (File.Exists("myfile.desktop"))
            {
                string[] lines = File.ReadAllLines("myfile.desktop");

                foreach (string line in lines)
                {
                    listBox1.Items.Add(line);
                }
            }

            else
            {
                MessageBox.Show("File not found Please click 'WriteLine' first");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // Check if the file exists
            if (File.Exists("myfile.desktop"))
            {
                using (StreamReader reader = File.OpenText("myfile.desktop"))
                {
                    char[] buffer = new char[20];
                    int count = reader.ReadBlock(buffer, 0, 20);
                    string blockText = new string(buffer, 0, count);
                    listBox1.Items.Add(blockText);
                }
            }
            else
            {
                MessageBox.Show("File not found Please click 'WriteLine' first");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
              listBox1.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Check if the file exists
            if (File.Exists("myfile.desktop"))
            {
                File.Delete("myfile.desktop");
                listBox1.Items.Clear();
                MessageBox.Show(".file is clear");
            }
            else
            {
                MessageBox.Show("File not found");
            }
        }

        private void button4_Click(object sender, EventArgs e)
            // exit
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
            // clear listbox1
        {
            listBox1.Items.Clear();
        }
    }
}
