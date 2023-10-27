namespace l3_Practice_task2
{
    //����������� ��������� ��������� ������������ ��������.��� ������ ����������,
    //������������ �������� ����� �� 6-10 ��������, ���� ��� ����� ����� � ������
    //��� ��������� �������.�� ��� ����� ������ ������ ���� �������, ����� �������
    //��������� ����� ��� ������������.������� ��������� ������ ��������� �� 1 �� 200
    //������.� �������� ���� ������ ��������� ���������: 1 �������, 2 �������, 5
    //������, 10 ������ � 25 ������.����� ����� ������������� �����, ������ �����������
    //���������� ����� ��� ������ �����.
    public partial class IceCoolDrinksForm : Form
    {

        int[] coinValues = { 10, 5, 2, 1 };
        Dictionary<int, int> changeCoins = new Dictionary<int, int>();
        public IceCoolDrinksForm()
        {
            InitializeComponent();

            InsertBillsComboBox.Items.Add(1);
            InsertBillsComboBox.Items.Add(2);
            InsertBillsComboBox.Items.Add(5);
            InsertBillsComboBox.Items.Add(10);
            InsertBillsComboBox.Items.Add(20);
            InsertBillsComboBox.Items.Add(50);
            InsertBillsComboBox.Items.Add(100);
            InsertBillsComboBox.Items.Add(200);

            InsertBillsComboBox.SelectedIndexChanged += InsertBillsComboBox_SelectedIndexChanged;

            StartButton.Click += StartButton_Click;
        }

        private void StartButton_Click1(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void InsertBillsComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            int billNominal = (int)InsertBillsComboBox.SelectedItem;
            UpdateCurrentBalance(billNominal);
        }

        private void UpdateCurrentBalance(int billNominal)
        {
            int balance = int.Parse(CurrentBalanceTextBox.Text) + billNominal;
            CurrentBalanceTextBox.Text = balance.ToString();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int balance;

            if (int.TryParse(CurrentBalanceTextBox.Text, out balance))
            {
                RadioButton drink = GetSelectedDrink();

                if (drink != null)
                {
                    int price = Convert.ToInt32(drink.Tag);

                    if (balance >= price)
                    {
                        string purchaseMessage = PurchaseDrink(drink);
                        if (balance > price)
                        {
                            string changeMessage = CalculateChange(balance, price);
                            MessageBox.Show(purchaseMessage + "\n" + changeMessage);
                        }
                        else
                        {
                            MessageBox.Show(purchaseMessage);
                        }

                        balance = 0;
                        CurrentBalanceTextBox.Text = balance.ToString();
                    }
                }
            }
        }

        private RadioButton GetSelectedDrink()
        {
            RadioButton drink = null;

            if (CocaColaRadioButton.Checked) { drink = CocaColaRadioButton; }
            if (FantaRadioButton.Checked) { drink = FantaRadioButton; }
            if (SpriteRadioButton.Checked) { drink = SpriteRadioButton; }
            if (LiptonRadioButton.Checked) { drink = LiptonRadioButton; }
            if (KumisRadioButton.Checked) { drink = KumisRadioButton; }
            if (RedBullRadioButton.Checked) { drink = RedBullRadioButton; }

            return drink;
        }

        private string PurchaseDrink(RadioButton drink)
        {
            string message = $"������ �������: {drink.Text}";
            return message;
        }

        private string CalculateChange(int balance, int price)
        {
            int change = balance - price;

            if (change > 0)
            {
                foreach (int coinValue in coinValues)
                {
                    int count = change / coinValue;

                    if (count > 0)
                    {
                        changeCoins[coinValue] = count;
                        change -= coinValue * count;
                    }
                }

                string changeMessage = "\n\t�����:\n";
                foreach (var coin in changeCoins)
                {
                    changeMessage += $"{coin.Value}x {coin.Key}���.\n";
                }
                return changeMessage;
            }

            return "";
        }
    }
}