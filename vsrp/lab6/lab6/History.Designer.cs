namespace lab6
{
    partial class History
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
            this.ReplaceHistoryLabel = new System.Windows.Forms.Label();
            this.RemoveHistoryLabel = new System.Windows.Forms.Label();
            this.ReplaceHistoryText = new System.Windows.Forms.Label();
            this.RemoveHistoryText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReplaceHistoryLabel
            // 
            this.ReplaceHistoryLabel.AutoSize = true;
            this.ReplaceHistoryLabel.Location = new System.Drawing.Point(12, 9);
            this.ReplaceHistoryLabel.Name = "ReplaceHistoryLabel";
            this.ReplaceHistoryLabel.Size = new System.Drawing.Size(113, 20);
            this.ReplaceHistoryLabel.TabIndex = 0;
            this.ReplaceHistoryLabel.Text = "Replace History";
            // 
            // RemoveHistoryLabel
            // 
            this.RemoveHistoryLabel.AutoSize = true;
            this.RemoveHistoryLabel.Location = new System.Drawing.Point(12, 213);
            this.RemoveHistoryLabel.Name = "RemoveHistoryLabel";
            this.RemoveHistoryLabel.Size = new System.Drawing.Size(114, 20);
            this.RemoveHistoryLabel.TabIndex = 1;
            this.RemoveHistoryLabel.Text = "Remove History";
            // 
            // ReplaceHistoryText
            // 
            this.ReplaceHistoryText.AutoSize = true;
            this.ReplaceHistoryText.Location = new System.Drawing.Point(204, 9);
            this.ReplaceHistoryText.Name = "ReplaceHistoryText";
            this.ReplaceHistoryText.Size = new System.Drawing.Size(0, 20);
            this.ReplaceHistoryText.TabIndex = 2;
            // 
            // RemoveHistoryText
            // 
            this.RemoveHistoryText.AutoSize = true;
            this.RemoveHistoryText.Location = new System.Drawing.Point(204, 213);
            this.RemoveHistoryText.Name = "RemoveHistoryText";
            this.RemoveHistoryText.Size = new System.Drawing.Size(0, 20);
            this.RemoveHistoryText.TabIndex = 3;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 496);
            this.Controls.Add(this.RemoveHistoryText);
            this.Controls.Add(this.ReplaceHistoryText);
            this.Controls.Add(this.RemoveHistoryLabel);
            this.Controls.Add(this.ReplaceHistoryLabel);
            this.Name = "History";
            this.Text = "History";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReplaceHistoryLabel;
        private System.Windows.Forms.Label RemoveHistoryLabel;
        private System.Windows.Forms.Label ReplaceHistoryText;
        private System.Windows.Forms.Label RemoveHistoryText;
    }
}