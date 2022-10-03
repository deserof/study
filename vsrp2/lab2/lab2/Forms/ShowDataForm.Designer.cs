namespace lab2
{
    partial class ShowDataForm
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
            this.buildingsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buildingsListBox
            // 
            this.buildingsListBox.FormattingEnabled = true;
            this.buildingsListBox.ItemHeight = 15;
            this.buildingsListBox.Location = new System.Drawing.Point(12, 32);
            this.buildingsListBox.Name = "buildingsListBox";
            this.buildingsListBox.Size = new System.Drawing.Size(645, 244);
            this.buildingsListBox.TabIndex = 0;
            // 
            // ShowDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.buildingsListBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ShowDataForm";
            this.Text = "ShowDataForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox buildingsListBox;
    }
}