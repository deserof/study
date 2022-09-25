namespace lab1
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
            this.SuspendLayout();
            // 
            // enterData
            // 
            this.enterData.Location = new System.Drawing.Point(74, 67);
            this.enterData.Name = "enterData";
            this.enterData.Size = new System.Drawing.Size(94, 29);
            this.enterData.TabIndex = 0;
            this.enterData.Text = "Enter Data";
            this.enterData.UseVisualStyleBackColor = true;
            this.enterData.Click += new System.EventHandler(this.enterData_Click);
            // 
            // showData
            // 
            this.showData.Location = new System.Drawing.Point(74, 147);
            this.showData.Name = "showData";
            this.showData.Size = new System.Drawing.Size(94, 29);
            this.showData.TabIndex = 1;
            this.showData.Text = "Show Data";
            this.showData.UseVisualStyleBackColor = true;
            this.showData.Click += new System.EventHandler(this.showData_Click);
            // 
            // validLabel
            // 
            this.validLabel.AutoSize = true;
            this.validLabel.ForeColor = System.Drawing.Color.Red;
            this.validLabel.Location = new System.Drawing.Point(207, 155);
            this.validLabel.Name = "validLabel";
            this.validLabel.Size = new System.Drawing.Size(101, 20);
            this.validLabel.TabIndex = 2;
            this.validLabel.Text = "Data is empty";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.validLabel);
            this.Controls.Add(this.showData);
            this.Controls.Add(this.enterData);
            this.Name = "MainForm";
            this.Text = "Lab 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button enterData;
        private Button showData;
        private Label validLabel;
    }
}