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

namespace assigment.files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnwriteline_Click(object sender, EventArgs e)
        {
            // Create a new file
            StreamWriter lines = File.CreateText("myfile.desktop");

            // Write text line by line
            lines.WriteLine("Welcome to Jamhuuriya");
            lines.WriteLine("Class CA244");
            lines.WriteLine("This is my first project");

            // Close the file
            lines.Close();

            MessageBox.Show("File created successfully!");
        }

        private async void btnWriteAsync_Click(object sender, EventArgs e)
        {
            // Check if file exists
            if (File.Exists("myfile.desktop"))
            {
                // Open file for appending
                using (StreamWriter lines = File.AppendText("myfile.desktop"))
                {
                    // Write text asynchronously
                    await lines.WriteLineAsync("Welcome to C#");
                    await lines.WriteLineAsync("File Handling");
                }

                MessageBox.Show("Writing completed!");
            }
            else
            {
                MessageBox.Show("File not found!");
            }

        }

        private void btnWriteAllText_Click(object sender, EventArgs e)
        {
            // Write all text into the file
            File.WriteAllText("myfile.desktop",
                "Welcome to Jamhuuriya\n" +
                "Class CA244\n" +
                "File Handling Project");

            MessageBox.Show("Text written successfully!");
        }

        private void btnreadline_Click(object sender, EventArgs e)
        {
            // Check if file exists
            if (File.Exists("myfile.desktop"))
            {
                listBox1.Items.Clear();

                // Read file line by line
                foreach (string line in File.ReadLines("myfile.desktop"))
                {
                    listBox1.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            // Check if file exists
            if (File.Exists("myfile.desktop"))
            {
                // Read all lines
                string[] lines = File.ReadAllLines("myfile.desktop");

                listBox1.Items.Clear();

                // Display all lines
                foreach (string line in lines)
                {
                    listBox1.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }
        

        private void btnreadblock_Click(object sender, EventArgs e)
        { 

            // Clear ListBox
            listBox1.Items.Clear();

            // Check if file exists
            if (File.Exists("myfile.desktop"))
            {
                using (StreamReader reader = File.OpenText("myfile.desktop"))
                {
                    // Create character array
                    char[] buffer = new char[20];

                    // Read 20 characters
                    int count = reader.ReadBlock(buffer, 0, 20);

                    // Convert characters to string
                    string blockText = new string(buffer, 0, count);

                    // Display text
                    listBox1.Items.Add(blockText);
                }
            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }

        private void btnDeleteOneItem_Click(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (listBox1.SelectedIndex != -1)
            {
                // Remove selected item
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                MessageBox.Show("One item deleted!");
            }
            else
            {
                MessageBox.Show("Please select one item!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Check if file exists
            if (File.Exists("myfile.desktop"))
            {
                // Delete the file
                File.Delete("myfile.desktop");

                // Clear ListBox
                listBox1.Items.Clear();

                MessageBox.Show("File deleted successfully!");
            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Clear all ListBox items
            listBox1.Items.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            // Close application
            this.Close();
        }
    }
    }
    
    
        
    

    

