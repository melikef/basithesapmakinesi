namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void processButton_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(number1MaskedTextBox1.Text);
            int number2 = Convert.ToInt32(number2MaskedTextBox2.Text);
            int results = 0;
            
            char pickedOperator = Convert.ToChar(operatorComboBox1.Text);

            if (pickedOperator == '+')
            {
                results = number1 + number2;
            }
            else if (pickedOperator == '-')
            {
                results = number1 - number2;
            }
            else if (pickedOperator == '*')
            {
                results = number1 * number2;
            }
            else if (pickedOperator == '/')
            {
                results = number1 / number2;
            }
            else
            {
                MessageBox.Show("Lütfen bir operatör seçiniz!");
            }
            resultsListBox1.Items.Add(results.ToString());
        }
    }
}
