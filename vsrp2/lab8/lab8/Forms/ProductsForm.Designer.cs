namespace lab8.Forms
{
    partial class ProductsForm
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.sortByCustom = new System.Windows.Forms.Button();
            this.sortByDate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioOintments = new System.Windows.Forms.RadioButton();
            this.radioPills = new System.Windows.Forms.RadioButton();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.findByPrice = new System.Windows.Forms.Button();
            this.findByName = new System.Windows.Forms.Button();
            this.findByYear = new System.Windows.Forms.Button();
            this.findByCountry = new System.Windows.Forms.Button();
            this.sortByPrice = new System.Windows.Forms.Button();
            this.listBoxMedicine = new System.Windows.Forms.ListBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(35, 247);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(128, 23);
            this.searchTextBox.TabIndex = 28;
            // 
            // sortByCustom
            // 
            this.sortByCustom.Location = new System.Drawing.Point(491, 276);
            this.sortByCustom.Name = "sortByCustom";
            this.sortByCustom.Size = new System.Drawing.Size(143, 52);
            this.sortByCustom.TabIndex = 27;
            this.sortByCustom.Text = "Сортировка по";
            this.sortByCustom.UseVisualStyleBackColor = true;
            this.sortByCustom.Click += new System.EventHandler(this.sortByCustom_Click);
            // 
            // sortByDate
            // 
            this.sortByDate.Location = new System.Drawing.Point(342, 305);
            this.sortByDate.Name = "sortByDate";
            this.sortByDate.Size = new System.Drawing.Size(143, 23);
            this.sortByDate.TabIndex = 26;
            this.sortByDate.Text = "Сортировка по дате";
            this.sortByDate.UseVisualStyleBackColor = true;
            this.sortByDate.Click += new System.EventHandler(this.sortByDate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioOintments);
            this.groupBox2.Controls.Add(this.radioPills);
            this.groupBox2.Controls.Add(this.radioAll);
            this.groupBox2.Location = new System.Drawing.Point(36, 343);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(299, 67);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите";
            // 
            // radioOintments
            // 
            this.radioOintments.AutoSize = true;
            this.radioOintments.Checked = true;
            this.radioOintments.Location = new System.Drawing.Point(181, 34);
            this.radioOintments.Margin = new System.Windows.Forms.Padding(4);
            this.radioOintments.Name = "radioOintments";
            this.radioOintments.Size = new System.Drawing.Size(54, 19);
            this.radioOintments.TabIndex = 2;
            this.radioOintments.TabStop = true;
            this.radioOintments.Text = "Мази";
            this.radioOintments.UseVisualStyleBackColor = true;
            this.radioOintments.CheckedChanged += new System.EventHandler(this.radioOintments_CheckedChanged);
            // 
            // radioPills
            // 
            this.radioPills.AutoSize = true;
            this.radioPills.Location = new System.Drawing.Point(104, 34);
            this.radioPills.Margin = new System.Windows.Forms.Padding(4);
            this.radioPills.Name = "radioPills";
            this.radioPills.Size = new System.Drawing.Size(75, 19);
            this.radioPills.TabIndex = 1;
            this.radioPills.Text = "Таблетки";
            this.radioPills.UseVisualStyleBackColor = true;
            this.radioPills.CheckedChanged += new System.EventHandler(this.radioPills_CheckedChanged);
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Checked = true;
            this.radioAll.Location = new System.Drawing.Point(9, 34);
            this.radioAll.Margin = new System.Windows.Forms.Padding(4);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(87, 19);
            this.radioAll.TabIndex = 0;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "Все товары";
            this.radioAll.UseVisualStyleBackColor = true;
            this.radioAll.CheckedChanged += new System.EventHandler(this.radioAll_CheckedChanged);
            // 
            // findByPrice
            // 
            this.findByPrice.Location = new System.Drawing.Point(171, 305);
            this.findByPrice.Name = "findByPrice";
            this.findByPrice.Size = new System.Drawing.Size(121, 23);
            this.findByPrice.TabIndex = 24;
            this.findByPrice.Text = "Поиск по цене";
            this.findByPrice.UseVisualStyleBackColor = true;
            this.findByPrice.Click += new System.EventHandler(this.findByPrice_Click);
            // 
            // findByName
            // 
            this.findByName.Location = new System.Drawing.Point(34, 276);
            this.findByName.Name = "findByName";
            this.findByName.Size = new System.Drawing.Size(129, 23);
            this.findByName.TabIndex = 23;
            this.findByName.Text = "Поиск по названию";
            this.findByName.UseVisualStyleBackColor = true;
            this.findByName.Click += new System.EventHandler(this.findByName_Click);
            // 
            // findByYear
            // 
            this.findByYear.Location = new System.Drawing.Point(36, 305);
            this.findByYear.Name = "findByYear";
            this.findByYear.Size = new System.Drawing.Size(129, 23);
            this.findByYear.TabIndex = 22;
            this.findByYear.Text = "Поиск по году";
            this.findByYear.UseVisualStyleBackColor = true;
            this.findByYear.Click += new System.EventHandler(this.findByYear_Click);
            // 
            // findByCountry
            // 
            this.findByCountry.Location = new System.Drawing.Point(169, 276);
            this.findByCountry.Name = "findByCountry";
            this.findByCountry.Size = new System.Drawing.Size(121, 23);
            this.findByCountry.TabIndex = 21;
            this.findByCountry.Text = "Поиск по стране";
            this.findByCountry.UseVisualStyleBackColor = true;
            this.findByCountry.Click += new System.EventHandler(this.findByCountry_Click);
            // 
            // sortByPrice
            // 
            this.sortByPrice.Location = new System.Drawing.Point(342, 276);
            this.sortByPrice.Name = "sortByPrice";
            this.sortByPrice.Size = new System.Drawing.Size(143, 23);
            this.sortByPrice.TabIndex = 20;
            this.sortByPrice.Text = "Сортировка по цене";
            this.sortByPrice.UseVisualStyleBackColor = true;
            this.sortByPrice.Click += new System.EventHandler(this.sortByPrice_Click);
            // 
            // listBoxMedicine
            // 
            this.listBoxMedicine.FormattingEnabled = true;
            this.listBoxMedicine.ItemHeight = 15;
            this.listBoxMedicine.Location = new System.Drawing.Point(13, 13);
            this.listBoxMedicine.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMedicine.Name = "listBoxMedicine";
            this.listBoxMedicine.Size = new System.Drawing.Size(774, 214);
            this.listBoxMedicine.TabIndex = 19;
            this.listBoxMedicine.SelectedIndexChanged += new System.EventHandler(this.listBoxMedicine_SelectedIndexChanged);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(666, 415);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(121, 23);
            this.resetButton.TabIndex = 29;
            this.resetButton.Text = "Сбросить";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.sortByCustom);
            this.Controls.Add(this.sortByDate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.findByPrice);
            this.Controls.Add(this.findByName);
            this.Controls.Add(this.findByYear);
            this.Controls.Add(this.findByCountry);
            this.Controls.Add(this.sortByPrice);
            this.Controls.Add(this.listBoxMedicine);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox searchTextBox;
        private Button sortByCustom;
        private Button sortByDate;
        private GroupBox groupBox2;
        private RadioButton radioOintments;
        private RadioButton radioPills;
        private RadioButton radioAll;
        private Button findByPrice;
        private Button findByName;
        private Button findByYear;
        private Button findByCountry;
        private Button sortByPrice;
        private ListBox listBoxMedicine;
        private Button resetButton;
    }
}