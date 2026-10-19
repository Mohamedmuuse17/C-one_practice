namespace air_line_ticket
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
            txtbaggageweight = new TextBox();
            txtnumberoftickets = new TextBox();
            txtpassengerage = new TextBox();
            txtpassengername = new TextBox();
            lblweightkg = new Label();
            lblpassengerage = new Label();
            lblnumberoftickets = new Label();
            lblpassengername = new Label();
            lblpersonalinfor = new Label();
            lbltavelclass = new Label();
            rdfirstclass = new RadioButton();
            rdnormalclass = new RadioButton();
            rdbuisnessclass = new RadioButton();
            lbladitionaloptions = new Label();
            chkInsurance = new CheckBox();
            lblcalculate = new Label();
            lblclear = new Label();
            lblexit = new Label();
            ricTextairlinebookingcalculate = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Aquamarine;
            groupBox1.Controls.Add(txtbaggageweight);
            groupBox1.Controls.Add(txtnumberoftickets);
            groupBox1.Controls.Add(txtpassengerage);
            groupBox1.Controls.Add(txtpassengername);
            groupBox1.Controls.Add(lblweightkg);
            groupBox1.Controls.Add(lblpassengerage);
            groupBox1.Controls.Add(lblnumberoftickets);
            groupBox1.Controls.Add(lblpassengername);
            groupBox1.Controls.Add(lblpersonalinfor);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 218);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtbaggageweight
            // 
            txtbaggageweight.Location = new Point(138, 171);
            txtbaggageweight.Name = "txtbaggageweight";
            txtbaggageweight.Size = new Size(100, 23);
            txtbaggageweight.TabIndex = 9;
            // 
            // txtnumberoftickets
            // 
            txtnumberoftickets.Location = new Point(138, 139);
            txtnumberoftickets.Name = "txtnumberoftickets";
            txtnumberoftickets.Size = new Size(100, 23);
            txtnumberoftickets.TabIndex = 8;
            // 
            // txtpassengerage
            // 
            txtpassengerage.Location = new Point(138, 109);
            txtpassengerage.Name = "txtpassengerage";
            txtpassengerage.Size = new Size(100, 23);
            txtpassengerage.TabIndex = 7;
            // 
            // txtpassengername
            // 
            txtpassengername.Location = new Point(138, 73);
            txtpassengername.Name = "txtpassengername";
            txtpassengername.Size = new Size(100, 23);
            txtpassengername.TabIndex = 6;
            // 
            // lblweightkg
            // 
            lblweightkg.AutoSize = true;
            lblweightkg.Location = new Point(13, 171);
            lblweightkg.Name = "lblweightkg";
            lblweightkg.Size = new Size(120, 15);
            lblweightkg.TabIndex = 5;
            lblweightkg.Text = "baggage weightt (kg)";
            // 
            // lblpassengerage
            // 
            lblpassengerage.AutoSize = true;
            lblpassengerage.Location = new Point(18, 109);
            lblpassengerage.Name = "lblpassengerage";
            lblpassengerage.Size = new Size(82, 15);
            lblpassengerage.TabIndex = 4;
            lblpassengerage.Text = "passenger age";
            // 
            // lblnumberoftickets
            // 
            lblnumberoftickets.AutoSize = true;
            lblnumberoftickets.Location = new Point(18, 139);
            lblnumberoftickets.Name = "lblnumberoftickets";
            lblnumberoftickets.Size = new Size(100, 15);
            lblnumberoftickets.TabIndex = 3;
            lblnumberoftickets.Text = "number of tickets";
            // 
            // lblpassengername
            // 
            lblpassengername.AutoSize = true;
            lblpassengername.Location = new Point(18, 81);
            lblpassengername.Name = "lblpassengername";
            lblpassengername.Size = new Size(93, 15);
            lblpassengername.TabIndex = 2;
            lblpassengername.Text = "passenger name";
            // 
            // lblpersonalinfor
            // 
            lblpersonalinfor.AutoSize = true;
            lblpersonalinfor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpersonalinfor.Location = new Point(13, 40);
            lblpersonalinfor.Name = "lblpersonalinfor";
            lblpersonalinfor.Size = new Size(123, 15);
            lblpersonalinfor.TabIndex = 1;
            lblpersonalinfor.Text = "personal information";
            // 
            // lbltavelclass
            // 
            lbltavelclass.AutoSize = true;
            lbltavelclass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltavelclass.Location = new Point(12, 245);
            lbltavelclass.Name = "lbltavelclass";
            lbltavelclass.Size = new Size(68, 15);
            lbltavelclass.TabIndex = 10;
            lbltavelclass.Text = "travel class";
            // 
            // rdfirstclass
            // 
            rdfirstclass.AutoSize = true;
            rdfirstclass.Location = new Point(30, 275);
            rdfirstclass.Name = "rdfirstclass";
            rdfirstclass.Size = new Size(73, 19);
            rdfirstclass.TabIndex = 11;
            rdfirstclass.TabStop = true;
            rdfirstclass.Text = "first class";
            rdfirstclass.UseVisualStyleBackColor = true;
            // 
            // rdnormalclass
            // 
            rdnormalclass.AutoSize = true;
            rdnormalclass.Location = new Point(125, 275);
            rdnormalclass.Name = "rdnormalclass";
            rdnormalclass.Size = new Size(91, 19);
            rdnormalclass.TabIndex = 12;
            rdnormalclass.TabStop = true;
            rdnormalclass.Text = "normal class";
            rdnormalclass.UseVisualStyleBackColor = true;
            // 
            // rdbuisnessclass
            // 
            rdbuisnessclass.AutoSize = true;
            rdbuisnessclass.Location = new Point(248, 275);
            rdbuisnessclass.Name = "rdbuisnessclass";
            rdbuisnessclass.Size = new Size(98, 19);
            rdbuisnessclass.TabIndex = 13;
            rdbuisnessclass.TabStop = true;
            rdbuisnessclass.Text = "buisness class";
            rdbuisnessclass.UseVisualStyleBackColor = true;
            // 
            // lbladitionaloptions
            // 
            lbladitionaloptions.AutoSize = true;
            lbladitionaloptions.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbladitionaloptions.Location = new Point(14, 307);
            lbladitionaloptions.Name = "lbladitionaloptions";
            lbladitionaloptions.Size = new Size(98, 15);
            lbladitionaloptions.TabIndex = 14;
            lbladitionaloptions.Text = "aditional options";
            // 
            // chkInsurance
            // 
            chkInsurance.AutoSize = true;
            chkInsurance.Location = new Point(29, 344);
            chkInsurance.Name = "chkInsurance";
            chkInsurance.Size = new Size(213, 19);
            chkInsurance.TabIndex = 15;
            chkInsurance.Text = "add travel insurance ($25 per ticket)";
            chkInsurance.UseVisualStyleBackColor = true;
            // 
            // lblcalculate
            // 
            lblcalculate.AutoSize = true;
            lblcalculate.Location = new Point(25, 386);
            lblcalculate.Name = "lblcalculate";
            lblcalculate.Size = new Size(54, 15);
            lblcalculate.TabIndex = 10;
            lblcalculate.Text = "calculate";
            lblcalculate.Click += lblcalculate_Click;
            // 
            // lblclear
            // 
            lblclear.AutoSize = true;
            lblclear.Location = new Point(98, 386);
            lblclear.Name = "lblclear";
            lblclear.Size = new Size(32, 15);
            lblclear.TabIndex = 16;
            lblclear.Text = "clear";
            // 
            // lblexit
            // 
            lblexit.AutoSize = true;
            lblexit.Location = new Point(150, 386);
            lblexit.Name = "lblexit";
            lblexit.Size = new Size(26, 15);
            lblexit.TabIndex = 17;
            lblexit.Text = "exit";
            // 
            // ricTextairlinebookingcalculate
            // 
            ricTextairlinebookingcalculate.Location = new Point(480, 49);
            ricTextairlinebookingcalculate.Name = "ricTextairlinebookingcalculate";
            ricTextairlinebookingcalculate.Size = new Size(224, 297);
            ricTextairlinebookingcalculate.TabIndex = 18;
            ricTextairlinebookingcalculate.Text = "airline booking calculate";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ricTextairlinebookingcalculate);
            Controls.Add(lblexit);
            Controls.Add(lblclear);
            Controls.Add(lblcalculate);
            Controls.Add(chkInsurance);
            Controls.Add(lbladitionaloptions);
            Controls.Add(rdbuisnessclass);
            Controls.Add(rdnormalclass);
            Controls.Add(rdfirstclass);
            Controls.Add(lbltavelclass);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblweightkg;
        private Label lblpassengerage;
        private Label lblnumberoftickets;
        private Label lblpassengername;
        private Label lblpersonalinfor;
        private TextBox txtbaggageweight;
        private TextBox txtnumberoftickets;
        private TextBox txtpassengerage;
        private TextBox txtpassengername;
        private Label lbltavelclass;
        private RadioButton rdfirstclass;
        private RadioButton rdnormalclass;
        private RadioButton rdbuisnessclass;
        private Label lbladitionaloptions;
        private CheckBox chkInsurance;
        private Label lblcalculate;
        private Label lblclear;
        private Label lblexit;
        private RichTextBox ricTextairlinebookingcalculate;
    }
}
