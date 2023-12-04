namespace Read_E_Books
{
    partial class Login
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
            this.loginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginUsernameTextBox
            // 
            this.loginUsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginUsernameTextBox.Location = new System.Drawing.Point(247, 121);
            this.loginUsernameTextBox.MaxLength = 25;
            this.loginUsernameTextBox.Name = "loginUsernameTextBox";
            this.loginUsernameTextBox.Size = new System.Drawing.Size(118, 20);
            this.loginUsernameTextBox.TabIndex = 11;
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPasswordTextBox.Location = new System.Drawing.Point(247, 174);
            this.loginPasswordTextBox.MaxLength = 25;
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.PasswordChar = '*';
            this.loginPasswordTextBox.Size = new System.Drawing.Size(118, 20);
            this.loginPasswordTextBox.TabIndex = 10;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(118, 121);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(123, 16);
            this.userLabel.TabIndex = 9;
            this.userLabel.Text = "Enter your username :";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(118, 174);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(123, 16);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Enter your password :";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(5, 5);
            this.backButton.Margin = new System.Windows.Forms.Padding(1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(71, 33);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(404, 314);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(74, 33);
            this.loginButton.TabIndex = 14;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 359);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.loginUsernameTextBox);
            this.Controls.Add(this.loginPasswordTextBox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.passwordLabel);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginUsernameTextBox;
        private System.Windows.Forms.TextBox loginPasswordTextBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button loginButton;
    }
}