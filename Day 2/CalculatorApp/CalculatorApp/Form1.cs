namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNum1.Text);
            double b = double.Parse(txtNum2.Text);
            lblResult.Text = (a + b).ToString();

        }

        private void b2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNum1.Text);
            double b = double.Parse(txtNum2.Text);
            lblResult.Text = (a - b).ToString();

        }

        private void b3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNum1.Text);
            double b = double.Parse(txtNum2.Text);
            lblResult.Text = (a * b).ToString();

        }

        private void b4_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtNum1.Text);
            double b = double.Parse(txtNum2.Text);

            if (b == 0)
            {
                MessageBox.Show("Division by zero is not allowed.");
                return;
            }

            lblResult.Text = (a / b).ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
