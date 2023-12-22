using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

//Untuk merapikan dan membuat code dalam RegistForm ini lebih terstruktur, kami menggunakan Teknik Refactoring.

namespace EduLity
{
    public partial class RegistForm : Form
    {
        private readonly string connString;

        public RegistForm(string connection)
        {
            InitializeComponent();
            connString = connection;

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    MessageBox.Show("Connected to PostgreSQL");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to PostgreSQL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // No need to explicitly close the connection; it's already closed due to using statement
        }

        private void RegistForm_Load(object sender, EventArgs e)
        {
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    if (string.IsNullOrWhiteSpace(txtNewUsername.Text) || string.IsNullOrWhiteSpace(txtNewPassword.Text))
                    {
                        MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if the username is already taken
                    string checkUsernameQuery = "SELECT COUNT(*) FROM tbl_users WHERE username = :_username";
                    using (NpgsqlCommand checkUsernameCmd = new NpgsqlCommand(checkUsernameQuery, conn))
                    {
                        checkUsernameCmd.Parameters.AddWithValue("_username", txtNewUsername.Text);

                        int existingUserCount = Convert.ToInt32(checkUsernameCmd.ExecuteScalar());

                        if (existingUserCount > 0)
                        {
                            MessageBox.Show("Username already taken. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert new user into the database using the u_register function
                    string insertUserQuery = "SELECT u_register(:_username, :_password)";
                    using (NpgsqlCommand insertUserCmd = new NpgsqlCommand(insertUserQuery, conn))
                    {
                        insertUserCmd.Parameters.AddWithValue("_username", txtNewUsername.Text);
                        insertUserCmd.Parameters.AddWithValue("_password", txtNewPassword.Text);

                        insertUserCmd.ExecuteNonQuery();

                        MessageBox.Show("Registration successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Close the registration form
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nStackTrace: {ex.StackTrace}", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
