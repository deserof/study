namespace laba8
{
    partial class OintmentForm
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
            this.buttonSetData = new System.Windows.Forms.Button();
            this.labelAge = new System.Windows.Forms.Label();
            this.comboBoxMinimalAge = new System.Windows.Forms.ComboBox();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelMinimalAge = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelShelfLife = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxShelfLife = new System.Windows.Forms.ComboBox();
            this.comboBoxTitle = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelVol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSetData
            // 
            this.buttonSetData.Location = new System.Drawing.Point(322, 356);
            this.buttonSetData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetData.Name = "buttonSetData";
            this.buttonSetData.Size = new System.Drawing.Size(108, 28);
            this.buttonSetData.TabIndex = 29;
            this.buttonSetData.Text = "Подтвердить";
            this.buttonSetData.UseVisualStyleBackColor = true;
            this.buttonSetData.UseWaitCursor = true;
            this.buttonSetData.Click += new System.EventHandler(this.buttonSetData_Click);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(480, 201);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(30, 16);
            this.labelAge.TabIndex = 42;
            this.labelAge.Text = "лет";
            this.labelAge.UseWaitCursor = true;
            // 
            // comboBoxMinimalAge
            // 
            this.comboBoxMinimalAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMinimalAge.FormattingEnabled = true;
            this.comboBoxMinimalAge.Items.AddRange(new object[] {
            "6",
            "10",
            "18"});
            this.comboBoxMinimalAge.Location = new System.Drawing.Point(301, 199);
            this.comboBoxMinimalAge.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMinimalAge.Name = "comboBoxMinimalAge";
            this.comboBoxMinimalAge.Size = new System.Drawing.Size(160, 24);
            this.comboBoxMinimalAge.TabIndex = 41;
            this.comboBoxMinimalAge.UseWaitCursor = true;
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Location = new System.Drawing.Point(302, 251);
            this.textBoxVolume.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(160, 22);
            this.textBoxVolume.TabIndex = 40;
            this.textBoxVolume.UseWaitCursor = true;
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
            this.comboBoxCountry.Location = new System.Drawing.Point(301, 93);
            this.comboBoxCountry.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(160, 24);
            this.comboBoxCountry.TabIndex = 39;
            this.comboBoxCountry.UseWaitCursor = true;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(139, 97);
            this.labelCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(145, 16);
            this.labelCountry.TabIndex = 38;
            this.labelCountry.Text = "Срана производства";
            this.labelCountry.UseWaitCursor = true;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(224, 303);
            this.labelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(68, 16);
            this.labelType.TabIndex = 37;
            this.labelType.Text = "Тип мази";
            this.labelType.UseWaitCursor = true;
            // 
            // labelMinimalAge
            // 
            this.labelMinimalAge.AutoSize = true;
            this.labelMinimalAge.Location = new System.Drawing.Point(19, 202);
            this.labelMinimalAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinimalAge.Name = "labelMinimalAge";
            this.labelMinimalAge.Size = new System.Drawing.Size(281, 16);
            this.labelMinimalAge.TabIndex = 35;
            this.labelMinimalAge.Text = "Минимальный возраст при употреблении";
            this.labelMinimalAge.UseWaitCursor = true;
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(233, 254);
            this.labelVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(51, 16);
            this.labelVolume.TabIndex = 34;
            this.labelVolume.Text = "Объем";
            this.labelVolume.UseWaitCursor = true;
            // 
            // labelShelfLife
            // 
            this.labelShelfLife.AutoSize = true;
            this.labelShelfLife.Location = new System.Drawing.Point(179, 150);
            this.labelShelfLife.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShelfLife.Name = "labelShelfLife";
            this.labelShelfLife.Size = new System.Drawing.Size(102, 16);
            this.labelShelfLife.TabIndex = 33;
            this.labelShelfLife.Text = "Срок годности";
            this.labelShelfLife.UseWaitCursor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(211, 47);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(73, 16);
            this.labelTitle.TabIndex = 32;
            this.labelTitle.Text = "Название";
            this.labelTitle.UseWaitCursor = true;
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
            this.comboBoxShelfLife.Location = new System.Drawing.Point(301, 146);
            this.comboBoxShelfLife.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxShelfLife.Name = "comboBoxShelfLife";
            this.comboBoxShelfLife.Size = new System.Drawing.Size(160, 24);
            this.comboBoxShelfLife.TabIndex = 31;
            this.comboBoxShelfLife.UseWaitCursor = true;
            // 
            // comboBoxTitle
            // 
            this.comboBoxTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTitle.FormattingEnabled = true;
            this.comboBoxTitle.Items.AddRange(new object[] {
            "Бепантен",
            "Кловейт",
            "Аргезин"});
            this.comboBoxTitle.Location = new System.Drawing.Point(301, 44);
            this.comboBoxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTitle.Name = "comboBoxTitle";
            this.comboBoxTitle.Size = new System.Drawing.Size(160, 24);
            this.comboBoxTitle.TabIndex = 30;
            this.comboBoxTitle.UseWaitCursor = true;
            // 
            // comboBoxType
            // 
            this.comboBoxType.AutoCompleteCustomSource.AddRange(new string[] {
            "Гидрофобная",
            "Гидрофиьная",
            "Дифильная"});
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Гидрофильная",
            "Гидрофобная ",
            "Дифильная"});
            this.comboBoxType.Location = new System.Drawing.Point(301, 300);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(160, 24);
            this.comboBoxType.TabIndex = 43;
            this.comboBoxType.UseWaitCursor = true;
            // 
            // labelVol
            // 
            this.labelVol.AutoSize = true;
            this.labelVol.Location = new System.Drawing.Point(480, 257);
            this.labelVol.Name = "labelVol";
            this.labelVol.Size = new System.Drawing.Size(24, 16);
            this.labelVol.TabIndex = 44;
            this.labelVol.Text = "мл";
            this.labelVol.UseWaitCursor = true;
            // 
            // OintmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 423);
            this.Controls.Add(this.labelVol);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.comboBoxMinimalAge);
            this.Controls.Add(this.textBoxVolume);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelMinimalAge);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.labelShelfLife);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.comboBoxShelfLife);
            this.Controls.Add(this.comboBoxTitle);
            this.Controls.Add(this.buttonSetData);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OintmentForm";
            this.Text = "Мазь";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetData;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.ComboBox comboBoxMinimalAge;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelMinimalAge;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelShelfLife;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxShelfLife;
        private System.Windows.Forms.ComboBox comboBoxTitle;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelVol;
    }
}