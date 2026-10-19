using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace hotel_room_booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblCalculate_Click(object sender, EventArgs e)
        {
            string name = txtGuestName.Text.Trim();

            int age, nights, guests;

            if (name == "")
            {
                MessageBox.Show("Guest name cannot be empty.");
                return;
            }

            if (!int.TryParse(txtAge.Text, out age) ||
                !int.TryParse(txtNights.Text, out nights) ||
                !int.TryParse(txtGuests.Text, out guests))
            {
                MessageBox.Show("Please enter valid numbers.");
                return;
            }

            if (age < 18 || age > 90)
            {
                MessageBox.Show("Age must be between 18 and 90.");
                return;
            }

            if (nights < 1 || nights > 30)
            {
                MessageBox.Show("Nights must be between 1 and 30.");
                return;
            }

            if (guests < 1 || guests > 6)
            {
                MessageBox.Show("Guests must be between 1 and 6.");
                return;
            }

            string roomType;
            double rate;
            int maxGuests;

            if (rdStandard.Checked)
            {
                roomType = "Standard";
                rate = 50;
                maxGuests = 2;
            }
            else if (rdNormal.Checked)
            {
                roomType = "Normal";
                rate = 80;
                maxGuests = 4;
            }
            else if (rdHight.Checked)
            {
                roomType = "High";
                rate = 130;
                maxGuests = 6;
            }
            else
            {
                MessageBox.Show("Please select a room type.");
                return;
            }

            bool approved = true;

            if (guests > maxGuests)
                approved = false;

            if (!approved)
            {
                MessageBox.Show("Booking rejected for this room.");
                rtbDetails.Text = "Booking Status: Rejected";
                return;
            }

            double basicCost = rate * nights;

            double discountRate = 0;

            if (nights >= 10)
                discountRate = 0.12;
            else if (nights >= 5)
                discountRate = 0.05;

            double discount = basicCost * discountRate;

            double seniorDiscount = 0;

            if (age >= 60)
                seniorDiscount = basicCost * 0.05;

            double breakfastCost = 0;

            if (chckbreakfast.Checked)
                breakfastCost = 10 * guests * nights;

            double subtotal = basicCost - discount
                              - seniorDiscount + breakfastCost;

            double serviceCharge = 0;

            if (guests > 4)
                serviceCharge = subtotal * 0.05;

            double finalCost = subtotal + serviceCharge;

            rtbDetails.Text =
                "HOTEL ROOM BOOKING DETAILS\n" +
                "------------------------------\n" +
                "Guest Name: " + name + "\n" +
                "Guest Age: " + age + "\n" +
                "Room Type: " + roomType + "\n" +
                "Rate Per Night: $" + rate.ToString("F2") + "\n" +
                "Number of Nights: " + nights + "\n" +
                "Number of Guests: " + guests + "\n" +
                "Basic Cost: $" + basicCost.ToString("F2") + "\n" +
                "Room Discount: $" + discount.ToString("F2") + "\n" +
                "Senior Discount: $" + seniorDiscount.ToString("F2") + "\n" +
                "Breakfast Cost: $" + breakfastCost.ToString("F2") + "\n" +
                "Service Charge: $" + serviceCharge.ToString("F2") + "\n" +
                "Final Cost: $" + finalCost.ToString("F2") + "\n" +
                "Booking Status: Approved";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGuestName.Clear();
            txtAge.Clear();
            txtNights.Clear();
            txtGuests.Clear();

            rdStandard.Checked = false;
            rdNormal.Checked = false;
            rdHight.Checked = false;

            chckbreakfast.Checked = false;
            rtbDetails.Clear();

            txtGuestName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
        
    
