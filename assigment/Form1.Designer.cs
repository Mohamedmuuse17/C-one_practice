namespace assigment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblname = new Label();
            lblstudentid = new Label();
            lbldepartment = new Label();
            lblsemester = new Label();
            txtname = new TextBox();
            txtstudentid = new TextBox();
            txtdepartment = new TextBox();
            txtsemester = new TextBox();
            btnshowinfo = new Button();
            btnclear = new Button();
            btnexit = new Button();
            label1 = new Label();
            lbloutput = new Label();
            SuspendLayout();
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(35, 28);
            lblname.Name = "lblname";
            lblname.Size = new Size(130, 15);
            lblname.TabIndex = 0;
            lblname.Text = "enter the student name";
            // 
            // lblstudentid
            // 
            lblstudentid.AutoSize = true;
            lblstudentid.Location = new Point(35, 58);
            lblstudentid.Name = "lblstudentid";
            lblstudentid.Size = new Size(110, 15);
            lblstudentid.TabIndex = 1;
            lblstudentid.Text = "enter the student id";
            // 
            // lbldepartment
            // 
            lbldepartment.AutoSize = true;
            lbldepartment.Location = new Point(35, 94);
            lbldepartment.Name = "lbldepartment";
            lbldepartment.Size = new Size(119, 15);
            lbldepartment.TabIndex = 2;
            lbldepartment.Text = "enter the department";
            // 
            // lblsemester
            // 
            lblsemester.AutoSize = true;
            lblsemester.Location = new Point(35, 129);
            lblsemester.Name = "lblsemester";
            lblsemester.Size = new Size(104, 15);
            lblsemester.TabIndex = 3;
            lblsemester.Text = "enter the semester";
            // 
            // txtname
            // 
            txtname.Location = new Point(200, 25);
            txtname.Name = "txtname";
            txtname.Size = new Size(100, 23);
            txtname.TabIndex = 4;
            // 
            // txtstudentid
            // 
            txtstudentid.Location = new Point(200, 58);
            txtstudentid.Name = "txtstudentid";
            txtstudentid.Size = new Size(100, 23);
            txtstudentid.TabIndex = 5;
            // 
            // txtdepartment
            // 
            txtdepartment.Location = new Point(200, 94);
            txtdepartment.Name = "txtdepartment";
            txtdepartment.Size = new Size(100, 23);
            txtdepartment.TabIndex = 6;
            // 
            // txtsemester
            // 
            txtsemester.Location = new Point(200, 129);
            txtsemester.Name = "txtsemester";
            txtsemester.Size = new Size(100, 23);
            txtsemester.TabIndex = 7;
            // 
            // btnshowinfo
            // 
            btnshowinfo.Location = new Point(57, 245);
            btnshowinfo.Name = "btnshowinfo";
            btnshowinfo.Size = new Size(160, 23);
            btnshowinfo.TabIndex = 8;
            btnshowinfo.Text = "show information";
            btnshowinfo.UseVisualStyleBackColor = true;
            btnshowinfo.Click += btnshowinfo_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(244, 245);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(75, 23);
            btnclear.TabIndex = 9;
            btnclear.Text = "clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += button2_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(344, 245);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(75, 23);
            btnexit.TabIndex = 10;
            btnexit.Text = "exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 181);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 11;
            // 
            // lbloutput
            // 
            lbloutput.BorderStyle = BorderStyle.FixedSingle;
            lbloutput.Location = new Point(35, 167);
            lbloutput.Name = "lbloutput";
            lbloutput.Size = new Size(265, 42);
            lbloutput.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 398);
            Controls.Add(lbloutput);
            Controls.Add(label1);
            Controls.Add(btnexit);
            Controls.Add(btnclear);
            Controls.Add(btnshowinfo);
            Controls.Add(txtsemester);
            Controls.Add(txtdepartment);
            Controls.Add(txtstudentid);
            Controls.Add(txtname);
            Controls.Add(lblsemester);
            Controls.Add(lbldepartment);
            Controls.Add(lblstudentid);
            Controls.Add(lblname);
            Name = "Form1";
            Text = "clear";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblname;
        private Label lblstudentid;
        private Label lbldepartment;
        private Label lblsemester;
        private TextBox txtname;
        private TextBox txtstudentid;
        private TextBox txtdepartment;
        private TextBox txtsemester;
        private Button btnshowinfo;
        private Button btnclear;
        private Button btnexit;
        private Label label1;
        private Label lbloutput;
    }
}
