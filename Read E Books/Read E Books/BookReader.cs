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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Read_E_Books
{
    public partial class BookReader : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Amer-\\OneDrive\\Desktop\\Application-Development-Project\\Read E Books\\Read E Books\\EbookDatabase.mdf\";Integrated Security=True";

        public BookReader()
        {
            InitializeComponent();
        }

        private void libraryButton_Click(object sender, EventArgs e)
        {
            Form library = new Library();
            library.Show();

            this.Close();
        }

        private void BookReader_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    string query = "SELECT Id, Password FROM Book WHERE Id = @CurrentBookId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CurrentBookId", GlobalVariables.CurrentBookId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string bookContent = reader["Content"].ToString();
                                bookContentTextBox.Text = bookContent;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading content: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
