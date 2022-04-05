using System.Windows.Forms;
using lab6.Di;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace lab6
{
    partial class Lab6
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
            this.components = new System.ComponentModel.Container();
            this.FindButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DateLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ControlTab = new System.Windows.Forms.TabControl();
            this.FindTab = new System.Windows.Forms.TabPage();
            this.ClearButton = new System.Windows.Forms.Button();
            this.FindText = new System.Windows.Forms.TextBox();
            this.FindAndReplaceTab = new System.Windows.Forms.TabPage();
            this.ReplaceText = new System.Windows.Forms.TextBox();
            this.FindAndReplaceButton = new System.Windows.Forms.Button();
            this.FindText2 = new System.Windows.Forms.TextBox();
            this.RemoveTab = new System.Windows.Forms.TabPage();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.RemoveText = new System.Windows.Forms.TextBox();
            this.DateValue = new System.Windows.Forms.Label();
            this.FontLabel = new System.Windows.Forms.Label();
            this.FontValue = new System.Windows.Forms.Label();
            this.SymbolsLabel = new System.Windows.Forms.Label();
            this.SymbolsValue = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.InputText = new System.Windows.Forms.RichTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.ControlTab.SuspendLayout();
            this.FindTab.SuspendLayout();
            this.FindAndReplaceTab.SuspendLayout();
            this.RemoveTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(6, 39);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(230, 34);
            this.FindButton.TabIndex = 2;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(418, 378);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(44, 20);
            this.DateLabel.TabIndex = 7;
            this.DateLabel.Text = "Date:";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // ControlTab
            // 
            this.ControlTab.Controls.Add(this.FindTab);
            this.ControlTab.Controls.Add(this.FindAndReplaceTab);
            this.ControlTab.Controls.Add(this.RemoveTab);
            this.ControlTab.Location = new System.Drawing.Point(538, 8);
            this.ControlTab.Name = "ControlTab";
            this.ControlTab.SelectedIndex = 0;
            this.ControlTab.Size = new System.Drawing.Size(250, 173);
            this.ControlTab.TabIndex = 9;
            // 
            // FindTab
            // 
            this.FindTab.Controls.Add(this.ClearButton);
            this.FindTab.Controls.Add(this.FindText);
            this.FindTab.Controls.Add(this.FindButton);
            this.FindTab.Location = new System.Drawing.Point(4, 29);
            this.FindTab.Name = "FindTab";
            this.FindTab.Padding = new System.Windows.Forms.Padding(3);
            this.FindTab.Size = new System.Drawing.Size(242, 140);
            this.FindTab.TabIndex = 0;
            this.FindTab.Text = "Find";
            this.FindTab.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(6, 79);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(230, 29);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // FindText
            // 
            this.FindText.Location = new System.Drawing.Point(6, 6);
            this.FindText.Name = "FindText";
            this.FindText.Size = new System.Drawing.Size(230, 27);
            this.FindText.TabIndex = 3;
            // 
            // FindAndReplaceTab
            // 
            this.FindAndReplaceTab.Controls.Add(this.ReplaceText);
            this.FindAndReplaceTab.Controls.Add(this.FindAndReplaceButton);
            this.FindAndReplaceTab.Controls.Add(this.FindText2);
            this.FindAndReplaceTab.Location = new System.Drawing.Point(4, 29);
            this.FindAndReplaceTab.Name = "FindAndReplaceTab";
            this.FindAndReplaceTab.Padding = new System.Windows.Forms.Padding(3);
            this.FindAndReplaceTab.Size = new System.Drawing.Size(242, 140);
            this.FindAndReplaceTab.TabIndex = 1;
            this.FindAndReplaceTab.Text = "Find & Replace";
            this.FindAndReplaceTab.UseVisualStyleBackColor = true;
            // 
            // ReplaceText
            // 
            this.ReplaceText.Location = new System.Drawing.Point(6, 43);
            this.ReplaceText.Name = "ReplaceText";
            this.ReplaceText.Size = new System.Drawing.Size(230, 27);
            this.ReplaceText.TabIndex = 3;
            // 
            // FindAndReplaceButton
            // 
            this.FindAndReplaceButton.Location = new System.Drawing.Point(6, 76);
            this.FindAndReplaceButton.Name = "FindAndReplaceButton";
            this.FindAndReplaceButton.Size = new System.Drawing.Size(230, 29);
            this.FindAndReplaceButton.TabIndex = 2;
            this.FindAndReplaceButton.Text = "Find and Replace";
            this.FindAndReplaceButton.UseVisualStyleBackColor = true;
            this.FindAndReplaceButton.Click += new System.EventHandler(this.FindAndReplaceButton_Click);
            // 
            // FindText2
            // 
            this.FindText2.Location = new System.Drawing.Point(6, 6);
            this.FindText2.Name = "FindText2";
            this.FindText2.Size = new System.Drawing.Size(230, 27);
            this.FindText2.TabIndex = 0;
            // 
            // RemoveTab
            // 
            this.RemoveTab.Controls.Add(this.RemoveButton);
            this.RemoveTab.Controls.Add(this.RemoveText);
            this.RemoveTab.Location = new System.Drawing.Point(4, 29);
            this.RemoveTab.Name = "RemoveTab";
            this.RemoveTab.Padding = new System.Windows.Forms.Padding(3);
            this.RemoveTab.Size = new System.Drawing.Size(242, 140);
            this.RemoveTab.TabIndex = 2;
            this.RemoveTab.Text = "Remove";
            this.RemoveTab.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(6, 39);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(230, 29);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // RemoveText
            // 
            this.RemoveText.Location = new System.Drawing.Point(6, 6);
            this.RemoveText.Name = "RemoveText";
            this.RemoveText.Size = new System.Drawing.Size(230, 27);
            this.RemoveText.TabIndex = 0;
            // 
            // DateValue
            // 
            this.DateValue.AutoSize = true;
            this.DateValue.Location = new System.Drawing.Point(468, 378);
            this.DateValue.Name = "DateValue";
            this.DateValue.Size = new System.Drawing.Size(0, 20);
            this.DateValue.TabIndex = 10;
            // 
            // FontLabel
            // 
            this.FontLabel.AutoSize = true;
            this.FontLabel.Location = new System.Drawing.Point(418, 398);
            this.FontLabel.Name = "FontLabel";
            this.FontLabel.Size = new System.Drawing.Size(41, 20);
            this.FontLabel.TabIndex = 11;
            this.FontLabel.Text = "Font:";
            // 
            // FontValue
            // 
            this.FontValue.AutoSize = true;
            this.FontValue.Location = new System.Drawing.Point(465, 398);
            this.FontValue.Name = "FontValue";
            this.FontValue.Size = new System.Drawing.Size(0, 20);
            this.FontValue.TabIndex = 12;
            // 
            // SymbolsLabel
            // 
            this.SymbolsLabel.AutoSize = true;
            this.SymbolsLabel.Location = new System.Drawing.Point(418, 418);
            this.SymbolsLabel.Name = "SymbolsLabel";
            this.SymbolsLabel.Size = new System.Drawing.Size(68, 20);
            this.SymbolsLabel.TabIndex = 13;
            this.SymbolsLabel.Text = "Symbols:";
            // 
            // SymbolsValue
            // 
            this.SymbolsValue.AutoSize = true;
            this.SymbolsValue.Location = new System.Drawing.Point(492, 418);
            this.SymbolsValue.Name = "SymbolsValue";
            this.SymbolsValue.Size = new System.Drawing.Size(0, 20);
            this.SymbolsValue.TabIndex = 14;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(12, 8);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(400, 430);
            this.InputText.TabIndex = 15;
            this.InputText.Text = "";
            this.InputText.TextChanged += new System.EventHandler(this.InputText_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(694, 409);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(94, 29);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // HistoryButton
            // 
            this.HistoryButton.Location = new System.Drawing.Point(694, 187);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(94, 29);
            this.HistoryButton.TabIndex = 17;
            this.HistoryButton.Text = "History";
            this.HistoryButton.UseVisualStyleBackColor = true;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // Lab6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HistoryButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.SymbolsValue);
            this.Controls.Add(this.SymbolsLabel);
            this.Controls.Add(this.FontValue);
            this.Controls.Add(this.FontLabel);
            this.Controls.Add(this.DateValue);
            this.Controls.Add(this.ControlTab);
            this.Controls.Add(this.DateLabel);
            this.Name = "Lab6";
            this.Text = "Lab6";
            this.ControlTab.ResumeLayout(false);
            this.FindTab.ResumeLayout(false);
            this.FindTab.PerformLayout();
            this.FindAndReplaceTab.ResumeLayout(false);
            this.FindAndReplaceTab.PerformLayout();
            this.RemoveTab.ResumeLayout(false);
            this.RemoveTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.TabControl ControlTab;
        private System.Windows.Forms.TabPage FindTab;
        private System.Windows.Forms.TextBox FindText;
        private System.Windows.Forms.TabPage FindAndReplaceTab;
        private System.Windows.Forms.TextBox ReplaceText;
        private System.Windows.Forms.Button FindAndReplaceButton;
        private System.Windows.Forms.TextBox FindText2;
        private System.Windows.Forms.TabPage RemoveTab;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TextBox RemoveText;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label DateValue;
        private System.Windows.Forms.Label FontLabel;
        private System.Windows.Forms.Label FontValue;
        private System.Windows.Forms.Label SymbolsLabel;
        private System.Windows.Forms.Label SymbolsValue;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.RichTextBox InputText;
        private System.Windows.Forms.Button SaveButton;
        private Button HistoryButton;
    }
}
