namespace laba8
{
    partial class NotebookForm
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
            this.comboBoxCPU = new System.Windows.Forms.ComboBox();
            this.comboBoxGPU = new System.Windows.Forms.ComboBox();
            this.comboBoxBattery = new System.Windows.Forms.ComboBox();
            this.labelCPU = new System.Windows.Forms.Label();
            this.labelGPU = new System.Windows.Forms.Label();
            this.labelBattery = new System.Windows.Forms.Label();
            this.labelRAM = new System.Windows.Forms.Label();
            this.textBoxQuantityRAM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWorkHours = new System.Windows.Forms.TextBox();
            this.labelWorkHours = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelNumberOfCore = new System.Windows.Forms.Label();
            this.comboBoxNumberOfCores = new System.Windows.Forms.ComboBox();
            this.buttonSetData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCPU
            // 
            this.comboBoxCPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCPU.FormattingEnabled = true;
            this.comboBoxCPU.Items.AddRange(new object[] {
            "Intel",
            "AMD"});
            this.comboBoxCPU.Location = new System.Drawing.Point(199, 25);
            this.comboBoxCPU.Name = "comboBoxCPU";
            this.comboBoxCPU.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCPU.TabIndex = 0;
            // 
            // comboBoxGPU
            // 
            this.comboBoxGPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGPU.FormattingEnabled = true;
            this.comboBoxGPU.Items.AddRange(new object[] {
            "nvidia",
            "AMD"});
            this.comboBoxGPU.Location = new System.Drawing.Point(199, 108);
            this.comboBoxGPU.Name = "comboBoxGPU";
            this.comboBoxGPU.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGPU.TabIndex = 1;
            // 
            // comboBoxBattery
            // 
            this.comboBoxBattery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBattery.FormattingEnabled = true;
            this.comboBoxBattery.Items.AddRange(new object[] {
            "LiPoly ",
            "LiIon ",
            "NiMh"});
            this.comboBoxBattery.Location = new System.Drawing.Point(199, 149);
            this.comboBoxBattery.Name = "comboBoxBattery";
            this.comboBoxBattery.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBattery.TabIndex = 2;
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Location = new System.Drawing.Point(119, 28);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(63, 13);
            this.labelCPU.TabIndex = 3;
            this.labelCPU.Text = "Процессор";
            // 
            // labelGPU
            // 
            this.labelGPU.AutoSize = true;
            this.labelGPU.Location = new System.Drawing.Point(119, 111);
            this.labelGPU.Name = "labelGPU";
            this.labelGPU.Size = new System.Drawing.Size(67, 13);
            this.labelGPU.TabIndex = 4;
            this.labelGPU.Text = "Видеокарта";
            // 
            // labelBattery
            // 
            this.labelBattery.AutoSize = true;
            this.labelBattery.Location = new System.Drawing.Point(82, 152);
            this.labelBattery.Name = "labelBattery";
            this.labelBattery.Size = new System.Drawing.Size(100, 13);
            this.labelBattery.TabIndex = 5;
            this.labelBattery.Text = "Тип аккумулятора";
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.Location = new System.Drawing.Point(8, 195);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(174, 13);
            this.labelRAM.TabIndex = 6;
            this.labelRAM.Text = "Количество оперативной памяти";
            // 
            // textBoxQuantityRAM
            // 
            this.textBoxQuantityRAM.Location = new System.Drawing.Point(199, 192);
            this.textBoxQuantityRAM.Name = "textBoxQuantityRAM";
            this.textBoxQuantityRAM.Size = new System.Drawing.Size(121, 20);
            this.textBoxQuantityRAM.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "GB";
            // 
            // textBoxWorkHours
            // 
            this.textBoxWorkHours.Location = new System.Drawing.Point(199, 233);
            this.textBoxWorkHours.Name = "textBoxWorkHours";
            this.textBoxWorkHours.Size = new System.Drawing.Size(121, 20);
            this.textBoxWorkHours.TabIndex = 9;
            // 
            // labelWorkHours
            // 
            this.labelWorkHours.AutoSize = true;
            this.labelWorkHours.Location = new System.Drawing.Point(102, 236);
            this.labelWorkHours.Name = "labelWorkHours";
            this.labelWorkHours.Size = new System.Drawing.Size(80, 13);
            this.labelWorkHours.TabIndex = 10;
            this.labelWorkHours.Text = "Время работы";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(326, 236);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(36, 13);
            this.labelHours.TabIndex = 11;
            this.labelHours.Text = "часов";
            // 
            // labelNumberOfCore
            // 
            this.labelNumberOfCore.AutoSize = true;
            this.labelNumberOfCore.Location = new System.Drawing.Point(89, 68);
            this.labelNumberOfCore.Name = "labelNumberOfCore";
            this.labelNumberOfCore.Size = new System.Drawing.Size(93, 13);
            this.labelNumberOfCore.TabIndex = 12;
            this.labelNumberOfCore.Text = "Количество ядер";
            // 
            // comboBoxNumberOfCores
            // 
            this.comboBoxNumberOfCores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumberOfCores.FormattingEnabled = true;
            this.comboBoxNumberOfCores.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16"});
            this.comboBoxNumberOfCores.Location = new System.Drawing.Point(199, 65);
            this.comboBoxNumberOfCores.Name = "comboBoxNumberOfCores";
            this.comboBoxNumberOfCores.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNumberOfCores.TabIndex = 13;
            // 
            // buttonSetData
            // 
            this.buttonSetData.Location = new System.Drawing.Point(223, 270);
            this.buttonSetData.Name = "buttonSetData";
            this.buttonSetData.Size = new System.Drawing.Size(81, 23);
            this.buttonSetData.TabIndex = 14;
            this.buttonSetData.Text = "Подтвердить";
            this.buttonSetData.UseVisualStyleBackColor = true;
            this.buttonSetData.Click += new System.EventHandler(this.buttonSetData_Click);
            // 
            // NotebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 305);
            this.Controls.Add(this.buttonSetData);
            this.Controls.Add(this.comboBoxNumberOfCores);
            this.Controls.Add(this.labelNumberOfCore);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelWorkHours);
            this.Controls.Add(this.textBoxWorkHours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQuantityRAM);
            this.Controls.Add(this.labelRAM);
            this.Controls.Add(this.labelBattery);
            this.Controls.Add(this.labelGPU);
            this.Controls.Add(this.labelCPU);
            this.Controls.Add(this.comboBoxBattery);
            this.Controls.Add(this.comboBoxGPU);
            this.Controls.Add(this.comboBoxCPU);
            this.Name = "NotebookForm";
            this.Text = "Ноутбук";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCPU;
        private System.Windows.Forms.ComboBox comboBoxGPU;
        private System.Windows.Forms.ComboBox comboBoxBattery;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label labelGPU;
        private System.Windows.Forms.Label labelBattery;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.TextBox textBoxQuantityRAM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWorkHours;
        private System.Windows.Forms.Label labelWorkHours;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelNumberOfCore;
        private System.Windows.Forms.ComboBox comboBoxNumberOfCores;
        private System.Windows.Forms.Button buttonSetData;
    }
}