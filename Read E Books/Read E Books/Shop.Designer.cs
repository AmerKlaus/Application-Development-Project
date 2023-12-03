namespace Read_E_Books
{
    partial class Shop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.listLabel = new System.Windows.Forms.Label();
            this.bookDataGridView = new System.Windows.Forms.DataGridView();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchGenreButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.showAllButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addCartButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ebookBookDataSet = new Read_E_Books.EbookBookDataSet();
            this.bookTableAdapter = new Read_E_Books.EbookBookDataSetTableAdapters.BookTableAdapter();
            this.tableAdapterManager = new Read_E_Books.EbookBookDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).BeginInit();
            this.searchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebookBookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Green;
            this.welcomeLabel.Location = new System.Drawing.Point(389, 21);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(787, 74);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome to Read-E-Books";
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(32, 21);
            this.homeButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(200, 55);
            this.homeButton.TabIndex = 2;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLabel.Location = new System.Drawing.Point(32, 198);
            this.listLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(209, 40);
            this.listLabel.TabIndex = 6;
            this.listLabel.Text = "List of Books :";
            // 
            // bookDataGridView
            // 
            this.bookDataGridView.AutoGenerateColumns = false;
            this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.bookDataGridView.DataSource = this.bookBindingSource;
            this.bookDataGridView.Location = new System.Drawing.Point(32, 243);
            this.bookDataGridView.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bookDataGridView.Name = "bookDataGridView";
            this.bookDataGridView.RowHeadersWidth = 102;
            this.bookDataGridView.Size = new System.Drawing.Size(1197, 525);
            this.bookDataGridView.TabIndex = 7;
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchGenreButton);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.searchTextBox);
            this.searchGroupBox.Location = new System.Drawing.Point(40, 782);
            this.searchGroupBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.searchGroupBox.Size = new System.Drawing.Size(637, 343);
            this.searchGroupBox.TabIndex = 8;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // searchGenreButton
            // 
            this.searchGenreButton.Location = new System.Drawing.Point(323, 186);
            this.searchGenreButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.searchGenreButton.Name = "searchGenreButton";
            this.searchGenreButton.Size = new System.Drawing.Size(256, 110);
            this.searchGenreButton.TabIndex = 2;
            this.searchGenreButton.Text = "Search by Genre";
            this.searchGenreButton.UseVisualStyleBackColor = true;
            this.searchGenreButton.Click += new System.EventHandler(this.searchGenreButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(59, 186);
            this.searchButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(256, 110);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search by Name";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(59, 83);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(511, 38);
            this.searchTextBox.TabIndex = 0;
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(765, 968);
            this.showAllButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(299, 110);
            this.showAllButton.TabIndex = 2;
            this.showAllButton.Text = "Show All Books";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1328, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "Shopping Cart";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // addCartButton
            // 
            this.addCartButton.Location = new System.Drawing.Point(1192, 1140);
            this.addCartButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.addCartButton.Name = "addCartButton";
            this.addCartButton.Size = new System.Drawing.Size(381, 55);
            this.addCartButton.TabIndex = 10;
            this.addCartButton.Text = "Add selected book to Cart";
            this.addCartButton.UseVisualStyleBackColor = true;
            this.addCartButton.Click += new System.EventHandler(this.addCartButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "bookName";
            this.dataGridViewTextBoxColumn2.HeaderText = "bookName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Genre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "numberOfPages";
            this.dataGridViewTextBoxColumn4.HeaderText = "numberOfPages";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.ebookBookDataSet;
            // 
            // ebookBookDataSet
            // 
            this.ebookBookDataSet.DataSetName = "EbookBookDataSet";
            this.ebookBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager.UpdateOrder = Read_E_Books.EbookBookDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 1223);
            this.Controls.Add(this.addCartButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.bookDataGridView);
            this.Controls.Add(this.listLabel);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.welcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Shop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).EndInit();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebookBookDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label listLabel;
        private EbookBookDataSet ebookBookDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private EbookBookDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private EbookBookDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bookDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Button searchGenreButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addCartButton;
    }
}