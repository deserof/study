namespace CourseWork
{
    partial class Elements
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
            this.label1 = new System.Windows.Forms.Label();
            this.ElementsCountComboBox = new System.Windows.Forms.ComboBox();
            this.CriterionsDataGridView = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameElement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlternativesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CriterionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlternativesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Укажите число элементов:";
            // 
            // ElementsCountComboBox
            // 
            this.ElementsCountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ElementsCountComboBox.FormattingEnabled = true;
            this.ElementsCountComboBox.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.ElementsCountComboBox.Location = new System.Drawing.Point(218, 21);
            this.ElementsCountComboBox.Name = "ElementsCountComboBox";
            this.ElementsCountComboBox.Size = new System.Drawing.Size(54, 24);
            this.ElementsCountComboBox.TabIndex = 1;
            this.ElementsCountComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CriterionsDataGridView
            // 
            this.CriterionsDataGridView.AllowUserToAddRows = false;
            this.CriterionsDataGridView.AllowUserToDeleteRows = false;
            this.CriterionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CriterionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CriterionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.NameElement});
            this.CriterionsDataGridView.Location = new System.Drawing.Point(29, 88);
            this.CriterionsDataGridView.Name = "CriterionsDataGridView";
            this.CriterionsDataGridView.RowHeadersWidth = 51;
            this.CriterionsDataGridView.RowTemplate.Height = 24;
            this.CriterionsDataGridView.Size = new System.Drawing.Size(309, 256);
            this.CriterionsDataGridView.TabIndex = 2;
            // 
            // Number
            // 
            this.Number.FillWeight = 64.17112F;
            this.Number.HeaderText = "№";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // NameElement
            // 
            this.NameElement.FillWeight = 135.8289F;
            this.NameElement.HeaderText = "Название";
            this.NameElement.MinimumWidth = 6;
            this.NameElement.Name = "NameElement";
            // 
            // AlternativesDataGridView
            // 
            this.AlternativesDataGridView.AllowUserToAddRows = false;
            this.AlternativesDataGridView.AllowUserToDeleteRows = false;
            this.AlternativesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AlternativesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlternativesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.AlternativesDataGridView.Location = new System.Drawing.Point(399, 88);
            this.AlternativesDataGridView.Name = "AlternativesDataGridView";
            this.AlternativesDataGridView.RowHeadersWidth = 51;
            this.AlternativesDataGridView.RowTemplate.Height = 24;
            this.AlternativesDataGridView.Size = new System.Drawing.Size(309, 256);
            this.AlternativesDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 64.17112F;
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 135.8289F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Критерии";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Альтернативы";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(602, 387);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(124, 29);
            this.OkButton.TabIndex = 6;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // Elements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(738, 428);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AlternativesDataGridView);
            this.Controls.Add(this.CriterionsDataGridView);
            this.Controls.Add(this.ElementsCountComboBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(756, 475);
            this.MinimumSize = new System.Drawing.Size(756, 475);
            this.Name = "Elements";
            this.Text = "Elements";
            ((System.ComponentModel.ISupportInitialize)(this.CriterionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlternativesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ElementsCountComboBox;
        private System.Windows.Forms.DataGridView CriterionsDataGridView;
        private System.Windows.Forms.DataGridView AlternativesDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameElement;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}