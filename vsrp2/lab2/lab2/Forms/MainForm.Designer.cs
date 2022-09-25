namespace lab2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterData = new System.Windows.Forms.Button();
            this.showData = new System.Windows.Forms.Button();
            this.validLabel = new System.Windows.Forms.Label();
            this.chooseGroupBox = new System.Windows.Forms.GroupBox();
            this.cottageRadioButton = new System.Windows.Forms.RadioButton();
            this.appartmentHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.chooseGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterData
            // 
            this.enterData.Location = new System.Drawing.Point(65, 50);
            this.enterData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enterData.Name = "enterData";
            this.enterData.Size = new System.Drawing.Size(82, 22);
            this.enterData.TabIndex = 0;
            this.enterData.Text = "Enter Data";
            this.enterData.UseVisualStyleBackColor = true;
            this.enterData.Click += new System.EventHandler(this.enterData_Click);
            // 
            // showData
            // 
            this.showData.Location = new System.Drawing.Point(65, 110);
            this.showData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showData.Name = "showData";
            this.showData.Size = new System.Drawing.Size(82, 22);
            this.showData.TabIndex = 1;
            this.showData.Text = "Show Data";
            this.showData.UseVisualStyleBackColor = true;
            this.showData.Click += new System.EventHandler(this.showData_Click);
            // 
            // validLabel
            // 
            this.validLabel.AutoSize = true;
            this.validLabel.ForeColor = System.Drawing.Color.Red;
            this.validLabel.Location = new System.Drawing.Point(181, 116);
            this.validLabel.Name = "validLabel";
            this.validLabel.Size = new System.Drawing.Size(79, 15);
            this.validLabel.TabIndex = 2;
            this.validLabel.Text = "Data is empty";
            // 
            // chooseGroupBox
            // 
            this.chooseGroupBox.Controls.Add(this.cottageRadioButton);
            this.chooseGroupBox.Controls.Add(this.appartmentHouseRadioButton);
            this.chooseGroupBox.Location = new System.Drawing.Point(343, 41);
            this.chooseGroupBox.Name = "chooseGroupBox";
            this.chooseGroupBox.Size = new System.Drawing.Size(160, 100);
            this.chooseGroupBox.TabIndex = 11;
            this.chooseGroupBox.TabStop = false;
            this.chooseGroupBox.Text = "Choose";
            // 
            // cottageRadioButton
            // 
            this.cottageRadioButton.AutoSize = true;
            this.cottageRadioButton.Location = new System.Drawing.Point(15, 66);
            this.cottageRadioButton.Name = "cottageRadioButton";
            this.cottageRadioButton.Size = new System.Drawing.Size(67, 19);
            this.cottageRadioButton.TabIndex = 1;
            this.cottageRadioButton.TabStop = true;
            this.cottageRadioButton.Text = "Cottage";
            this.cottageRadioButton.UseVisualStyleBackColor = true;
            // 
            // appartmentHouseRadioButton
            // 
            this.appartmentHouseRadioButton.AutoSize = true;
            this.appartmentHouseRadioButton.Location = new System.Drawing.Point(15, 22);
            this.appartmentHouseRadioButton.Name = "appartmentHouseRadioButton";
            this.appartmentHouseRadioButton.Size = new System.Drawing.Size(126, 19);
            this.appartmentHouseRadioButton.TabIndex = 0;
            this.appartmentHouseRadioButton.TabStop = true;
            this.appartmentHouseRadioButton.Text = "Appartment House";
            this.appartmentHouseRadioButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.chooseGroupBox);
            this.Controls.Add(this.validLabel);
            this.Controls.Add(this.showData);
            this.Controls.Add(this.enterData);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Lab 2";
            this.chooseGroupBox.ResumeLayout(false);
            this.chooseGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button enterData;
        private Button showData;
        private Label validLabel;
        private GroupBox chooseGroupBox;
        private RadioButton cottageRadioButton;
        private RadioButton appartmentHouseRadioButton;
    }
}