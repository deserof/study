namespace lab7
{
    partial class Input
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxShelfLife = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfTablets = new System.Windows.Forms.TextBox();
            this.labelShelfLife = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelNumberOfTablets = new System.Windows.Forms.Label();
            this.buttonSetData = new System.Windows.Forms.Button();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.labelError = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTitle.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTitle.Location = new System.Drawing.Point(207, 129);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(169, 25);
            this.textBoxTitle.TabIndex = 0;
            this.textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxShelfLife
            // 
            this.textBoxShelfLife.Location = new System.Drawing.Point(207, 174);
            this.textBoxShelfLife.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxShelfLife.Multiline = true;
            this.textBoxShelfLife.Name = "textBoxShelfLife";
            this.textBoxShelfLife.Size = new System.Drawing.Size(169, 26);
            this.textBoxShelfLife.TabIndex = 1;
            this.textBoxShelfLife.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNumberOfTablets
            // 
            this.textBoxNumberOfTablets.Location = new System.Drawing.Point(207, 285);
            this.textBoxNumberOfTablets.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumberOfTablets.Multiline = true;
            this.textBoxNumberOfTablets.Name = "textBoxNumberOfTablets";
            this.textBoxNumberOfTablets.Size = new System.Drawing.Size(169, 26);
            this.textBoxNumberOfTablets.TabIndex = 3;
            this.textBoxNumberOfTablets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelShelfLife
            // 
            this.labelShelfLife.AutoSize = true;
            this.labelShelfLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShelfLife.Location = new System.Drawing.Point(73, 184);
            this.labelShelfLife.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShelfLife.Name = "labelShelfLife";
            this.labelShelfLife.Size = new System.Drawing.Size(102, 16);
            this.labelShelfLife.TabIndex = 5;
            this.labelShelfLife.Text = "Срок годности";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountry.Location = new System.Drawing.Point(23, 232);
            this.labelCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(152, 16);
            this.labelCountry.TabIndex = 6;
            this.labelCountry.Text = "Страна производства";
            // 
            // labelNumberOfTablets
            // 
            this.labelNumberOfTablets.AutoSize = true;
            this.labelNumberOfTablets.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberOfTablets.Location = new System.Drawing.Point(26, 285);
            this.labelNumberOfTablets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumberOfTablets.Name = "labelNumberOfTablets";
            this.labelNumberOfTablets.Size = new System.Drawing.Size(149, 16);
            this.labelNumberOfTablets.TabIndex = 7;
            this.labelNumberOfTablets.Text = "Количество таблеток";
            // 
            // buttonSetData
            // 
            this.buttonSetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSetData.Location = new System.Drawing.Point(179, 360);
            this.buttonSetData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetData.Name = "buttonSetData";
            this.buttonSetData.Size = new System.Drawing.Size(221, 37);
            this.buttonSetData.TabIndex = 8;
            this.buttonSetData.Text = "Ввести";
            this.buttonSetData.UseVisualStyleBackColor = true;
            this.buttonSetData.Click += new System.EventHandler(this.buttonSetData_Click);
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(207, 229);
            this.comboBoxCountry.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(169, 24);
            this.comboBoxCountry.TabIndex = 9;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(218, 327);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(139, 16);
            this.labelError.TabIndex = 10;
            this.labelError.Text = "Заполните все поля";
            this.labelError.Visible = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(102, 138);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(73, 16);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Название";
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(461, 446);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.buttonSetData);
            this.Controls.Add(this.labelNumberOfTablets);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelShelfLife);
            this.Controls.Add(this.textBoxNumberOfTablets);
            this.Controls.Add(this.textBoxShelfLife);
            this.Controls.Add(this.textBoxTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataForm";
            this.Text = "Компьютер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxShelfLife;
        private System.Windows.Forms.TextBox textBoxNumberOfTablets;
        private System.Windows.Forms.Label labelShelfLife;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelNumberOfTablets;
        private System.Windows.Forms.Button buttonSetData;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelTitle;
    }
}