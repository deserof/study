namespace lab7
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelShelfLife = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelNumberOfTablets = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(148, 42);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(44, 16);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "label1";
            // 
            // labelShelfLife
            // 
            this.labelShelfLife.AutoSize = true;
            this.labelShelfLife.Location = new System.Drawing.Point(148, 82);
            this.labelShelfLife.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShelfLife.Name = "labelShelfLife";
            this.labelShelfLife.Size = new System.Drawing.Size(44, 16);
            this.labelShelfLife.TabIndex = 1;
            this.labelShelfLife.Text = "label2";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(148, 121);
            this.labelCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(44, 16);
            this.labelCountry.TabIndex = 2;
            this.labelCountry.Text = "label3";
            // 
            // labelNumberOfTablets
            // 
            this.labelNumberOfTablets.AutoSize = true;
            this.labelNumberOfTablets.Location = new System.Drawing.Point(148, 154);
            this.labelNumberOfTablets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumberOfTablets.Name = "labelNumberOfTablets";
            this.labelNumberOfTablets.Size = new System.Drawing.Size(44, 16);
            this.labelNumberOfTablets.TabIndex = 3;
            this.labelNumberOfTablets.Text = "label4";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(152, 208);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 28);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // ShowDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 256);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelNumberOfTablets);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelShelfLife);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ShowDataForm";
            this.Text = "ShowDataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelShelfLife;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelNumberOfTablets;
        private System.Windows.Forms.Button buttonOk;
    }
}