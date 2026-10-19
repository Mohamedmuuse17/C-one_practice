namespace vehicle_rental_managment_system
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
            lblage = new Label();
            lbldays = new Label();
            lblexperience = new Label();
            lblinformation = new Label();
            txtname = new TextBox();
            txtage = new TextBox();
            txtdays = new TextBox();
            txtexperience = new TextBox();
            lbltype = new Label();
            rdoeconomy = new RadioButton();
            rdosuv = new RadioButton();
            rdoluxury = new RadioButton();
            lbloption = new Label();
            chkinsurance = new CheckBox();
            btncalculate = new Button();
            btnclear = new Button();
            btnexit = new Button();
            lstresults = new ListBox();
            SuspendLayout();
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(33, 39);
            lblname.Name = "lblname";
            lblname.Size = new Size(90, 15);
            lblname.TabIndex = 0;
            lblname.Text = "customer name";
            // 
            // lblage
            // 
            lblage.AutoSize = true;
            lblage.Location = new Point(33, 75);
            lblage.Name = "lblage";
            lblage.Size = new Size(79, 15);
            lblage.TabIndex = 1;
            lblage.Text = "customer age";
            // 
            // lbldays
            // 
            lbldays.AutoSize = true;
            lbldays.Location = new Point(33, 108);
            lbldays.Name = "lbldays";
            lbldays.Size = new Size(123, 15);
            lbldays.TabIndex = 2;
            lbldays.Text = "number of rental days";
            // 
            // lblexperience
            // 
            lblexperience.AutoSize = true;
            lblexperience.Location = new Point(33, 141);
            lblexperience.Name = "lblexperience";
            lblexperience.Size = new Size(142, 15);
            lblexperience.TabIndex = 3;
            lblexperience.Text = "years of driving experince";
            // 
            // lblinformation
            // 
            lblinformation.AutoSize = true;
            lblinformation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblinformation.Location = new Point(33, 9);
            lblinformation.Name = "lblinformation";
            lblinformation.Size = new Size(129, 15);
            lblinformation.TabIndex = 4;
            lblinformation.Text = "customer information";
            // 
            // txtname
            // 
            txtname.Location = new Point(181, 31);
            txtname.Name = "txtname";
            txtname.Size = new Size(100, 23);
            txtname.TabIndex = 5;
            // 
            // txtage
            // 
            txtage.Location = new Point(181, 67);
            txtage.Name = "txtage";
            txtage.Size = new Size(100, 23);
            txtage.TabIndex = 6;
            // 
            // txtdays
            // 
            txtdays.Location = new Point(181, 105);
            txtdays.Name = "txtdays";
            txtdays.Size = new Size(100, 23);
            txtdays.TabIndex = 7;
            // 
            // txtexperience
            // 
            txtexperience.Location = new Point(181, 138);
            txtexperience.Name = "txtexperience";
            txtexperience.Size = new Size(100, 23);
            txtexperience.TabIndex = 8;
            // 
            // lbltype
            // 
            lbltype.AutoSize = true;
            lbltype.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltype.Location = new Point(27, 191);
            lbltype.Name = "lbltype";
            lbltype.Size = new Size(75, 15);
            lbltype.TabIndex = 9;
            lbltype.Text = "vehicle type";
            // 
            // rdoeconomy
            // 
            rdoeconomy.AutoSize = true;
            rdoeconomy.Location = new Point(47, 238);
            rdoeconomy.Name = "rdoeconomy";
            rdoeconomy.Size = new Size(75, 19);
            rdoeconomy.TabIndex = 10;
            rdoeconomy.TabStop = true;
            rdoeconomy.Text = "economy";
            rdoeconomy.UseVisualStyleBackColor = true;
            // 
            // rdosuv
            // 
            rdosuv.AutoSize = true;
            rdosuv.Location = new Point(144, 238);
            rdosuv.Name = "rdosuv";
            rdosuv.Size = new Size(43, 19);
            rdosuv.TabIndex = 11;
            rdosuv.TabStop = true;
            rdosuv.Text = "suv";
            rdosuv.UseVisualStyleBackColor = true;
            // 
            // rdoluxury
            // 
            rdoluxury.AutoSize = true;
            rdoluxury.Location = new Point(225, 238);
            rdoluxury.Name = "rdoluxury";
            rdoluxury.Size = new Size(58, 19);
            rdoluxury.TabIndex = 12;
            rdoluxury.TabStop = true;
            rdoluxury.Text = "luxury";
            rdoluxury.UseVisualStyleBackColor = true;
            // 
            // lbloption
            // 
            lbloption.AutoSize = true;
            lbloption.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbloption.Location = new Point(33, 278);
            lbloption.Name = "lbloption";
            lbloption.Size = new Size(99, 15);
            lbloption.TabIndex = 13;
            lbloption.Text = "insurance option";
            // 
            // chkinsurance
            // 
            chkinsurance.AutoSize = true;
            chkinsurance.Location = new Point(40, 315);
            chkinsurance.Name = "chkinsurance";
            chkinsurance.Size = new Size(177, 19);
            chkinsurance.TabIndex = 14;
            chkinsurance.Text = "add insurance ($115 per day)";
            chkinsurance.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            btncalculate.Location = new Point(57, 367);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(75, 23);
            btncalculate.TabIndex = 15;
            btncalculate.Text = "calculate";
            btncalculate.UseVisualStyleBackColor = true;
            btncalculate.Click += btncalculate_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(144, 367);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(75, 23);
            btnclear.TabIndex = 16;
            btnclear.Text = "clear";
            btnclear.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(236, 367);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(75, 23);
            btnexit.TabIndex = 17;
            btnexit.Text = "exit";
            btnexit.UseVisualStyleBackColor = true;
            // 
            // lstresults
            // 
            lstresults.FormattingEnabled = true;
            lstresults.ItemHeight = 15;
            lstresults.Location = new Point(541, 39);
            lstresults.Name = "lstresults";
            lstresults.Size = new Size(223, 304);
            lstresults.TabIndex = 18;
            lstresults.SelectedIndexChanged += lstresults_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstresults);
            Controls.Add(btnexit);
            Controls.Add(btnclear);
            Controls.Add(btncalculate);
            Controls.Add(chkinsurance);
            Controls.Add(lbloption);
            Controls.Add(rdoluxury);
            Controls.Add(rdosuv);
            Controls.Add(rdoeconomy);
            Controls.Add(lbltype);
            Controls.Add(txtexperience);
            Controls.Add(txtdays);
            Controls.Add(txtage);
            Controls.Add(txtname);
            Controls.Add(lblinformation);
            Controls.Add(lblexperience);
            Controls.Add(lbldays);
            Controls.Add(lblage);
            Controls.Add(lblname);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblname;
        private Label lblage;
        private Label lbldays;
        private Label lblexperience;
        private Label lblinformation;
        private TextBox txtname;
        private TextBox txtage;
        private TextBox txtdays;
        private TextBox txtexperience;
        private Label lbltype;
        private RadioButton rdoeconomy;
        private RadioButton rdosuv;
        private RadioButton rdoluxury;
        private Label lbloption;
        private CheckBox chkinsurance;
        private Button btncalculate;
        private Button btnclear;
        private Button btnexit;
        private ListBox lstresults;
    }
}
