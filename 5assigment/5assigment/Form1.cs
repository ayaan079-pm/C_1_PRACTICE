using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _5assigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void l_Click(object sender, EventArgs e)
        {

        }

        private void checkstandard_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lisboxbooking_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Variables
                string name = txtpassengername.Text.Trim();
                int age;
                int tickets;
                double baggage;
                double ticketPrice = 0;
                double total;
                double insurance = 0;

                // 2. Validate passenger name
                if (name == "" || int.TryParse(name, out _))
                {
                    MessageBox.Show("Enter a valid passenger name.");
                    txtpassengername.Focus();
                    return;
                }

                // 3. Validate age
                if (!int.TryParse(txtpassengerage.Text, out age) ||
                    age < 1 || age > 120)
                {
                    MessageBox.Show("Enter a valid age (1-120).");
                    txtpassengerage.Focus();
                    return;
                }

                // 4. Validate number of tickets
                if (!int.TryParse(txtnumberoftickets.Text, out tickets) ||
                    tickets < 1 || tickets > 10)
                {
                    MessageBox.Show("Enter tickets between 1 and 10.");
                    txtnumberoftickets.Focus();
                    return;
                }

                // 5. Validate baggage weight
                if (!double.TryParse(txtnumberbaggage.Text, out baggage) ||
                    baggage < 0)
                {
                    MessageBox.Show("Enter a valid baggage weight.");
                    txtnumberbaggage.Focus();
                    return;
                }

                // 6. Decision structure: Travel class
                if (checkfirstclass.Checked)
                {
                    ticketPrice = 500;
                }
                else if (checkednormalclass.Checked)
                {
                    ticketPrice = 250;
                }
                else if (checkedbusiness.Checked)
                {
                    ticketPrice = 400;
                }
                else
                {
                    MessageBox.Show("Please select a travel class.");
                    return;
                }

                // 7. Calculate ticket cost
                total = ticketPrice * tickets;

                // 8. Optional travel insurance ($25 per ticket)
                if (checktravel.Checked)
                {
                    insurance = 25 * tickets;
                }

                total = total + insurance;

                // 9. Display results in ListBox
                Airlinebookingdetails.Items.Clear();
                Airlinebookingdetails.Items.Add("AIRLINE BOOKING DETAILS");
                Airlinebookingdetails.Items.Add("----------------------------");
                Airlinebookingdetails.Items.Add("Passenger: " + name);
                Airlinebookingdetails.Items.Add("Age: " + age);
                Airlinebookingdetails.Items.Add("Number of Tickets: " + tickets);
                Airlinebookingdetails.Items.Add("Baggage Weight: " + baggage + " kg");

                Airlinebookingdetails.Items.Add("Travel Class: " +
                    (checkfirstclass.Checked ? "First Class" :
                    checkednormalclass.Checked ? "Normal Class" :
                    "Business Class"));

                Airlinebookingdetails.Items.Add("Ticket Price: $" + ticketPrice);
                Airlinebookingdetails.Items.Add("Insurance: $" + insurance);
                Airlinebookingdetails.Items.Add("Total Amount: $" + total);

                MessageBox.Show("Booking calculated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void checkedhight_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
        
    

