namespace home_asigment
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
            dayOfWeekPromptLabel = new Label();
            monthPromptLabel = new Label();
            dayOfmonthPromptLabel = new Label();
            yearPromptLabel = new Label();
            dayOfWeekTextBox = new TextBox();
            monthTextBox = new TextBox();
            dayOfMonthTextBox = new TextBox();
            yearTextBox = new TextBox();
            dateOutputlabel = new Label();
            showDateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // dayOfWeekPromptLabel
            // 
            dayOfWeekPromptLabel.AutoSize = true;
            dayOfWeekPromptLabel.Location = new Point(37, 25);
            dayOfWeekPromptLabel.Name = "dayOfWeekPromptLabel";
            dayOfWeekPromptLabel.Size = new Size(140, 15);
            dayOfWeekPromptLabel.TabIndex = 0;
            dayOfWeekPromptLabel.Text = "Enter the day of the week";
            // 
            // monthPromptLabel
            // 
            monthPromptLabel.AutoSize = true;
            monthPromptLabel.Location = new Point(37, 54);
            monthPromptLabel.Name = "monthPromptLabel";
            monthPromptLabel.Size = new Size(160, 15);
            monthPromptLabel.TabIndex = 1;
            monthPromptLabel.Text = "Enter the name of the month";
            // 
            // dayOfmonthPromptLabel
            // 
            dayOfmonthPromptLabel.AutoSize = true;
            dayOfmonthPromptLabel.Location = new Point(37, 83);
            dayOfmonthPromptLabel.Name = "dayOfmonthPromptLabel";
            dayOfmonthPromptLabel.Size = new Size(199, 15);
            dayOfmonthPromptLabel.TabIndex = 2;
            dayOfmonthPromptLabel.Text = "Enter the numeric day  of the month";
            // 
            // yearPromptLabel
            // 
            yearPromptLabel.AutoSize = true;
            yearPromptLabel.Location = new Point(37, 112);
            yearPromptLabel.Name = "yearPromptLabel";
            yearPromptLabel.Size = new Size(79, 15);
            yearPromptLabel.TabIndex = 3;
            yearPromptLabel.Text = "Enter the year";
            // 
            // dayOfWeekTextBox
            // 
            dayOfWeekTextBox.Location = new Point(253, 17);
            dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            dayOfWeekTextBox.Size = new Size(100, 23);
            dayOfWeekTextBox.TabIndex = 4;
            // 
            // monthTextBox
            // 
            monthTextBox.Location = new Point(253, 51);
            monthTextBox.Name = "monthTextBox";
            monthTextBox.Size = new Size(100, 23);
            monthTextBox.TabIndex = 5;
            // 
            // dayOfMonthTextBox
            // 
            dayOfMonthTextBox.Location = new Point(253, 83);
            dayOfMonthTextBox.Name = "dayOfMonthTextBox";
            dayOfMonthTextBox.Size = new Size(100, 23);
            dayOfMonthTextBox.TabIndex = 6;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(253, 112);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(100, 23);
            yearTextBox.TabIndex = 7;
            // 
            // dateOutputlabel
            // 
            dateOutputlabel.BorderStyle = BorderStyle.FixedSingle;
            dateOutputlabel.Location = new Point(37, 148);
            dateOutputlabel.Name = "dateOutputlabel";
            dateOutputlabel.Size = new Size(316, 35);
            dateOutputlabel.TabIndex = 8;
            // 
            // showDateButton
            // 
            showDateButton.Location = new Point(61, 208);
            showDateButton.Name = "showDateButton";
            showDateButton.Size = new Size(75, 23);
            showDateButton.TabIndex = 9;
            showDateButton.Text = "Show Date ";
            showDateButton.UseVisualStyleBackColor = true;
            showDateButton.Click += showDateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(161, 208);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 10;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(265, 208);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 11;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 395);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(showDateButton);
            Controls.Add(dateOutputlabel);
            Controls.Add(yearTextBox);
            Controls.Add(dayOfMonthTextBox);
            Controls.Add(monthTextBox);
            Controls.Add(dayOfWeekTextBox);
            Controls.Add(yearPromptLabel);
            Controls.Add(dayOfmonthPromptLabel);
            Controls.Add(monthPromptLabel);
            Controls.Add(dayOfWeekPromptLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dayOfWeekPromptLabel;
        private Label monthPromptLabel;
        private Label dayOfmonthPromptLabel;
        private Label yearPromptLabel;
        private TextBox dayOfWeekTextBox;
        private TextBox monthTextBox;
        private TextBox dayOfMonthTextBox;
        private TextBox yearTextBox;
        private Label dateOutputlabel;
        private Button showDateButton;
        private Button clearButton;
        private Button exitButton;
    }
}
