namespace CheckWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowSelection_Click(object sender, EventArgs e)
        {
            string subscription = chkSubscribe.Checked ? "Subscribed" : "Not Subscribed";

            string gender = "";
            if (radioMale.Checked)
                gender = "Male";
            else if (radioFemale.Checked)
                gender = "Female";
            else
                gender = "Not selected";

            MessageBox.Show($"Subscription: {subscription}\nGender: {gender}", "Your Selection");
        }
    }
}
