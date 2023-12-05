namespace Read_E_Books
{
    partial class welcomeForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.groupLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Green;
            this.welcomeLabel.Location = new System.Drawing.Point(453, 42);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(787, 74);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Read-E-Books";
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Font = new System.Drawing.Font("Arial Narrow", 7.75F, System.Drawing.FontStyle.Bold);
            this.groupLabel.Location = new System.Drawing.Point(17, 773);
            this.groupLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(549, 31);
            this.groupLabel.TabIndex = 1;
            this.groupLabel.Text = "Project Group Members: Amer, Alexander, and Arjun";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(1514, 670);
            this.loginButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(216, 78);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Go to Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(1005, 498);
            this.createButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(296, 93);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create Account";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(410, 398);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(346, 39);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Enter your password :";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(410, 271);
            this.userLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(351, 39);
            this.userLabel.TabIndex = 5;
            this.userLabel.Text = "Enter your username :";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(754, 398);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.passwordTextBox.MaxLength = 25;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(547, 45);
            this.passwordTextBox.TabIndex = 6;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(754, 271);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.usernameTextBox.MaxLength = 25;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(547, 45);
            this.usernameTextBox.TabIndex = 7;
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLabel.ForeColor = System.Drawing.Color.Green;
            this.signUpLabel.Location = new System.Drawing.Point(409, 172);
            this.signUpLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(169, 46);
            this.signUpLabel.TabIndex = 8;
            this.signUpLabel.Text = "Sign Up";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.Green;
            this.loginLabel.Location = new System.Drawing.Point(762, 684);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(727, 46);
            this.loginLabel.TabIndex = 9;
            this.loginLabel.Text = "Already have an account? Login here:";
            // 
            // welcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1798, 822);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.signUpLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.welcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "welcomeForm";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label signUpLabel;
        private System.Windows.Forms.Label loginLabel;
    }
}

