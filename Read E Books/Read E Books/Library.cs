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
    public partial class Library : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Amer-\\OneDrive\\Desktop\\Application-Development-Project\\Read E Books\\Read E Books\\EbookDatabase.mdf\";Integrated Security=True";
        private int userId = GlobalVariables.CurrentId;
        private int selectedRowIndex = -1;

        public Library()
        {
            InitializeComponent();

            // Load books for the current user
            LoadBooks();
        }

        public void LoadBooks()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Library WHERE userId = @UserId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        libraryBooksGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Form home = new Home();
            home.Show();

            this.Close();
        }

        private void viewBookButton_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0 && selectedRowIndex < libraryBooksGridView.Rows.Count)
            {
                DataGridViewRow selectedRow = libraryBooksGridView.Rows[selectedRowIndex];

                // Check if the selectedRow is not null
                if (selectedRow != null)
                {
                    // Create a list to store cell values
                    List<object> rowValues = new List<object>();

                    // Loop through the cells in the selected row
                    foreach (DataGridViewCell cell in selectedRow.Cells)
                    {
                        rowValues.Add(cell.Value);
                    }

                    // rowValues contains the values of all cells in the selected row
                    int selectedBookId = (int)rowValues[0];

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            string query = "SELECT Content FROM Library WHERE bookId = @BookId";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@BookId", selectedBookId);

                                command.ExecuteNonQuery();

                                string content = libraryBooksGridView.Rows[selectedBookId].Cells["Content"].Value.ToString();

                                Form bookReader = new BookReader(content);
                                bookReader.Show();

                                this.Close();

                                MessageBox.Show("Book Content loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading book content: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The selected row is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid book to view content.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //DataGridViewRow selectedRow = libraryBooksGridView.SelectedRows[0];
            //int selectedBookId = (int)selectedRow.Cells["bookId"].Value;

            //GlobalVariables.CurrentBookId = selectedBookId;

            //Form bookReader = new BookReader();
            //bookReader.Show();

            //this.Close();
        }
    }
}
