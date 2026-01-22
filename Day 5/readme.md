📅 Day 5 – Database Integration in C#
Goal: Learn how to connect Windows Forms applications to a database using ADO.NET and perform CRUD operations.


📝 Topics

Introduction to SQL Server / SQLite
ADO.NET basics (SqlConnection, SqlCommand, SqlDataAdapter)
CRUD operations (Create, Read, Update, Delete)
Displaying data in DataGridView




🛠️ Exercises

Exercise 1 – Create Database Table

In SQL Server or SQLite, create a Students table:


CREATE TABLE Students (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Age INT,
    Course NVARCHAR(100)
);



Exercise 2 – Insert Record

using (SqlConnection conn = new SqlConnection("your_connection_string"))
{
    conn.Open();
    SqlCommand cmd = new SqlCommand(
        "INSERT INTO Students(Name, Age, Course) VALUES(@Name, @Age, @Course)", conn);
    cmd.Parameters.AddWithValue("@Name", txtName.Text);
    cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
    cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
    cmd.ExecuteNonQuery();
}



Exercise 3 – Display Records

SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", conn);
DataTable dt = new DataTable();
da.Fill(dt);
dataGridViewStudents.DataSource = dt;
