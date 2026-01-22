📅 Day 2 – Core C# Concepts
Goal: Practice variables, operators, and control structures in C# while building a functional WinForms application.


📝 Topics

Variables, data types, and operators
Control structures (if, switch, loops)
Methods & parameters
Event handling in WinForms



🛠️ Exercises

Exercise 1 – Calculator Form

Create a new WinForms project named CalculatorApp.
Add two TextBox controls for input (txtNum1, txtNum2).
Add four Button controls for operations (+, -, ×, ÷).
Add a Label (lblResult) to display the output.


Exercise 2 – Implement Addition

private void btnAdd_Click(object sender, EventArgs e)
{
    double a = double.Parse(txtNum1.Text);
    double b = double.Parse(txtNum2.Text);
    lblResult.Text = (a + b).ToString();
}



Subtraction

private void btnSubtract_Click(object sender, EventArgs e)
{
    double a = double.Parse(txtNum1.Text);
    double b = double.Parse(txtNum2.Text);
    lblResult.Text = (a - b).ToString();
}



Multiplication

private void btnMultiply_Click(object sender, EventArgs e)
{
    double a = double.Parse(txtNum1.Text);
    double b = double.Parse(txtNum2.Text);
    lblResult.Text = (a * b).ToString();
}



Division (with error handling)

private void btnDivide_Click(object sender, EventArgs e)
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
