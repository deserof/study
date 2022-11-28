namespace laba8
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxMedicine = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonOintment = new System.Windows.Forms.RadioButton();
            this.radioButtonPills = new System.Windows.Forms.RadioButton();
            this.buttonEnterData = new System.Windows.Forms.Button();
            this.buttonShortData = new System.Windows.Forms.Button();
            this.buttonShowData = new System.Windows.Forms.Button();
            this.сopyButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxMedicine
            // 
            this.listBoxMedicine.FormattingEnabled = true;
            this.listBoxMedicine.ItemHeight = 15;
            this.listBoxMedicine.Location = new System.Drawing.Point(297, 21);
            this.listBoxMedicine.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMedicine.Name = "listBoxMedicine";
            this.listBoxMedicine.Size = new System.Drawing.Size(446, 214);
            this.listBoxMedicine.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonOintment);
            this.groupBox1.Controls.Add(this.radioButtonPills);
            this.groupBox1.Location = new System.Drawing.Point(34, 119);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(234, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите";
            // 
            // radioButtonOintment
            // 
            this.radioButtonOintment.AutoSize = true;
            this.radioButtonOintment.Location = new System.Drawing.Point(7, 74);
            this.radioButtonOintment.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonOintment.Name = "radioButtonOintment";
            this.radioButtonOintment.Size = new System.Drawing.Size(53, 19);
            this.radioButtonOintment.TabIndex = 1;
            this.radioButtonOintment.Text = "Мазь";
            this.radioButtonOintment.UseVisualStyleBackColor = true;
            // 
            // radioButtonPills
            // 
            this.radioButtonPills.AutoSize = true;
            this.radioButtonPills.Checked = true;
            this.radioButtonPills.Location = new System.Drawing.Point(7, 32);
            this.radioButtonPills.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonPills.Name = "radioButtonPills";
            this.radioButtonPills.Size = new System.Drawing.Size(75, 19);
            this.radioButtonPills.TabIndex = 0;
            this.radioButtonPills.TabStop = true;
            this.radioButtonPills.Text = "Таблетки";
            this.radioButtonPills.UseVisualStyleBackColor = true;
            // 
            // buttonEnterData
            // 
            this.buttonEnterData.Location = new System.Drawing.Point(34, 53);
            this.buttonEnterData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEnterData.Name = "buttonEnterData";
            this.buttonEnterData.Size = new System.Drawing.Size(234, 26);
            this.buttonEnterData.TabIndex = 2;
            this.buttonEnterData.Text = "Ввести данные";
            this.buttonEnterData.UseVisualStyleBackColor = true;
            this.buttonEnterData.Click += new System.EventHandler(this.buttonEnterData_Click);
            // 
            // buttonShortData
            // 
            this.buttonShortData.Location = new System.Drawing.Point(424, 251);
            this.buttonShortData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShortData.Name = "buttonShortData";
            this.buttonShortData.Size = new System.Drawing.Size(146, 26);
            this.buttonShortData.TabIndex = 3;
            this.buttonShortData.Text = "Краткие сведения";
            this.buttonShortData.UseVisualStyleBackColor = true;
            this.buttonShortData.Click += new System.EventHandler(this.buttonShortData_Click);
            // 
            // buttonShowData
            // 
            this.buttonShowData.Location = new System.Drawing.Point(424, 285);
            this.buttonShowData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowData.Name = "buttonShowData";
            this.buttonShowData.Size = new System.Drawing.Size(146, 26);
            this.buttonShowData.TabIndex = 4;
            this.buttonShowData.Text = "Просмотреть данные";
            this.buttonShowData.UseVisualStyleBackColor = true;
            this.buttonShowData.Click += new System.EventHandler(this.buttonShowData_Click);
            // 
            // сopyButton
            // 
            this.сopyButton.Location = new System.Drawing.Point(297, 251);
            this.сopyButton.Margin = new System.Windows.Forms.Padding(4);
            this.сopyButton.Name = "сopyButton";
            this.сopyButton.Size = new System.Drawing.Size(120, 26);
            this.сopyButton.TabIndex = 5;
            this.сopyButton.Text = "Копировать";
            this.сopyButton.UseVisualStyleBackColor = true;
            this.сopyButton.Click += new System.EventHandler(this.сopyButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sell";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.сopyButton);
            this.Controls.Add(this.buttonShowData);
            this.Controls.Add(this.buttonShortData);
            this.Controls.Add(this.buttonEnterData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxMedicine);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMedicine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEnterData;
        private System.Windows.Forms.RadioButton radioButtonOintment;
        private System.Windows.Forms.RadioButton radioButtonPills;
        private System.Windows.Forms.Button buttonShortData;
        private System.Windows.Forms.Button buttonShowData;
        private Button сopyButton;
        private Button button1;
    }
}

