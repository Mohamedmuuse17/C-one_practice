namespace assigmen_hotel
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
            lblGuestName = new Label();
            lblRoomType = new Label();
            lblEnterNumberOfNights = new Label();
            lblPricePerNight = new Label();
            txtGuestName = new TextBox();
            txtRoomType = new TextBox();
            txtNight = new TextBox();
            txtPricePerNight = new TextBox();
            btncClculate = new Button();
            lblServiceTax = new Label();
            lblDiscountAmount = new Label();
            lblTotalAmount = new Label();
            txtServiceTax = new TextBox();
            txtDiscountAmount = new TextBox();
            txtTotalAmount = new TextBox();
            SuspendLayout();
            // 
            // lblGuestName
            // 
            lblGuestName.AutoSize = true;
            lblGuestName.Location = new Point(56, 50);
            lblGuestName.Name = "lblGuestName";
            lblGuestName.Size = new Size(99, 15);
            lblGuestName.TabIndex = 0;
            lblGuestName.Text = "enter guest name";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Location = new Point(56, 79);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(92, 15);
            lblRoomType.TabIndex = 1;
            lblRoomType.Text = "enter room type";
            // 
            // lblEnterNumberOfNights
            // 
            lblEnterNumberOfNights.AutoSize = true;
            lblEnterNumberOfNights.Location = new Point(56, 108);
            lblEnterNumberOfNights.Name = "lblEnterNumberOfNights";
            lblEnterNumberOfNights.Size = new Size(129, 15);
            lblEnterNumberOfNights.TabIndex = 2;
            lblEnterNumberOfNights.Text = "enter number of nights";
            // 
            // lblPricePerNight
            // 
            lblPricePerNight.AutoSize = true;
            lblPricePerNight.Location = new Point(56, 135);
            lblPricePerNight.Name = "lblPricePerNight";
            lblPricePerNight.Size = new Size(114, 15);
            lblPricePerNight.TabIndex = 3;
            lblPricePerNight.Text = "enter price per night";
            // 
            // txtGuestName
            // 
            txtGuestName.Location = new Point(196, 42);
            txtGuestName.Name = "txtGuestName";
            txtGuestName.Size = new Size(100, 23);
            txtGuestName.TabIndex = 4;
            // 
            // txtRoomType
            // 
            txtRoomType.Location = new Point(196, 71);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.Size = new Size(100, 23);
            txtRoomType.TabIndex = 5;
            // 
            // txtNight
            // 
            txtNight.Location = new Point(196, 100);
            txtNight.Name = "txtNight";
            txtNight.Size = new Size(100, 23);
            txtNight.TabIndex = 6;
            // 
            // txtPricePerNight
            // 
            txtPricePerNight.Location = new Point(196, 135);
            txtPricePerNight.Name = "txtPricePerNight";
            txtPricePerNight.Size = new Size(100, 23);
            txtPricePerNight.TabIndex = 7;
            // 
            // btncClculate
            // 
            btncClculate.Location = new Point(108, 164);
            btncClculate.Name = "btncClculate";
            btncClculate.Size = new Size(153, 37);
            btncClculate.TabIndex = 8;
            btncClculate.Text = "calculate banking";
            btncClculate.UseVisualStyleBackColor = true;
            btncClculate.Click += btncClculate_Click;
            // 
            // lblServiceTax
            // 
            lblServiceTax.AutoSize = true;
            lblServiceTax.Location = new Point(56, 222);
            lblServiceTax.Name = "lblServiceTax";
            lblServiceTax.Size = new Size(62, 15);
            lblServiceTax.TabIndex = 9;
            lblServiceTax.Text = "service tax";
            // 
            // lblDiscountAmount
            // 
            lblDiscountAmount.AutoSize = true;
            lblDiscountAmount.Location = new Point(56, 247);
            lblDiscountAmount.Name = "lblDiscountAmount";
            lblDiscountAmount.Size = new Size(98, 15);
            lblDiscountAmount.TabIndex = 10;
            lblDiscountAmount.Text = "discount amount";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(56, 271);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(76, 15);
            lblTotalAmount.TabIndex = 11;
            lblTotalAmount.Text = "total amount";
            // 
            // txtServiceTax
            // 
            txtServiceTax.Location = new Point(180, 214);
            txtServiceTax.Name = "txtServiceTax";
            txtServiceTax.Size = new Size(100, 23);
            txtServiceTax.TabIndex = 12;
            // 
            // txtDiscountAmount
            // 
            txtDiscountAmount.Location = new Point(180, 247);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.Size = new Size(100, 23);
            txtDiscountAmount.TabIndex = 13;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(180, 276);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(100, 23);
            txtTotalAmount.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTotalAmount);
            Controls.Add(txtDiscountAmount);
            Controls.Add(txtServiceTax);
            Controls.Add(lblTotalAmount);
            Controls.Add(lblDiscountAmount);
            Controls.Add(lblServiceTax);
            Controls.Add(btncClculate);
            Controls.Add(txtPricePerNight);
            Controls.Add(txtNight);
            Controls.Add(txtRoomType);
            Controls.Add(txtGuestName);
            Controls.Add(lblPricePerNight);
            Controls.Add(lblEnterNumberOfNights);
            Controls.Add(lblRoomType);
            Controls.Add(lblGuestName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGuestName;
        private Label lblRoomType;
        private Label lblEnterNumberOfNights;
        private Label lblPricePerNight;
        private TextBox txtGuestName;
        private TextBox txtRoomType;
        private TextBox txtNight;
        private TextBox txtPricePerNight;
        private Button btncClculate;
        private Label lblServiceTax;
        private Label lblDiscountAmount;
        private Label lblTotalAmount;
        private TextBox txtServiceTax;
        private TextBox txtDiscountAmount;
        private TextBox txtTotalAmount;
    }
}
