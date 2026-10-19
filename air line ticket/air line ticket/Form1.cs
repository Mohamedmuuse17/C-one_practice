using System.Xml.Linq;

namespace air_line_ticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblcalculate_Click(object sender, EventArgs e)
        {
            // Get input values using TryParse
            int age, tickets;
            double baggage;

            if (string.IsNullOrWhiteSpace(txtpassengername.Text))
            {
                MessageBox.Show("Please enter passenger name.");
                return;
            }

            if (!int.TryParse(txtpassengerage.Text, out age) ||
                age < 1 || age > 100)
            {
                MessageBox.Show("Age must be between 1 and 100.");
                return;
            }

            if (!int.TryParse(txtnumberoftickets.Text, out tickets) ||
                tickets < 1 || tickets > 5)
            {
                MessageBox.Show("Tickets must be between 1 and 5.");
                return;
            }

            if (!double.TryParse(txtbaggageweight.Text, out baggage) ||
                baggage < 0 || baggage > 50 * tickets)
            {
                MessageBox.Show(
                    "Baggage cannot exceed 50 kg per passenger.");
                return;
            }

            // Select travel class and ticket price
            double ticketPrice;

            if (rdfirstclass.Checked)
            {
                if (age < 12)
                {
                    MessageBox.Show(
                        "Passengers below 12 cannot book First Class.");
                    return;
                }

                ticketPrice = 200;
            }
            else if (rdnormalclass.Checked)
            {
                ticketPrice = 100;
            }
            else if (rdbuisnessclass.Checked)
            {
                ticketPrice = 300;
            }
            else
            {
                MessageBox.Show("Please select a travel class.");
                return;
            }

            // Basic ticket cost
            double basicCost = ticketPrice * tickets;

            // Ticket quantity discount
            double ticketDiscount = 0;

            if (tickets >= 5)
                ticketDiscount = 0.10;
            else if (tickets >= 3)
                ticketDiscount = 0.05;

            double discountAmount = basicCost * ticketDiscount;

            // Child or senior discount
            double ageDiscount = 0;

            if (age < 12)
                ageDiscount = 0.20;
            else if (age >= 60)
                ageDiscount = 0.10;

            double ageDiscountAmount =
                (basicCost - discountAmount) * ageDiscount;

            // Insurance: $25 per ticket
            double insuranceCost = 0;

            if (chkInsurance.Checked)
                insuranceCost = 25 * tickets;

            // Final cost
            double totalDiscount =
                discountAmount + ageDiscountAmount;

            double finalCost =
                basicCost - totalDiscount + insuranceCost;

            // Display booking details
            ricTextairlinebookingcalculate.Clear();

            ricTextairlinebookingcalculate.AppendText("AIRLINE TICKET BOOKING\n");
            ricTextairlinebookingcalculate.AppendText("------------------------------\n");
            ricTextairlinebookingcalculate.AppendText("Passenger: " + txtpassengername.Text + "\n");
            ricTextairlinebookingcalculate.AppendText("Age: " + age + "\n");
            ricTextairlinebookingcalculate.AppendText("Number of tickets: " + tickets + "\n");
            ricTextairlinebookingcalculate.AppendText("Baggage weight: " + baggage + " kg\n");

            string travelClass = rdfirstclass.Checked
                ? "First Class"
                : rdbuisnessclass.Checked
                    ? "Normal Class"
                    : "Business Class";

            ricTextairlinebookingcalculate.AppendText("Travel class: " + travelClass + "\n");
            ricTextairlinebookingcalculate.AppendText(
                "Ticket price: $" + ticketPrice.ToString("F2") + "\n");
            ricTextairlinebookingcalculate.AppendText(
                "Basic cost: $" + basicCost.ToString("F2") + "\n");
            ricTextairlinebookingcalculate.AppendText(
                "Ticket discount: $" + discountAmount.ToString("F2") + "\n");
            ricTextairlinebookingcalculate.AppendText(
                "Age discount: $" + ageDiscountAmount.ToString("F2") + "\n");
            ricTextairlinebookingcalculate.AppendText(
                "Insurance: $" + insuranceCost.ToString("F2") + "\n");
            ricTextairlinebookingcalculate.AppendText("------------------------------\n");
            ricTextairlinebookingcalculate.AppendText(
                "TOTAL COST: $" + finalCost.ToString("F2") + "\n");
            ricTextairlinebookingcalculate.AppendText("Booking Approved!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtpassengername.Clear();
            txtpassengerage.Clear();
            txtnumberoftickets.Clear();
            txtbaggageweight.Clear();

            rdfirstclass.Checked = false;
            rdnormalclass.Checked = false;
            rdbuisnessclass.Checked = false;
            chkInsurance.Checked = false;

            ricTextairlinebookingcalculate.Clear();
            txtpassengername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
        
