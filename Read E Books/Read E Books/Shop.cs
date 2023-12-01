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
    public partial class Shop : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Amer-\\OneDrive\\Desktop\\Application-Development-Project\\Read E Books\\Read E Books\\EbookDatabase.mdf\";Integrated Security=True";

        public Shop()
        {
            InitializeComponent();
        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ebookBookDataSet);

        }

        private void Shop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ebookBookDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.ebookBookDataSet.Book);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.bookTableAdapter.SearchName(
                this.ebookBookDataSet.Book, searchTextBox.Text);
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            this.bookTableAdapter.Fill(this.ebookBookDataSet.Book);
        }

        private void searchGenreButton_Click(object sender, EventArgs e)
        {
            this.bookTableAdapter.SearchGenre(
                this.ebookBookDataSet.Book, searchTextBox.Text);
        }

        private void addCartButton_Click(object sender, EventArgs e)
        {
            // Get the selected book from the DataGridView
            DataGridViewRow selectedRow = bookDataGridView.SelectedRows[0];
            int selectedBookId = (int)selectedRow.Cells["BookId"].Value;

            string loggedInUsername = GlobalVariables.CurrentUsername;
            int userId = GetUserIdByUsername(loggedInUsername);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Cart (userId, bookId) VALUES (@UserId, @BookId)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.Parameters.AddWithValue("@BookId", selectedBookId);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Book added to cart successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding book to cart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetUserIdByUsername(string username)
        {
            int userId = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT UserId FROM UserTable WHERE Username = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            userId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting user ID: {ex.Message}");
            }

            return userId;
        }
    }
}
