namespace Read_E_Books
{
    partial class Settings
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.changeUsernameTextBox = new System.Windows.Forms.TextBox();
            this.changePasswordTextBox = new System.Windows.Forms.TextBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.changeUsernameButton = new System.Windows.Forms.Button();
            this.accountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Username:";
            // 
            // changeUsernameTextBox
            // 
            this.changeUsernameTextBox.Location = new System.Drawing.Point(89, 124);
            this.changeUsernameTextBox.Name = "changeUsernameTextBox";
            this.changeUsernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.changeUsernameTextBox.TabIndex = 13;
            // 
            // changePasswordTextBox
            // 
            this.changePasswordTextBox.Location = new System.Drawing.Point(89, 207);
            this.changePasswordTextBox.Name = "changePasswordTextBox";
            this.changePasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.changePasswordTextBox.TabIndex = 12;
            this.changePasswordTextBox.UseSystemPasswordChar = true;
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(12, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(84, 23);
            this.homeButton.TabIndex = 11;
            this.homeButton.Text = "Home Button";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(161, 257);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(116, 23);
            this.changePasswordButton.TabIndex = 10;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // changeUsernameButton
            // 
            this.changeUsernameButton.Location = new System.Drawing.Point(15, 257);
            this.changeUsernameButton.Name = "changeUsernameButton";
            this.changeUsernameButton.Size = new System.Drawing.Size(115, 23);
            this.changeUsernameButton.TabIndex = 9;
            this.changeUsernameButton.Text = "change Username\r\n";
            this.changeUsernameButton.UseVisualStyleBackColor = true;
            this.changeUsernameButton.Click += new System.EventHandler(this.changeUsernameButton_Click);
            // 
            // accountLabel
            // 
            this.accountLabel.Location = new System.Drawing.Point(305, 9);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(336, 368);
            this.accountLabel.TabIndex = 8;
            this.accountLabel.Text = "accountLabel\r\n";
            this.accountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeUsernameTextBox);
            this.Controls.Add(this.changePasswordTextBox);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.changeUsernameButton);
            this.Controls.Add(this.accountLabel);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox changeUsernameTextBox;
        private System.Windows.Forms.TextBox changePasswordTextBox;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button changeUsernameButton;
        private System.Windows.Forms.Label accountLabel;
    }
}