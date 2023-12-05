namespace Read_E_Books
{
    partial class Cart
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
            this.homeButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.confirmPurchaseButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.paymentGroupBox = new System.Windows.Forms.GroupBox();
            this.cardTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.cardLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.paymentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(32, 21);
            this.homeButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(200, 55);
            this.homeButton.TabIndex = 4;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Green;
            this.welcomeLabel.Location = new System.Drawing.Point(789, 21);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(304, 74);
            this.welcomeLabel.TabIndex = 3;
            this.welcomeLabel.Text = "Checkout";
            // 
            // confirmPurchaseButton
            // 
            this.confirmPurchaseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.confirmPurchaseButton.Location = new System.Drawing.Point(1401, 634);
            this.confirmPurchaseButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.confirmPurchaseButton.Name = "confirmPurchaseButton";
            this.confirmPurchaseButton.Size = new System.Drawing.Size(285, 123);
            this.confirmPurchaseButton.TabIndex = 6;
            this.confirmPurchaseButton.Text = "Confirm Purchase";
            this.confirmPurchaseButton.UseVisualStyleBackColor = false;
            this.confirmPurchaseButton.Click += new System.EventHandler(this.confirmPurchaseButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.removeItemButton.Location = new System.Drawing.Point(821, 691);
            this.removeItemButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(199, 67);
            this.removeItemButton.TabIndex = 7;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = false;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1160, 576);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Cost:";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.BackColor = System.Drawing.SystemColors.Control;
            this.totalCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalCostLabel.Location = new System.Drawing.Point(1331, 552);
            this.totalCostLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(355, 55);
            this.totalCostLabel.TabIndex = 9;
            // 
            // cartListBox
            // 
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.ItemHeight = 31;
            this.cartListBox.Location = new System.Drawing.Point(69, 136);
            this.cartListBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.ScrollAlwaysVisible = true;
            this.cartListBox.Size = new System.Drawing.Size(951, 531);
            this.cartListBox.TabIndex = 10;
            // 
            // paymentGroupBox
            // 
            this.paymentGroupBox.Controls.Add(this.cardTextBox);
            this.paymentGroupBox.Controls.Add(this.addressTextBox);
            this.paymentGroupBox.Controls.Add(this.nameTextBox);
            this.paymentGroupBox.Controls.Add(this.cardLabel);
            this.paymentGroupBox.Controls.Add(this.addressLabel);
            this.paymentGroupBox.Controls.Add(this.nameLabel);
            this.paymentGroupBox.Location = new System.Drawing.Point(1053, 168);
            this.paymentGroupBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.paymentGroupBox.Name = "paymentGroupBox";
            this.paymentGroupBox.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.paymentGroupBox.Size = new System.Drawing.Size(675, 323);
            this.paymentGroupBox.TabIndex = 11;
            this.paymentGroupBox.TabStop = false;
            this.paymentGroupBox.Text = "Payment Information";
            // 
            // cardTextBox
            // 
            this.cardTextBox.Location = new System.Drawing.Point(253, 234);
            this.cardTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cardTextBox.Name = "cardTextBox";
            this.cardTextBox.Size = new System.Drawing.Size(380, 38);
            this.cardTextBox.TabIndex = 17;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(253, 155);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(380, 38);
            this.addressTextBox.TabIndex = 16;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(253, 86);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(380, 38);
            this.nameTextBox.TabIndex = 15;
            // 
            // cardLabel
            // 
            this.cardLabel.AutoSize = true;
            this.cardLabel.Location = new System.Drawing.Point(16, 250);
            this.cardLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(197, 32);
            this.cardLabel.TabIndex = 14;
            this.cardLabel.Text = "Card Number :";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(16, 172);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(219, 32);
            this.addressLabel.TabIndex = 13;
            this.addressLabel.Text = "Billing Address :";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(16, 93);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(104, 32);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Name :";
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1798, 822);
            this.Controls.Add(this.paymentGroupBox);
            this.Controls.Add(this.cartListBox);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.confirmPurchaseButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.welcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Cart";
            this.Text = "Cart";
            this.paymentGroupBox.ResumeLayout(false);
            this.paymentGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button confirmPurchaseButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.GroupBox paymentGroupBox;
        private System.Windows.Forms.Label cardLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox cardTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}