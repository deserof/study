namespace ex2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.multiplication = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.xText = new System.Windows.Forms.TextBox();
            this.yText = new System.Windows.Forms.TextBox();
            this.resultText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(147, 331);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(110, 29);
            this.multiplication.TabIndex = 0;
            this.multiplication.Text = "Умножение";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(383, 331);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(94, 29);
            this.clear.TabIndex = 1;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(644, 331);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(94, 29);
            this.exit.TabIndex = 2;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // xText
            // 
            this.xText.Location = new System.Drawing.Point(383, 84);
            this.xText.Name = "xText";
            this.xText.Size = new System.Drawing.Size(125, 27);
            this.xText.TabIndex = 3;
            // 
            // yText
            // 
            this.yText.Location = new System.Drawing.Point(383, 152);
            this.yText.Name = "yText";
            this.yText.Size = new System.Drawing.Size(125, 27);
            this.yText.TabIndex = 4;
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(383, 226);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(125, 27);
            this.resultText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "X = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = " Результат:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.yText);
            this.Controls.Add(this.xText);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.multiplication);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox xText;
        private System.Windows.Forms.TextBox yText;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
