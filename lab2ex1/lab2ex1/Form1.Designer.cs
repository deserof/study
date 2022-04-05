namespace lab2ex1
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
            this.btnyes = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnyes
            // 
            this.btnyes.Location = new System.Drawing.Point(32, 108);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(94, 29);
            this.btnyes.TabIndex = 0;
            this.btnyes.Text = "Да";
            this.btnyes.UseVisualStyleBackColor = true;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(224, 108);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(77, 29);
            this.btnno.TabIndex = 1;
            this.btnno.Text = "нет";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnno_MouseMove);
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Location = new System.Drawing.Point(52, 29);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(232, 20);
            this.question.TabIndex = 2;
            this.question.Text = "Вы довольны совей зарплатой?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 153);
            this.Controls.Add(this.question);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnyes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Насущный вопрос";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnyes;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Label question;
    }
}
