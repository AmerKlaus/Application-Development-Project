namespace Read_E_Books
{
    partial class Library
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
            this.libraryBooksGridView = new System.Windows.Forms.DataGridView();
            this.ebookBookDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ebookBookDataSet = new Read_E_Books.EbookBookDataSet();
            this.viewBookButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBooksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebookBookDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebookBookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryBooksGridView
            // 
            this.libraryBooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.libraryBooksGridView.Location = new System.Drawing.Point(69, 172);
            this.libraryBooksGridView.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.libraryBooksGridView.Name = "libraryBooksGridView";
            this.libraryBooksGridView.RowHeadersWidth = 102;
            this.libraryBooksGridView.Size = new System.Drawing.Size(1197, 525);
            this.libraryBooksGridView.TabIndex = 8;
            // 
            // ebookBookDataSetBindingSource
            // 
            this.ebookBookDataSetBindingSource.DataSource = this.ebookBookDataSet;
            this.ebookBookDataSetBindingSource.Position = 0;
            // 
            // ebookBookDataSet
            // 
            this.ebookBookDataSet.DataSetName = "EbookBookDataSet";
            this.ebookBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewBookButton
            // 
            this.viewBookButton.Location = new System.Drawing.Point(570, 741);
            this.viewBookButton.Name = "viewBookButton";
            this.viewBookButton.Size = new System.Drawing.Size(256, 104);
            this.viewBookButton.TabIndex = 9;
            this.viewBookButton.Text = "View";
            this.viewBookButton.UseVisualStyleBackColor = true;
            this.viewBookButton.Click += new System.EventHandler(this.viewBookButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(55, 30);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(211, 76);
            this.homeButton.TabIndex = 10;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 968);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.viewBookButton);
            this.Controls.Add(this.libraryBooksGridView);
            this.Name = "Library";
            this.Text = "Library";
            ((System.ComponentModel.ISupportInitialize)(this.libraryBooksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebookBookDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebookBookDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView libraryBooksGridView;
        private System.Windows.Forms.BindingSource ebookBookDataSetBindingSource;
        private EbookBookDataSet ebookBookDataSet;
        private System.Windows.Forms.Button viewBookButton;
        private System.Windows.Forms.Button homeButton;
    }
}