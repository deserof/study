namespace lab1
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
            this.addressLabel = new System.Windows.Forms.Label();
            this.CreatedTimeLabel = new System.Windows.Forms.Label();
            this.constructionStatusLabel = new System.Windows.Forms.Label();
            this.floorsLabel = new System.Windows.Forms.Label();
            this.entrancesLabel = new System.Windows.Forms.Label();
            this.constrStatusViewlabel = new System.Windows.Forms.Label();
            this.floorsViewlabel = new System.Windows.Forms.Label();
            this.entrancesViewlabel = new System.Windows.Forms.Label();
            this.createdTimeViewlabel = new System.Windows.Forms.Label();
            this.addressViewlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(297, 77);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(62, 20);
            this.addressLabel.TabIndex = 0;
            this.addressLabel.Text = "Address";
            // 
            // CreatedTimeLabel
            // 
            this.CreatedTimeLabel.AutoSize = true;
            this.CreatedTimeLabel.Location = new System.Drawing.Point(297, 324);
            this.CreatedTimeLabel.Name = "CreatedTimeLabel";
            this.CreatedTimeLabel.Size = new System.Drawing.Size(98, 20);
            this.CreatedTimeLabel.TabIndex = 4;
            this.CreatedTimeLabel.Text = "Created Time";
            // 
            // constructionStatusLabel
            // 
            this.constructionStatusLabel.AutoSize = true;
            this.constructionStatusLabel.Location = new System.Drawing.Point(297, 261);
            this.constructionStatusLabel.Name = "constructionStatusLabel";
            this.constructionStatusLabel.Size = new System.Drawing.Size(141, 20);
            this.constructionStatusLabel.TabIndex = 12;
            this.constructionStatusLabel.Text = "Contsturction Status";
            // 
            // floorsLabel
            // 
            this.floorsLabel.AutoSize = true;
            this.floorsLabel.Location = new System.Drawing.Point(298, 198);
            this.floorsLabel.Name = "floorsLabel";
            this.floorsLabel.Size = new System.Drawing.Size(49, 20);
            this.floorsLabel.TabIndex = 11;
            this.floorsLabel.Text = "Floors";
            // 
            // entrancesLabel
            // 
            this.entrancesLabel.AutoSize = true;
            this.entrancesLabel.Location = new System.Drawing.Point(297, 139);
            this.entrancesLabel.Name = "entrancesLabel";
            this.entrancesLabel.Size = new System.Drawing.Size(72, 20);
            this.entrancesLabel.TabIndex = 10;
            this.entrancesLabel.Text = "Entrances";
            // 
            // ConstrStatusViewlabel
            // 
            this.constrStatusViewlabel.AutoSize = true;
            this.constrStatusViewlabel.Location = new System.Drawing.Point(492, 261);
            this.constrStatusViewlabel.Name = "ConstrStatusViewlabel";
            this.constrStatusViewlabel.Size = new System.Drawing.Size(141, 20);
            this.constrStatusViewlabel.TabIndex = 17;
            this.constrStatusViewlabel.Text = "Contsturction Status";
            // 
            // floorsViewlabel
            // 
            this.floorsViewlabel.AutoSize = true;
            this.floorsViewlabel.Location = new System.Drawing.Point(493, 198);
            this.floorsViewlabel.Name = "floorsViewlabel";
            this.floorsViewlabel.Size = new System.Drawing.Size(49, 20);
            this.floorsViewlabel.TabIndex = 16;
            this.floorsViewlabel.Text = "Floors";
            // 
            // entrancesViewlabel
            // 
            this.entrancesViewlabel.AutoSize = true;
            this.entrancesViewlabel.Location = new System.Drawing.Point(492, 139);
            this.entrancesViewlabel.Name = "entrancesViewlabel";
            this.entrancesViewlabel.Size = new System.Drawing.Size(72, 20);
            this.entrancesViewlabel.TabIndex = 15;
            this.entrancesViewlabel.Text = "Entrances";
            // 
            // createdTimeViewlabel
            // 
            this.createdTimeViewlabel.AutoSize = true;
            this.createdTimeViewlabel.Location = new System.Drawing.Point(492, 324);
            this.createdTimeViewlabel.Name = "createdTimeViewlabel";
            this.createdTimeViewlabel.Size = new System.Drawing.Size(98, 20);
            this.createdTimeViewlabel.TabIndex = 14;
            this.createdTimeViewlabel.Text = "Created Time";
            // 
            // addressViewlabel
            // 
            this.addressViewlabel.AutoSize = true;
            this.addressViewlabel.Location = new System.Drawing.Point(492, 77);
            this.addressViewlabel.Name = "addressViewlabel";
            this.addressViewlabel.Size = new System.Drawing.Size(62, 20);
            this.addressViewlabel.TabIndex = 13;
            this.addressViewlabel.Text = "Address";
            // 
            // ShowDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.constrStatusViewlabel);
            this.Controls.Add(this.floorsViewlabel);
            this.Controls.Add(this.entrancesViewlabel);
            this.Controls.Add(this.createdTimeViewlabel);
            this.Controls.Add(this.addressViewlabel);
            this.Controls.Add(this.constructionStatusLabel);
            this.Controls.Add(this.floorsLabel);
            this.Controls.Add(this.entrancesLabel);
            this.Controls.Add(this.CreatedTimeLabel);
            this.Controls.Add(this.addressLabel);
            this.Name = "ShowDataForm";
            this.Text = "ShowDataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label addressLabel;
        private Label CreatedTimeLabel;
        private Label constructionStatusLabel;
        private Label floorsLabel;
        private Label entrancesLabel;
        private Label constrStatusViewlabel;
        private Label floorsViewlabel;
        private Label entrancesViewlabel;
        private Label createdTimeViewlabel;
        private Label addressViewlabel;
    }
}