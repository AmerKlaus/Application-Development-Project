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
        private string connectionString = GlobalVariables.Connection;
        private string content;

        public BookReader()
        {
            InitializeComponent();
        }

        public BookReader(string content)
        {
            InitializeComponent();
            this.content = content;
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
                bookContentTextBox.Text = content;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading content: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
