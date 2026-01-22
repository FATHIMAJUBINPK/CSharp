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

namespace DatabaseIntegration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection("Server=.;DataBase=StudentDB;Trusted_Connection=True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Students(Name, Age, Course) VALUES(@Name, @Age, @Course)", conn);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
                cmd.ExecuteNonQuery();
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Server=.;DataBase=StudentDB;Trusted_Connection=True;"))

            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewStudents.DataSource = dt;

            }
        }

    }
}
