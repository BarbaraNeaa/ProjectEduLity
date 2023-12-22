using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

//Kami menggunakan Teknik Database disini, menghubungkan code dengan PostgreSql. Kami juga merapikan code dengan menggunakan Teknik Refactoring

namespace EduLity
{
    public partial class FirstForm : Form
    {
        private NpgsqlConnection conn;
        private string connString = "Server=localhost; Port=5432; User Id=postgres; Password=BarbaraNea2304; Database=Demo";

        public FirstForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();
                MessageBox.Show("Connected to PostgreSQL");
                this.FormClosed += (sender, args) => { conn.Close(); };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to PostgreSQL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int result = ExecuteLoginProcedure();

                if (result == 1)
                {
                    HandleSuccessfulLogin();
                }
                else
                {
                    HandleFailedLogin();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ExecuteLoginProcedure()
        {
            string sql = "select * from u_login(:_username, :_password)";
            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("_username", txtUsername.Text);
                cmd.Parameters.AddWithValue("_password", txtPassword.Text);
                return (int)cmd.ExecuteScalar();
            }
        }

        private void HandleSuccessfulLogin()
        {
            this.Hide();
            using (LoginForm loginForm = new LoginForm(txtUsername.Text))
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    using (MainForm mainForm = new MainForm(loginForm.UserName, loginForm.UserAge, loginForm.Institution))
                    {
                        mainForm.ShowDialog();
                    }
                }
            }
            Application.Exit();
        }

        private void HandleFailedLogin()
        {
            MessageBox.Show("Invalid username or password. Register first if you don't have an account.", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
            // No need to initialize conn here; it's done in InitializeDatabaseConnection
        }

        private void btnRegistHere_Click(object sender, EventArgs e)
        {
            using (RegistForm registrationForm = new RegistForm(connString))
            {
                if (registrationForm.ShowDialog() == DialogResult.OK)
                {
                    // Handle any logic after successful registration if needed
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
