namespace assigmen_hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // get number of nights
            double nights = double.Parse(lblEnterNumberOfNights.Text);
            //get price per night
            double pricePerNight = double.Parse(txtPricePerNight.Text);
           // btnCalculate_Click the basic
            double subtotal = nights * pricePerNight;
            //calculate 10 servie tax
            double serviceTax = subtotal * 0.10;
            //calculate 55 discount
            double discount = subtotal * 0.05;
            //calculate final total amount

            double totalAmount = subtotal + serviceTax - discount;
            //display service tax

            lblServiceTax.Text = serviceTax.ToString("C2");
            //displatt discount amount
            lblDiscountAmount.Text = discount.ToString("C2");
            //dispaly total amount
            lblTotalAmount.Text = totalAmount.ToString("C2");
        }

    }
    }

