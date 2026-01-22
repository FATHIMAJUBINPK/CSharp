🖥️ C# Windows Forms Crash Training – Exercise Sheet
A day-by-day coding exercise manual for MCA graduates learning C# Windows Forms applications.


📅 Day 1 – Foundations
Goal: Get familiar with Visual Studio, WinForms basics, and event handling.


Exercise 1: Create a new WinForms project called HelloWinForms.

Exercise 2: Add a Label, TextBox, and Button.

Exercise 3: On button click, display “Hello, !” in the label.


private void btnGreet_Click(object sender, EventArgs e)
{
    lblMessage.Text = "Hello, " + txtName.Text + "!";
}



🎯 Assignment


Build a form that takes user input (name) and displays a greeting.


Experiment with different controls (e.g., add a CheckBox or RadioButton).
