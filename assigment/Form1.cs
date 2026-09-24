namespace assigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();

            // clearing label
            lbloutput.Text = "";
        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            // variables
            String studentName, studentdept, studentsem, Full_info;
            int StudentId;
            studentName = txtname.Text;
            StudentId = int.Parse(txtstudentid.Text);
            studentdept = txtdepartment.Text;
            studentsem = txtsemester.Text;
            Full_info = studentName + " " + StudentId + " " + studentdept + " " + studentsem;

            lbloutput.Text = Full_info;

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
