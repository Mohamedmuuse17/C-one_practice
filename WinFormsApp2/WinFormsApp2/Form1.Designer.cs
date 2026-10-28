namespace WinFormsApp2
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
            groupBox1 = new GroupBox();
            btnexit = new Button();
            btnclear = new Button();
            btncalculate = new Button();
            txtpriceperpackage = new TextBox();
            txtnumberofpackage = new TextBox();
            lblpriceperpackage = new Label();
            lblnumberofpackage = new Label();
            lstpurchase = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnexit);
            groupBox1.Controls.Add(btnclear);
            groupBox1.Controls.Add(btncalculate);
            groupBox1.Controls.Add(txtpriceperpackage);
            groupBox1.Controls.Add(txtnumberofpackage);
            groupBox1.Controls.Add(lblpriceperpackage);
            groupBox1.Controls.Add(lblnumberofpackage);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 385);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "purchase information";
            // 
            // btnexit
            // 
            btnexit.Location = new Point(226, 147);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(75, 23);
            btnexit.TabIndex = 6;
            btnexit.Text = "exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(126, 147);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(75, 23);
            btnclear.TabIndex = 5;
            btnclear.Text = "clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btncalculate
            // 
            btncalculate.Location = new Point(24, 147);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(75, 23);
            btncalculate.TabIndex = 4;
            btncalculate.Text = "calculate";
            btncalculate.UseVisualStyleBackColor = true;
            btncalculate.Click += btncalculate_Click;
            // 
            // txtpriceperpackage
            // 
            txtpriceperpackage.Location = new Point(201, 85);
            txtpriceperpackage.Name = "txtpriceperpackage";
            txtpriceperpackage.Size = new Size(100, 23);
            txtpriceperpackage.TabIndex = 3;
            // 
            // txtnumberofpackage
            // 
            txtnumberofpackage.Location = new Point(201, 44);
            txtnumberofpackage.Name = "txtnumberofpackage";
            txtnumberofpackage.Size = new Size(100, 23);
            txtnumberofpackage.TabIndex = 2;
            // 
            // lblpriceperpackage
            // 
            lblpriceperpackage.AutoSize = true;
            lblpriceperpackage.Location = new Point(33, 85);
            lblpriceperpackage.Name = "lblpriceperpackage";
            lblpriceperpackage.Size = new Size(100, 15);
            lblpriceperpackage.TabIndex = 1;
            lblpriceperpackage.Text = "price per package";
            // 
            // lblnumberofpackage
            // 
            lblnumberofpackage.AutoSize = true;
            lblnumberofpackage.Location = new Point(24, 44);
            lblnumberofpackage.Name = "lblnumberofpackage";
            lblnumberofpackage.Size = new Size(110, 15);
            lblnumberofpackage.TabIndex = 0;
            lblnumberofpackage.Text = "number of package";
            // 
            // lstpurchase
            // 
            lstpurchase.FormattingEnabled = true;
            lstpurchase.ItemHeight = 15;
            lstpurchase.Location = new Point(529, 44);
            lstpurchase.Name = "lstpurchase";
            lstpurchase.Size = new Size(120, 199);
            lstpurchase.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstpurchase);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnexit;
        private Button btnclear;
        private Button btncalculate;
        private TextBox txtpriceperpackage;
        private TextBox txtnumberofpackage;
        private Label lblpriceperpackage;
        private Label lblnumberofpackage;
        private ListBox lstpurchase;
    }
}
