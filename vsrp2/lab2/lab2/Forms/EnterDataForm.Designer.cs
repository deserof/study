namespace lab2
{
    partial class EnterDataForm
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
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.floorsTextBox = new System.Windows.Forms.TextBox();
            this.entrancesTextBox = new System.Windows.Forms.TextBox();
            this.constructionStatusComboBox = new System.Windows.Forms.ComboBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.entrancesLabel = new System.Windows.Forms.Label();
            this.floorsLabel = new System.Windows.Forms.Label();
            this.constructionStatusLabel = new System.Windows.Forms.Label();
            this.addDataButton = new System.Windows.Forms.Button();
            this.validLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(259, 45);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(133, 23);
            this.addressTextBox.TabIndex = 0;
            // 
            // floorsTextBox
            // 
            this.floorsTextBox.Location = new System.Drawing.Point(259, 110);
            this.floorsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.floorsTextBox.Name = "floorsTextBox";
            this.floorsTextBox.Size = new System.Drawing.Size(133, 23);
            this.floorsTextBox.TabIndex = 1;
            // 
            // entrancesTextBox
            // 
            this.entrancesTextBox.Location = new System.Drawing.Point(259, 77);
            this.entrancesTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.entrancesTextBox.Name = "entrancesTextBox";
            this.entrancesTextBox.Size = new System.Drawing.Size(133, 23);
            this.entrancesTextBox.TabIndex = 2;
            // 
            // constructionStatusComboBox
            // 
            this.constructionStatusComboBox.FormattingEnabled = true;
            this.constructionStatusComboBox.Location = new System.Drawing.Point(259, 142);
            this.constructionStatusComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.constructionStatusComboBox.Name = "constructionStatusComboBox";
            this.constructionStatusComboBox.Size = new System.Drawing.Size(133, 23);
            this.constructionStatusComboBox.TabIndex = 3;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(130, 47);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(49, 15);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address";
            // 
            // entrancesLabel
            // 
            this.entrancesLabel.AutoSize = true;
            this.entrancesLabel.Location = new System.Drawing.Point(130, 80);
            this.entrancesLabel.Name = "entrancesLabel";
            this.entrancesLabel.Size = new System.Drawing.Size(58, 15);
            this.entrancesLabel.TabIndex = 5;
            this.entrancesLabel.Text = "Entrances";
            // 
            // floorsLabel
            // 
            this.floorsLabel.AutoSize = true;
            this.floorsLabel.Location = new System.Drawing.Point(130, 112);
            this.floorsLabel.Name = "floorsLabel";
            this.floorsLabel.Size = new System.Drawing.Size(39, 15);
            this.floorsLabel.TabIndex = 6;
            this.floorsLabel.Text = "Floors";
            // 
            // constructionStatusLabel
            // 
            this.constructionStatusLabel.AutoSize = true;
            this.constructionStatusLabel.Location = new System.Drawing.Point(130, 145);
            this.constructionStatusLabel.Name = "constructionStatusLabel";
            this.constructionStatusLabel.Size = new System.Drawing.Size(115, 15);
            this.constructionStatusLabel.TabIndex = 7;
            this.constructionStatusLabel.Text = "Contsturction Status";
            // 
            // addDataButton
            // 
            this.addDataButton.Location = new System.Drawing.Point(276, 187);
            this.addDataButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addDataButton.Name = "addDataButton";
            this.addDataButton.Size = new System.Drawing.Size(82, 22);
            this.addDataButton.TabIndex = 8;
            this.addDataButton.Text = "Add";
            this.addDataButton.UseVisualStyleBackColor = true;
            this.addDataButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // validLabel
            // 
            this.validLabel.AutoSize = true;
            this.validLabel.ForeColor = System.Drawing.Color.Red;
            this.validLabel.Location = new System.Drawing.Point(277, 15);
            this.validLabel.Name = "validLabel";
            this.validLabel.Size = new System.Drawing.Size(74, 15);
            this.validLabel.TabIndex = 9;
            this.validLabel.Text = "Wrong Input";
            // 
            // EnterDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 270);
            this.Controls.Add(this.validLabel);
            this.Controls.Add(this.addDataButton);
            this.Controls.Add(this.constructionStatusLabel);
            this.Controls.Add(this.floorsLabel);
            this.Controls.Add(this.entrancesLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.constructionStatusComboBox);
            this.Controls.Add(this.entrancesTextBox);
            this.Controls.Add(this.floorsTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EnterDataForm";
            this.Text = "EnterDataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox addressTextBox;
        private TextBox floorsTextBox;
        private TextBox entrancesTextBox;
        private ComboBox constructionStatusComboBox;
        private Label addressLabel;
        private Label entrancesLabel;
        private Label floorsLabel;
        private Label constructionStatusLabel;
        private Button addDataButton;
        private Label validLabel;
    }
}