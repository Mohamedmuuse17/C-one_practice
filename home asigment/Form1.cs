namespace home_asigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            //stage of input
            //creating variables
            String day_of_the_week, Name_of_the_month, NumericDay, Year,
                Fulldate;
            //initial values to variables
            day_of_the_week =
                dayOfWeekTextBox.Text;
            Name_of_the_month =
               monthTextBox.Text;
            NumericDay =
               dayOfMonthTextBox.Text;

            Year = yearTextBox.Text;

            //stage process concatination of full date 
            Fulldate = day_of_the_week + "," +
                Name_of_the_month + "," + NumericDay + "," + Year;
            // stage 3: the output

            dateOutputlabel.Text = Fulldate;


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clearing textbox
            dayOfWeekTextBox.Clear();
            monthTextBox.Clear();
            dayOfMonthTextBox.Clear();
            yearTextBox.Clear();
            // clearing label - not used function
            dateOutputlabel.Text = "";
            //lbloutput.Text = string.Empty;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
