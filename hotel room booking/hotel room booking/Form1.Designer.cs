namespace hotel_room_booking
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
            printDialog1 = new PrintDialog();
            txtGuests = new TextBox();
            lblroomtype = new Label();
            txtNights = new TextBox();
            rdStandard = new RadioButton();
            txtAge = new TextBox();
            rdNormal = new RadioButton();
            lblNumberOfGuest = new Label();
            lblAdditionalOptions = new Label();
            lblGuestAge = new Label();
            lblNumberOfNights = new Label();
            lblCalculate = new Label();
            lblClear = new Label();
            lblExit = new Label();
            chckbreakfast = new CheckBox();
            txtGuestName = new TextBox();
            rdHight = new RadioButton();
            lblGuestName = new Label();
            lblPersonalInforation = new Label();
            rtbDetails = new RichTextBox();
            SuspendLayout();
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // txtGuests
            // 
            txtGuests.Location = new Point(166, 230);
            txtGuests.Margin = new Padding(3, 4, 3, 4);
            txtGuests.Name = "txtGuests";
            txtGuests.Size = new Size(114, 27);
            txtGuests.TabIndex = 8;
            // 
            // lblroomtype
            // 
            lblroomtype.AutoSize = true;
            lblroomtype.Location = new Point(35, 290);
            lblroomtype.Name = "lblroomtype";
            lblroomtype.Size = new Size(78, 20);
            lblroomtype.TabIndex = 9;
            lblroomtype.Text = "room type";
            // 
            // txtNights
            // 
            txtNights.Location = new Point(166, 185);
            txtNights.Margin = new Padding(3, 4, 3, 4);
            txtNights.Name = "txtNights";
            txtNights.Size = new Size(114, 27);
            txtNights.TabIndex = 7;
            // 
            // rdStandard
            // 
            rdStandard.AutoSize = true;
            rdStandard.Location = new Point(59, 314);
            rdStandard.Margin = new Padding(3, 4, 3, 4);
            rdStandard.Name = "rdStandard";
            rdStandard.Size = new Size(85, 24);
            rdStandard.TabIndex = 10;
            rdStandard.TabStop = true;
            rdStandard.Text = "standard";
            rdStandard.UseVisualStyleBackColor = true;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(166, 149);
            txtAge.Margin = new Padding(3, 4, 3, 4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(114, 27);
            txtAge.TabIndex = 6;
            // 
            // rdNormal
            // 
            rdNormal.AutoSize = true;
            rdNormal.Location = new Point(152, 314);
            rdNormal.Margin = new Padding(3, 4, 3, 4);
            rdNormal.Name = "rdNormal";
            rdNormal.Size = new Size(74, 24);
            rdNormal.TabIndex = 11;
            rdNormal.TabStop = true;
            rdNormal.Text = "normal";
            rdNormal.UseVisualStyleBackColor = true;
            // 
            // lblNumberOfGuest
            // 
            lblNumberOfGuest.AutoSize = true;
            lblNumberOfGuest.Location = new Point(12, 230);
            lblNumberOfGuest.Name = "lblNumberOfGuest";
            lblNumberOfGuest.Size = new Size(125, 20);
            lblNumberOfGuest.TabIndex = 4;
            lblNumberOfGuest.Text = "Number of guest ";
            // 
            // lblAdditionalOptions
            // 
            lblAdditionalOptions.AutoSize = true;
            lblAdditionalOptions.Location = new Point(47, 353);
            lblAdditionalOptions.Name = "lblAdditionalOptions";
            lblAdditionalOptions.Size = new Size(131, 20);
            lblAdditionalOptions.TabIndex = 13;
            lblAdditionalOptions.Text = "additional options";
            // 
            // lblGuestAge
            // 
            lblGuestAge.AutoSize = true;
            lblGuestAge.Location = new Point(19, 156);
            lblGuestAge.Name = "lblGuestAge";
            lblGuestAge.Size = new Size(74, 20);
            lblGuestAge.TabIndex = 3;
            lblGuestAge.Text = "guest age";
            // 
            // lblNumberOfNights
            // 
            lblNumberOfNights.AutoSize = true;
            lblNumberOfNights.Location = new Point(19, 192);
            lblNumberOfNights.Name = "lblNumberOfNights";
            lblNumberOfNights.Size = new Size(125, 20);
            lblNumberOfNights.TabIndex = 2;
            lblNumberOfNights.Text = "Number of nights";
            // 
            // lblCalculate
            // 
            lblCalculate.AutoSize = true;
            lblCalculate.Location = new Point(95, 428);
            lblCalculate.Name = "lblCalculate";
            lblCalculate.Size = new Size(68, 20);
            lblCalculate.TabIndex = 15;
            lblCalculate.Text = "calculate";
            lblCalculate.Click += lblCalculate_Click;
            // 
            // lblClear
            // 
            lblClear.AutoSize = true;
            lblClear.Location = new Point(185, 428);
            lblClear.Name = "lblClear";
            lblClear.Size = new Size(41, 20);
            lblClear.TabIndex = 16;
            lblClear.Text = "clear";
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Location = new Point(247, 428);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(33, 20);
            lblExit.TabIndex = 17;
            lblExit.Text = "exit";
            // 
            // chckbreakfast
            // 
            chckbreakfast.AutoSize = true;
            chckbreakfast.Location = new Point(76, 386);
            chckbreakfast.Margin = new Padding(3, 4, 3, 4);
            chckbreakfast.Name = "chckbreakfast";
            chckbreakfast.Size = new Size(253, 24);
            chckbreakfast.TabIndex = 14;
            chckbreakfast.Text = "break fast (10 per guest per night)";
            chckbreakfast.UseVisualStyleBackColor = true;
            // 
            // txtGuestName
            // 
            txtGuestName.Location = new Point(166, 111);
            txtGuestName.Margin = new Padding(3, 4, 3, 4);
            txtGuestName.Name = "txtGuestName";
            txtGuestName.Size = new Size(114, 27);
            txtGuestName.TabIndex = 5;
            // 
            // rdHight
            // 
            rdHight.AutoSize = true;
            rdHight.Location = new Point(232, 314);
            rdHight.Margin = new Padding(3, 4, 3, 4);
            rdHight.Name = "rdHight";
            rdHight.Size = new Size(61, 24);
            rdHight.TabIndex = 12;
            rdHight.TabStop = true;
            rdHight.Text = "hight";
            rdHight.UseVisualStyleBackColor = true;
            // 
            // lblGuestName
            // 
            lblGuestName.AutoSize = true;
            lblGuestName.Location = new Point(26, 118);
            lblGuestName.Name = "lblGuestName";
            lblGuestName.Size = new Size(87, 20);
            lblGuestName.TabIndex = 1;
            lblGuestName.Text = "Guest name";
            // 
            // lblPersonalInforation
            // 
            lblPersonalInforation.AutoSize = true;
            lblPersonalInforation.Location = new Point(30, 76);
            lblPersonalInforation.Name = "lblPersonalInforation";
            lblPersonalInforation.Size = new Size(148, 20);
            lblPersonalInforation.TabIndex = 0;
            lblPersonalInforation.Text = "personal information";
            // 
            // rtbDetails
            // 
            rtbDetails.Location = new Point(576, 56);
            rtbDetails.Name = "rtbDetails";
            rtbDetails.Size = new Size(229, 317);
            rtbDetails.TabIndex = 19;
            rtbDetails.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(rtbDetails);
            Controls.Add(lblExit);
            Controls.Add(lblClear);
            Controls.Add(lblCalculate);
            Controls.Add(chckbreakfast);
            Controls.Add(lblAdditionalOptions);
            Controls.Add(rdHight);
            Controls.Add(rdNormal);
            Controls.Add(rdStandard);
            Controls.Add(lblroomtype);
            Controls.Add(txtGuests);
            Controls.Add(txtNights);
            Controls.Add(txtAge);
            Controls.Add(txtGuestName);
            Controls.Add(lblNumberOfGuest);
            Controls.Add(lblGuestAge);
            Controls.Add(lblNumberOfNights);
            Controls.Add(lblGuestName);
            Controls.Add(lblPersonalInforation);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PrintDialog printDialog1;
        private TextBox txtGuests;
        private Label lblroomtype;
        private TextBox txtNights;
        private RadioButton rdStandard;
        private TextBox txtAge;
        private RadioButton rdNormal;
        private Label lblNumberOfGuest;
        private Label lblAdditionalOptions;
        private Label lblGuestAge;
        private Label lblNumberOfNights;
        private Label lblCalculate;
        private Label lblClear;
        private Label lblExit;
        private CheckBox chckbreakfast;
        private TextBox txtGuestName;
        private RadioButton rdHight;
        private Label lblGuestName;
        private Label lblPersonalInforation;
        private RichTextBox rtbDetails;
    }
}
