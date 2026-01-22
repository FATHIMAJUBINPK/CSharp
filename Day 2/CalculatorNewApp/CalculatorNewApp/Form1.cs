using System;
using System.Windows.Forms;

namespace CalculatorNewApp
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        string operation = "";
        bool isOperationPressed = false;

        public Form1()

        {
            InitializeComponent();
        }

        // Common number button click
        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (lblDisplay.Text == "0" || isOperationPressed)
                lblDisplay.Text = "";

            isOperationPressed = false;
            lblDisplay.Text += btn.Text;
        }

        // Operator button click (+ - * /)
        private void Operator_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            // If operator was already pressed, just change the pending operation
            if (isOperationPressed)
            {
                operation = btn.Text;
                return;
            }

            // Safely parse the display; avoid FormatException
            if (!double.TryParse(lblDisplay.Text,
                                 System.Globalization.NumberStyles.Float,
                                 System.Globalization.CultureInfo.CurrentCulture,
                                 out firstNumber))
            {
                MessageBox.Show("Invalid number in display");
                firstNumber = 0;
            }

            operation = btn.Text;
            isOperationPressed = true;
        }

        // Equals button
        private void btnEquals_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(lblDisplay.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;

                case "-":
                    result = firstNumber - secondNumber;
                    break;

                case "*":
                    result = firstNumber * secondNumber;
                    break;

                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Cannot divide by zero");
                        return;
                    }
                    result = firstNumber / secondNumber;
                    break;
            }

            lblDisplay.Text = result.ToString();
        }

        // Decimal button
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!lblDisplay.Text.Contains("."))
                lblDisplay.Text += ".";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            firstNumber = 0;
            operation = "";
            isOperationPressed = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length > 1)
            {
                lblDisplay.Text = lblDisplay.Text.Substring(0, lblDisplay.Text.Length - 1);
            }
            else
            {
                lblDisplay.Text = "0";
            }
        }
    }
}