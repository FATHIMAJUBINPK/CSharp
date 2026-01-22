📅 Day 4 – Data Handling in C#
Goal: Work with collections, file I/O, and error handling in Windows Forms applications.


📝 Topics

Collections (List, Dictionary)
File I/O (read/write text files)
Error handling (try/catch)



🛠️ Exercises

Exercise 1 – To‑Do List Form

Create a new WinForms project named TodoApp.
Add a TextBox (txtTask) and a Button (btnAddTask) to add tasks.
Add a ListBox (listBoxTasks) to display tasks.


private void btnAddTask_Click(object sender, EventArgs e)
{
    if (!string.IsNullOrWhiteSpace(txtTask.Text))
    {
        listBoxTasks.Items.Add(txtTask.Text);
        txtTask.Clear();
    }
    else
    {
        MessageBox.Show("Please enter a task.");
    }
}
