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

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT userId, Password FROM UserTable WHERE Username = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedPassword = reader["Password"].ToString();

                                if (password.Equals(storedPassword))
                                {
                                    int userId = Convert.ToInt32(reader["UserId"]);
                                    GlobalVariables.CurrentUsername = username;
                                    GlobalVariables.CurrentPassword = password;
                                    GlobalVariables.CurrentId = userId;

                                    LoadHomePage();
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect username or password");
                                    loginUsernameTextBox.Text = "";
                                    loginPasswordTextBox.Text = "";
                                }
                            }
                            else
                            {
                                Console.Write("User not found");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
           
        }

        private void LoadHomePage()
        {
            Form home = new Home();
            home.Show();

            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form welcome = new welcomeForm();
            welcome.Show();

            this.Close();
        }
    }
}
