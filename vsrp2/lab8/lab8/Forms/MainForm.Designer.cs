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
            this.sellButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxEnterPRice = new System.Windows.Forms.TextBox();
            this.formSearch = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
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
            this.buttonShortData.Location = new System.Drawing.Point(359, 251);
            this.buttonShortData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShortData.Name = "buttonShortData";
            this.buttonShortData.Size = new System.Drawing.Size(118, 26);
            this.buttonShortData.TabIndex = 3;
            this.buttonShortData.Text = "Товары";
            this.buttonShortData.UseVisualStyleBackColor = true;
            this.buttonShortData.Click += new System.EventHandler(this.buttonShortData_Click);
            // 
            // buttonShowData
            // 
            this.buttonShowData.Location = new System.Drawing.Point(486, 285);
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
            this.сopyButton.Location = new System.Drawing.Point(223, 251);
            this.сopyButton.Margin = new System.Windows.Forms.Padding(4);
            this.сopyButton.Name = "сopyButton";
            this.сopyButton.Size = new System.Drawing.Size(130, 26);
            this.сopyButton.TabIndex = 5;
            this.сopyButton.Text = "Копировать";
            this.сopyButton.UseVisualStyleBackColor = true;
            this.сopyButton.Click += new System.EventHandler(this.сopyButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(641, 251);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(102, 27);
            this.sellButton.TabIndex = 6;
            this.sellButton.Text = "Продать";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Личные данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "Проданные товары";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxEnterPRice
            // 
            this.textBoxEnterPRice.Location = new System.Drawing.Point(641, 288);
            this.textBoxEnterPRice.Name = "textBoxEnterPRice";
            this.textBoxEnterPRice.Size = new System.Drawing.Size(100, 23);
            this.textBoxEnterPRice.TabIndex = 9;
            // 
            // formSearch
            // 
            this.formSearch.Location = new System.Drawing.Point(221, 284);
            this.formSearch.Name = "formSearch";
            this.formSearch.Size = new System.Drawing.Size(132, 27);
            this.formSearch.TabIndex = 10;
            this.formSearch.Text = "Форма поиска";
            this.formSearch.UseVisualStyleBackColor = true;
            this.formSearch.Click += new System.EventHandler(this.formSearch_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(486, 251);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(146, 27);
            this.changeButton.TabIndex = 11;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 340);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.formSearch);
            this.Controls.Add(this.textBoxEnterPRice);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sellButton);
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
            this.PerformLayout();

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
        private Button sellButton;
        private Button button1;
        private Button button2;
        private TextBox textBoxEnterPRice;
        private Button formSearch;
        private Button changeButton;
    }
}

