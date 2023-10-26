namespace l3_Practice_task1
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
            EntryTextPanel = new Panel();
            EntryTextBox = new TextBox();
            PeriodGroupBox = new GroupBox();
            HourRadioButton = new RadioButton();
            DayRadioButton = new RadioButton();
            MonthRadioButton = new RadioButton();
            YearRadioButton = new RadioButton();
            OutputTextPanel = new Panel();
            OutputTextBox = new TextBox();
            CalculateButton = new Button();
            EntryTextPanel.SuspendLayout();
            PeriodGroupBox.SuspendLayout();
            OutputTextPanel.SuspendLayout();
            SuspendLayout();
            // 
            // EntryTextPanel
            // 
            EntryTextPanel.Controls.Add(EntryTextBox);
            EntryTextPanel.Dock = DockStyle.Top;
            EntryTextPanel.Location = new Point(0, 0);
            EntryTextPanel.Name = "EntryTextPanel";
            EntryTextPanel.Size = new Size(327, 53);
            EntryTextPanel.TabIndex = 0;
            // 
            // EntryTextBox
            // 
            EntryTextBox.Dock = DockStyle.Fill;
            EntryTextBox.Location = new Point(0, 0);
            EntryTextBox.Multiline = true;
            EntryTextBox.Name = "EntryTextBox";
            EntryTextBox.Size = new Size(327, 53);
            EntryTextBox.TabIndex = 0;
            // 
            // PeriodGroupBox
            // 
            PeriodGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PeriodGroupBox.Controls.Add(HourRadioButton);
            PeriodGroupBox.Controls.Add(DayRadioButton);
            PeriodGroupBox.Controls.Add(MonthRadioButton);
            PeriodGroupBox.Controls.Add(YearRadioButton);
            PeriodGroupBox.Location = new Point(0, 59);
            PeriodGroupBox.Name = "PeriodGroupBox";
            PeriodGroupBox.Size = new Size(327, 77);
            PeriodGroupBox.TabIndex = 1;
            PeriodGroupBox.TabStop = false;
            PeriodGroupBox.Text = "Set Period:";
            // 
            // HourRadioButton
            // 
            HourRadioButton.AutoSize = true;
            HourRadioButton.Location = new Point(224, 26);
            HourRadioButton.Name = "HourRadioButton";
            HourRadioButton.Size = new Size(72, 24);
            HourRadioButton.TabIndex = 3;
            HourRadioButton.Text = "Hours";
            HourRadioButton.UseVisualStyleBackColor = true;
            // 
            // DayRadioButton
            // 
            DayRadioButton.AutoSize = true;
            DayRadioButton.Location = new Point(161, 26);
            DayRadioButton.Name = "DayRadioButton";
            DayRadioButton.Size = new Size(57, 24);
            DayRadioButton.TabIndex = 2;
            DayRadioButton.Text = "Day";
            DayRadioButton.UseVisualStyleBackColor = true;
            // 
            // MonthRadioButton
            // 
            MonthRadioButton.AutoSize = true;
            MonthRadioButton.Location = new Point(78, 26);
            MonthRadioButton.Name = "MonthRadioButton";
            MonthRadioButton.Size = new Size(77, 24);
            MonthRadioButton.TabIndex = 1;
            MonthRadioButton.Text = "Month";
            MonthRadioButton.UseVisualStyleBackColor = true;
            // 
            // YearRadioButton
            // 
            YearRadioButton.AutoSize = true;
            YearRadioButton.Checked = true;
            YearRadioButton.Location = new Point(12, 26);
            YearRadioButton.Name = "YearRadioButton";
            YearRadioButton.Size = new Size(60, 24);
            YearRadioButton.TabIndex = 0;
            YearRadioButton.TabStop = true;
            YearRadioButton.Text = "Year";
            YearRadioButton.UseVisualStyleBackColor = true;
            // 
            // OutputTextPanel
            // 
            OutputTextPanel.Controls.Add(OutputTextBox);
            OutputTextPanel.Controls.Add(CalculateButton);
            OutputTextPanel.Dock = DockStyle.Bottom;
            OutputTextPanel.Location = new Point(0, 142);
            OutputTextPanel.Name = "OutputTextPanel";
            OutputTextPanel.Size = new Size(327, 55);
            OutputTextPanel.TabIndex = 2;
            // 
            // OutputTextBox
            // 
            OutputTextBox.Dock = DockStyle.Fill;
            OutputTextBox.Location = new Point(0, 0);
            OutputTextBox.Multiline = true;
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.ReadOnly = true;
            OutputTextBox.Size = new Size(233, 55);
            OutputTextBox.TabIndex = 1;
            // 
            // CalculateButton
            // 
            CalculateButton.Dock = DockStyle.Right;
            CalculateButton.Location = new Point(233, 0);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(94, 55);
            CalculateButton.TabIndex = 0;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 197);
            Controls.Add(OutputTextPanel);
            Controls.Add(PeriodGroupBox);
            Controls.Add(EntryTextPanel);
            Name = "Form1";
            Text = "Form1";
            EntryTextPanel.ResumeLayout(false);
            EntryTextPanel.PerformLayout();
            PeriodGroupBox.ResumeLayout(false);
            PeriodGroupBox.PerformLayout();
            OutputTextPanel.ResumeLayout(false);
            OutputTextPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Panel EntryTextPanel;
        private TextBox EntryTextBox;
        private GroupBox PeriodGroupBox;
        private RadioButton HourRadioButton;
        private RadioButton DayRadioButton;
        private RadioButton MonthRadioButton;
        private RadioButton YearRadioButton;
        private Panel OutputTextPanel;
        private TextBox OutputTextBox;
        private Button CalculateButton;
    }
}