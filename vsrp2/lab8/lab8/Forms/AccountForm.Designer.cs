namespace lab8.Forms
{
    partial class AccountForm
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
            this.authButton = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.adminRadioButton = new System.Windows.Forms.RadioButton();
            this.userRadioButton = new System.Windows.Forms.RadioButton();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authButton
            // 
            this.authButton.Location = new System.Drawing.Point(161, 312);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(147, 40);
            this.authButton.TabIndex = 0;
            this.authButton.Text = "password";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(161, 187);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(147, 27);
            this.userNameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(161, 255);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(147, 27);
            this.passwordTextBox.TabIndex = 2;
            // 
            // adminRadioButton
            // 
            this.adminRadioButton.AutoSize = true;
            this.adminRadioButton.Location = new System.Drawing.Point(161, 106);
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Size = new System.Drawing.Size(74, 24);
            this.adminRadioButton.TabIndex = 3;
            this.adminRadioButton.TabStop = true;
            this.adminRadioButton.Text = "Admin";
            this.adminRadioButton.UseVisualStyleBackColor = true;
            this.adminRadioButton.CheckedChanged += new System.EventHandler(this.adminRadioButton_CheckedChanged);
            // 
            // userRadioButton
            // 
            this.userRadioButton.AutoSize = true;
            this.userRadioButton.Location = new System.Drawing.Point(161, 146);
            this.userRadioButton.Name = "userRadioButton";
            this.userRadioButton.Size = new System.Drawing.Size(59, 24);
            this.userRadioButton.TabIndex = 4;
            this.userRadioButton.TabStop = true;
            this.userRadioButton.Text = "User";
            this.userRadioButton.UseVisualStyleBackColor = true;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(30, 187);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(78, 20);
            this.userNameLabel.TabIndex = 5;
            this.userNameLabel.Text = "UserName";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(30, 258);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(70, 20);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 481);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userRadioButton);
            this.Controls.Add(this.adminRadioButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.authButton);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button authButton;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private RadioButton adminRadioButton;
        private RadioButton userRadioButton;
        private Label userNameLabel;
        private Label passwordLabel;
    }
}