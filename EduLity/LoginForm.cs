using System;
using System.Windows.Forms;

namespace EduLity
{
    public partial class LoginForm : Form
    {
        public string UserName { get; private set; }
        public int UserAge { get; private set; }
        public string Institution { get; private set; }

        public LoginForm(string username)
        {
            this.UserName = username;
            InitializeComponent();
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Welcome, " + UserName;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                UserName = txtName.Text;
                UserAge = int.Parse(txtAge.Text);
                Institution = txtInstitution.Text;

                // Hide the current login form
                this.Hide();

                // Open MainForm
                MainForm mainForm = new MainForm(UserName, UserAge, Institution);
                mainForm.ShowDialog();

                // Close the login form when MainForm is closed
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid age.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
