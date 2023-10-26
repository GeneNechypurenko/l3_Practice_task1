namespace l3_Practice_task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click_1(object sender, EventArgs e)
        {
            if (DateTime.TryParse(EntryTextBox.Text, out DateTime result))
            {
                TimeSpan period = result - DateTime.Now;

                if (YearRadioButton.Checked)
                {
                    OutputTextBox.Text = $"{period.TotalDays / 365:F2} years left";
                }
                else if (MonthRadioButton.Checked)
                {
                    OutputTextBox.Text = $"{period.TotalDays / 30:F2} months left";
                }
                else if (DayRadioButton.Checked)
                {
                    OutputTextBox.Text = $"{period.TotalDays:F2} days left";
                }
                else if (HourRadioButton.Checked)
                {
                    OutputTextBox.Text = $"{period.TotalHours:F2} hours left";
                }
            }
        }
    }
}