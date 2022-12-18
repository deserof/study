namespace CourseWork
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.criterionsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.isTextBox = new System.Windows.Forms.TextBox();
            this.osTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exploreButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.elementComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.resultButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(253, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(668, 410);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите критерий:";
            this.label1.Visible = false;
            // 
            // criterionsComboBox
            // 
            this.criterionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.criterionsComboBox.FormattingEnabled = true;
            this.criterionsComboBox.Location = new System.Drawing.Point(12, 94);
            this.criterionsComboBox.Name = "criterionsComboBox";
            this.criterionsComboBox.Size = new System.Drawing.Size(219, 24);
            this.criterionsComboBox.TabIndex = 2;
            this.criterionsComboBox.Visible = false;
            this.criterionsComboBox.SelectedIndexChanged += new System.EventHandler(this.criterionsComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ИС:";
            // 
            // isTextBox
            // 
            this.isTextBox.Location = new System.Drawing.Point(51, 216);
            this.isTextBox.Name = "isTextBox";
            this.isTextBox.ReadOnly = true;
            this.isTextBox.Size = new System.Drawing.Size(131, 22);
            this.isTextBox.TabIndex = 4;
            this.isTextBox.Text = "0";
            // 
            // osTextBox
            // 
            this.osTextBox.Location = new System.Drawing.Point(51, 244);
            this.osTextBox.Name = "osTextBox";
            this.osTextBox.ReadOnly = true;
            this.osTextBox.Size = new System.Drawing.Size(131, 22);
            this.osTextBox.TabIndex = 6;
            this.osTextBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "ОС:";
            // 
            // exploreButton
            // 
            this.exploreButton.Location = new System.Drawing.Point(38, 151);
            this.exploreButton.Name = "exploreButton";
            this.exploreButton.Size = new System.Drawing.Size(171, 30);
            this.exploreButton.TabIndex = 7;
            this.exploreButton.Text = "Исследовать";
            this.exploreButton.UseVisualStyleBackColor = true;
            this.exploreButton.Click += new System.EventHandler(this.exploreButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Выберите сравнение:";
            // 
            // elementComboBox
            // 
            this.elementComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.elementComboBox.FormattingEnabled = true;
            this.elementComboBox.Items.AddRange(new object[] {
            "Критерии",
            "Альтернативы"});
            this.elementComboBox.Location = new System.Drawing.Point(12, 34);
            this.elementComboBox.Name = "elementComboBox";
            this.elementComboBox.Size = new System.Drawing.Size(219, 24);
            this.elementComboBox.TabIndex = 9;
            this.elementComboBox.SelectedIndexChanged += new System.EventHandler(this.elementComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Результат:";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(12, 302);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(219, 61);
            this.resultTextBox.TabIndex = 11;
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(17, 411);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(214, 27);
            this.resultButton.TabIndex = 12;
            this.resultButton.Text = "Синтез Альтернатив";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.elementComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exploreButton);
            this.Controls.Add(this.osTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.criterionsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox criterionsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox isTextBox;
        private System.Windows.Forms.TextBox osTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exploreButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox elementComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button resultButton;
    }
}

