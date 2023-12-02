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

namespace Read_E_Books
{
    public partial class Login : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Amer-\\OneDrive\\Desktop\\Application-Development-Project\\Read E Books\\Read E Books\\EbookDatabase.mdf\";Integrated Security=True";

        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = loginUsernameTextBox.Text;
            string password = loginPasswordTextBox.Text;

            // Validate username and password
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Id FROM UserTable WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        object userIdObj = command.ExecuteScalar();

                        if (userIdObj != null && userIdObj != DBNull.Value)
                        {
                            int userId = Convert.ToInt32(userIdObj);

                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Form home = new Home();
                            home.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Invalid login
                            MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            loginUsernameTextBox.Clear();
                            loginPasswordTextBox.Clear();
                            loginUsernameTextBox.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form welcome = new welcomeForm();
            welcome.Show();

            this.Hide();
        }
    }
}
