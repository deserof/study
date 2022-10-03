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
            this.windowsTextBox = new System.Windows.Forms.TextBox();
            this.windowsLabel = new System.Windows.Forms.Label();
            this.roomsTextBox = new System.Windows.Forms.TextBox();
            this.roomsLabel = new System.Windows.Forms.Label();
            this.squareLabel = new System.Windows.Forms.Label();
            this.squareTextBox = new System.Windows.Forms.TextBox();
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
            this.addDataButton.Location = new System.Drawing.Point(277, 257);
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
            // windowsTextBox
            // 
            this.windowsTextBox.Location = new System.Drawing.Point(259, 179);
            this.windowsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.windowsTextBox.Name = "windowsTextBox";
            this.windowsTextBox.Size = new System.Drawing.Size(133, 23);
            this.windowsTextBox.TabIndex = 10;
            // 
            // windowsLabel
            // 
            this.windowsLabel.AutoSize = true;
            this.windowsLabel.Location = new System.Drawing.Point(130, 179);
            this.windowsLabel.Name = "windowsLabel";
            this.windowsLabel.Size = new System.Drawing.Size(56, 15);
            this.windowsLabel.TabIndex = 11;
            this.windowsLabel.Text = "Windows";
            // 
            // roomsTextBox
            // 
            this.roomsTextBox.Location = new System.Drawing.Point(259, 218);
            this.roomsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomsTextBox.Name = "roomsTextBox";
            this.roomsTextBox.Size = new System.Drawing.Size(133, 23);
            this.roomsTextBox.TabIndex = 12;
            // 
            // roomsLabel
            // 
            this.roomsLabel.AutoSize = true;
            this.roomsLabel.Location = new System.Drawing.Point(130, 221);
            this.roomsLabel.Name = "roomsLabel";
            this.roomsLabel.Size = new System.Drawing.Size(44, 15);
            this.roomsLabel.TabIndex = 13;
            this.roomsLabel.Text = "Rooms";
            // 
            // squareLabel
            // 
            this.squareLabel.AutoSize = true;
            this.squareLabel.Location = new System.Drawing.Point(538, 48);
            this.squareLabel.Name = "squareLabel";
            this.squareLabel.Size = new System.Drawing.Size(43, 15);
            this.squareLabel.TabIndex = 15;
            this.squareLabel.Text = "Square";
            // 
            // squareTextBox
            // 
            this.squareTextBox.Location = new System.Drawing.Point(667, 46);
            this.squareTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.squareTextBox.Name = "squareTextBox";
            this.squareTextBox.Size = new System.Drawing.Size(133, 23);
            this.squareTextBox.TabIndex = 14;
            // 
            // EnterDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 355);
            this.Controls.Add(this.squareLabel);
            this.Controls.Add(this.squareTextBox);
            this.Controls.Add(this.roomsLabel);
            this.Controls.Add(this.roomsTextBox);
            this.Controls.Add(this.windowsLabel);
            this.Controls.Add(this.windowsTextBox);
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
        private TextBox windowsTextBox;
        private Label windowsLabel;
        private TextBox roomsTextBox;
        private Label roomsLabel;
        private Label squareLabel;
        private TextBox squareTextBox;
    }
}