using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {

            // creating variables
            int numberofPackages;
            double price;
            double subTotal;
            double DiscountRate = 0;
            double DiscountAmount = 0;
            double TotalAmount;

            if (!int.TryParse(txtnumberofpackage.Text, out numberofPackages) ||
               !double.TryParse(txtpriceperpackage.Text, out price))
            {
                MessageBox.Show("Please input numeric data");
                return;
            }

            if (numberofPackages <= 0 || price <= 0)
            {
                MessageBox.Show("Cant be negative");


            }

            subTotal = numberofPackages * price;


            if (numberofPackages >= 10 && numberofPackages <= 19)
            {
                DiscountAmount = subTotal * 0.2;
                DiscountRate = 20;
            }
            else if (numberofPackages >= 20 && numberofPackages <= 49)
            {
                DiscountAmount = subTotal * 0.3;
                DiscountRate = 30;
            }
            else if (numberofPackages >= 50 && numberofPackages <= 99)
            {
                DiscountAmount = subTotal * 0.4;
                DiscountRate = 40;
            }
            else if (numberofPackages >= 100)
            {
                DiscountAmount = subTotal * 0.5;
                DiscountRate = 50;
            }
            TotalAmount = subTotal - DiscountAmount;

            lstpurchase.Items.Add("Number of Packages: " + numberofPackages);
            lstpurchase.Items.Add("Price per package:" + price);
            lstpurchase.Items.Add("Subtotal (before discount):" + subTotal);
            lstpurchase.Items.Add("Discount Rate:" + DiscountRate);
            lstpurchase.Items.Add("Discount Amount:" + DiscountAmount);
            lstpurchase.Items.Add("Total Amount after discount:" + TotalAmount);
        }


        

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtnumberofpackage.Text = "";
            txtpriceperpackage.Text = "";

            lstpurchase.Items.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

