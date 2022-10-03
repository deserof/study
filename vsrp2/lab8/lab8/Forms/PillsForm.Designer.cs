namespace laba8
{
    partial class PillsForm
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
            this.comboBoxTitle = new System.Windows.Forms.ComboBox();
            this.comboBoxShelfLife = new System.Windows.Forms.ComboBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelShelfLife = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelMinimalAge = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.buttonSetData = new System.Windows.Forms.Button();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.comboBoxMinimalAge = new System.Windows.Forms.ComboBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxTitle
            // 
            this.comboBoxTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTitle.FormattingEnabled = true;
            this.comboBoxTitle.Items.AddRange(new object[] {
            "Антиоксикапс",
            "Омепразол",
            "Мегасеф",
            "Биоблис"});
            this.comboBoxTitle.Location = new System.Drawing.Point(259, 29);
            this.comboBoxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTitle.Name = "comboBoxTitle";
            this.comboBoxTitle.Size = new System.Drawing.Size(140, 23);
            this.comboBoxTitle.TabIndex = 0;
            // 
            // comboBoxShelfLife
            // 
            this.comboBoxShelfLife.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShelfLife.FormattingEnabled = true;
            this.comboBoxShelfLife.Items.AddRange(new object[] {
            "1 месяц",
            "3 месяца",
            "6 месяцев",
            "1 год",
            "3 года"});
            this.comboBoxShelfLife.Location = new System.Drawing.Point(259, 125);
            this.comboBoxShelfLife.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxShelfLife.Name = "comboBoxShelfLife";
            this.comboBoxShelfLife.Size = new System.Drawing.Size(140, 23);
            this.comboBoxShelfLife.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(180, 32);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(59, 15);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Название";
            // 
            // labelShelfLife
            // 
            this.labelShelfLife.AutoSize = true;
            this.labelShelfLife.Location = new System.Drawing.Point(152, 128);
            this.labelShelfLife.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShelfLife.Name = "labelShelfLife";
            this.labelShelfLife.Size = new System.Drawing.Size(88, 15);
            this.labelShelfLife.TabIndex = 4;
            this.labelShelfLife.Text = "Срок годности";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(109, 226);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(124, 15);
            this.labelQuantity.TabIndex = 5;
            this.labelQuantity.Text = "Количество таблеток";
            // 
            // labelMinimalAge
            // 
            this.labelMinimalAge.AutoSize = true;
            this.labelMinimalAge.Location = new System.Drawing.Point(12, 177);
            this.labelMinimalAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinimalAge.Name = "labelMinimalAge";
            this.labelMinimalAge.Size = new System.Drawing.Size(241, 15);
            this.labelMinimalAge.TabIndex = 6;
            this.labelMinimalAge.Text = "Минимальный возраст при употреблении";
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(259, 269);
            this.textBoxColor.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(140, 23);
            this.textBoxColor.TabIndex = 9;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(206, 269);
            this.labelColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(33, 15);
            this.labelColor.TabIndex = 10;
            this.labelColor.Text = "Цвет";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(117, 79);
            this.labelCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(119, 15);
            this.labelCountry.TabIndex = 12;
            this.labelCountry.Text = "Срана производства";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Items.AddRange(new object[] {
            "Беларусь",
            "Россия",
            "Китай",
            "Германия"});
            this.comboBoxCountry.Location = new System.Drawing.Point(259, 75);
            this.comboBoxCountry.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(140, 23);
            this.comboBoxCountry.TabIndex = 13;
            // 
            // buttonSetData
            // 
            this.buttonSetData.Location = new System.Drawing.Point(260, 311);
            this.buttonSetData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetData.Name = "buttonSetData";
            this.buttonSetData.Size = new System.Drawing.Size(94, 26);
            this.buttonSetData.TabIndex = 14;
            this.buttonSetData.Text = "Подтвердить";
            this.buttonSetData.UseVisualStyleBackColor = true;
            this.buttonSetData.Click += new System.EventHandler(this.buttonSetData_Click);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(260, 223);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(140, 23);
            this.textBoxQuantity.TabIndex = 15;
            // 
            // comboBoxMinimalAge
            // 
            this.comboBoxMinimalAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMinimalAge.FormattingEnabled = true;
            this.comboBoxMinimalAge.Location = new System.Drawing.Point(259, 174);
            this.comboBoxMinimalAge.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMinimalAge.Name = "comboBoxMinimalAge";
            this.comboBoxMinimalAge.Size = new System.Drawing.Size(140, 23);
            this.comboBoxMinimalAge.TabIndex = 16;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(416, 176);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(25, 15);
            this.labelAge.TabIndex = 17;
            this.labelAge.Text = "лет";
            // 
            // PillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 352);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.comboBoxMinimalAge);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.buttonSetData);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.labelMinimalAge);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelShelfLife);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.comboBoxShelfLife);
            this.Controls.Add(this.comboBoxTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PillsForm";
            this.Text = "Таблетки";
            this.Load += new System.EventHandler(this.PillsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTitle;
        private System.Windows.Forms.ComboBox comboBoxShelfLife;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelShelfLife;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelMinimalAge;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Button buttonSetData;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.ComboBox comboBoxMinimalAge;
        private System.Windows.Forms.Label labelAge;
    }
}