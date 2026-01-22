📅 Day 6 – UI/UX & Advanced Features in C#
Goal: Improve usability and user experience in Windows Forms applications by using advanced controls, menus, dialogs, and validation.


📝 Topics

Menus (MenuStrip)
Dialogs and message boxes

DataGridView control
Input validation and error messages



🛠️ Exercises

Exercise 1 – Add a MenuStrip

Add a MenuStrip to your form.
Create a File menu with an Exit option.
Handle the click event to close the application.


private void exitToolStripMenuItem_Click(object sender, EventArgs e)
{
    Application.Exit();
}



Exercise 2 – Confirmation Dialog

var result = MessageBox.Show("Are you sure?",
                             "Confirm",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);
if (result == DialogResult.Yes)
{
    // Delete logic
}



Exercise 3 – Validation

if (!int.TryParse(txtAge.Text, out int age))
{
    MessageBox.Show("Please enter a valid age.");
    return;
}
