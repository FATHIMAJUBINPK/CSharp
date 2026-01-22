using System;
using System.Windows.Forms;

namespace RegistrationFormWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Wire up runtime handlers (button had no click handler in the designer)
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var name = textBox1?.Text?.Trim();
            var email = textBox2?.Text?.Trim();
            var gender = (rbMale != null && rbMale.Checked) ? "Male"
                       : (rbFemale != null && rbFemale.Checked) ? "Female"
                       : null;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1?.Focus();
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2?.Focus();
                return;
            }

            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select a gender.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Registered:\n\nName: {name}\nEmail: {email}\nGender: {gender}", "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // intentionally left empty (designer hook)
        }
    }
}
