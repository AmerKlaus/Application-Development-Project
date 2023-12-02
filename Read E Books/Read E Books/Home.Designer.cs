namespace Read_E_Books
{
    partial class Home
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
            this.libraryButton = new System.Windows.Forms.Button();
            this.shopButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // libraryButton
            // 
            this.libraryButton.Location = new System.Drawing.Point(352, 131);
            this.libraryButton.Name = "libraryButton";
            this.libraryButton.Size = new System.Drawing.Size(403, 129);
            this.libraryButton.TabIndex = 0;
            this.libraryButton.Text = "My Library";
            this.libraryButton.UseVisualStyleBackColor = true;
            this.libraryButton.Click += new System.EventHandler(this.libraryButton_Click);
            // 
            // shopButton
            // 
            this.shopButton.Location = new System.Drawing.Point(352, 322);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(403, 129);
            this.shopButton.TabIndex = 1;
            this.shopButton.Text = "Bookstore";
            this.shopButton.UseVisualStyleBackColor = true;
            this.shopButton.Click += new System.EventHandler(this.shopButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(469, 511);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(140, 129);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(990, 28);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(140, 129);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 736);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.shopButton);
            this.Controls.Add(this.libraryButton);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button libraryButton;
        private System.Windows.Forms.Button shopButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button logoutButton;
    }
}