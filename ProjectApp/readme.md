📅 Day 7 – Mini Project & Review
Goal: Apply all the concepts learned during the week to build a complete Windows Forms application as a team project.


📝 Topics

Best practices: naming conventions, modular code
Debugging & testing
Documentation basics
Team collaboration and integration



🛠️ Exercises

Exercise 1 – Project Setup

Create a new WinForms project named LibraryManagement.
Plan the modules: Login, Book Entry, Search, Reports.
Assign responsibilities:


Trainee 1 (UI): Design forms and layout.

Trainee 2 (Logic): Implement classes (Book, Member, Transaction).

Trainee 3 (Data): Handle database CRUD operations.





Exercise 2 – Login Form

Create a login form with TextBox for username and password.
Validate credentials (hardcoded or from database).
Show a message on success or failure.


if (txtUser.Text == "admin" && txtPass.Text == "1234")
{
    MessageBox.Show("Login successful!");
    // Open main form
}
else
{
    MessageBox.Show("Invalid credentials.");
}




Book Entry Example

SqlCommand cmd = new SqlCommand(
    "INSERT INTO Books(Title, Author, Category) VALUES(@Title, @Author, @Category)", conn);
cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
cmd.ExecuteNonQuery();



Search Example

SqlDataAdapter da = new SqlDataAdapter(
    "SELECT * FROM Books WHERE Title LIKE @Search", conn);
da.SelectCommand.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
DataTable dt = new DataTable();
da.Fill(dt);
dataGridViewBooks.DataSource = dt;
