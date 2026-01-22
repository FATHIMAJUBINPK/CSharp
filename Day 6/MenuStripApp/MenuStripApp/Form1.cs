using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStripApp
{
    public partial class Form1 : Form
    {
        private DataTable studentsTable;

        public Form1()
        {
            InitializeComponent();

            // Initialize and bind a DataTable instead of using a Student class
            studentsTable = new DataTable();
            studentsTable.Columns.Add("Name", typeof(string));
            studentsTable.Columns.Add("Age", typeof(int));
            studentsTable.Columns.Add("Course", typeof(string));

            dataGridViewStudents.DataSource = studentsTable;
            dataGridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStudents.MultiSelect = true;
            dataGridViewStudents.AllowUserToAddRows = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void AddStudent()
        {
            // Trim inputs
            string name = txtName.Text?.Trim();
            string ageText = txtAge.Text?.Trim();
            string course = txtCourse.Text?.Trim();

            // Validate Name
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            // Validate Age
            if (!int.TryParse(ageText, out int age) || age <= 0 || age > 120)
            {
                MessageBox.Show("Please enter a valid age between 1 and 120.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return;
            }

            // Validate Course
            if (string.IsNullOrEmpty(course))
            {
                MessageBox.Show("Please enter a course.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCourse.Focus();
                return;
            }

            // Prevent obvious duplicates in DataTable
            bool duplicate = studentsTable.Rows
                .Cast<DataRow>()
                .Any(r =>
                    string.Equals((r["Name"] as string) ?? string.Empty, name, StringComparison.Ordinal) &&
                    Convert.ToInt32(r["Age"]) == age &&
                    string.Equals((r["Course"] as string) ?? string.Empty, course, StringComparison.Ordinal));

            if (duplicate)
            {
                MessageBox.Show("A student with the same details already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Add new row to the DataTable
            var newRow = studentsTable.NewRow();
            newRow["Name"] = name;
            newRow["Age"] = age;
            newRow["Course"] = course;
            studentsTable.Rows.Add(newRow);

            // Clear and focus for faster entry
            txtName.Clear();
            txtAge.Clear();
            txtCourse.Clear();
            txtName.Focus();
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection("Server=.;DATABASE=MENUDB;Trusted_Connection=True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO MENUSTRIP(Name, Age, Course) VALUES (@Name, @Age, @Course)", conn);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
                cmd.ExecuteNonQuery();
            }
            AddStudent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (studentsTable == null || studentsTable.Rows.Count == 0)
            {
                MessageBox.Show("There are no items to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dataGridViewStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show(
                "Are you sure you want to delete the selected item(s)?",
                "Confirm delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            
            using (SqlConnection conn = new SqlConnection( "Server=.;Database=MENUDB;Trusted_Connection=True;"))
            {
                conn.Open();

                foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["Id"].Value);

                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM MENUSTRIP WHERE Id = @Id", conn);

                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Server=.;DataBase=MENUDB;Trusted_Connection=True;"))

            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MENUSTRIP", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewStudents.DataSource = dt;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?",
                            "Confirm",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)

                Application.Exit();

        }
    }
}
