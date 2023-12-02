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
            this.ebookBookDataSet = new Read_E_Books.EbookBookDataSet();
            this.ebookBookDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.libraryBooksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebookBookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebookBookDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryBooksGridView
            // 
            this.libraryBooksGridView.AutoGenerateColumns = false;
            this.libraryBooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.libraryBooksGridView.DataSource = this.ebookBookDataSetBindingSource;
            this.libraryBooksGridView.Location = new System.Drawing.Point(69, 172);
            this.libraryBooksGridView.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.libraryBooksGridView.Name = "libraryBooksGridView";
            this.libraryBooksGridView.RowHeadersWidth = 102;
            this.libraryBooksGridView.Size = new System.Drawing.Size(1197, 525);
            this.libraryBooksGridView.TabIndex = 8;
            // 
            // ebookBookDataSet
            // 
            this.ebookBookDataSet.DataSetName = "EbookBookDataSet";
            this.ebookBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ebookBookDataSetBindingSource
            // 
            this.ebookBookDataSetBindingSource.DataSource = this.ebookBookDataSet;
            this.ebookBookDataSetBindingSource.Position = 0;
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 968);
            this.Controls.Add(this.libraryBooksGridView);
            this.Name = "Library";
            this.Text = "Library";
            ((System.ComponentModel.ISupportInitialize)(this.libraryBooksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebookBookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebookBookDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView libraryBooksGridView;
        private System.Windows.Forms.BindingSource ebookBookDataSetBindingSource;
        private EbookBookDataSet ebookBookDataSet;
    }
}