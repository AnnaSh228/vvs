﻿
namespace vvs
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
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cmbFirstType = new System.Windows.Forms.ComboBox();
            this.cmbSecondType = new System.Windows.Forms.ComboBox();
            this.cmbResultType = new System.Windows.Forms.ComboBox();
            this.txtKf = new System.Windows.Forms.TextBox();
            this.txtKfFirst = new System.Windows.Forms.TextBox();
            this.txtKfSecond = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbOperation
            // 
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmbOperation.Location = new System.Drawing.Point(39, 30);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(69, 24);
            this.cmbOperation.TabIndex = 0;
            this.cmbOperation.Text = "+";
            this.cmbOperation.SelectedIndexChanged += new System.EventHandler(this.cmbOperation_SelectedIndexChanged);
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(141, 30);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(121, 22);
            this.txtFirst.TabIndex = 1;
            this.txtFirst.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(141, 65);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(121, 22);
            this.txtSecond.TabIndex = 2;
            this.txtSecond.TextChanged += new System.EventHandler(this.txtSecond_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(39, 104);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(223, 22);
            this.txtResult.TabIndex = 3;
            // 
            // cmbFirstType
            // 
            this.cmbFirstType.FormattingEnabled = true;
            this.cmbFirstType.Location = new System.Drawing.Point(284, 30);
            this.cmbFirstType.Name = "cmbFirstType";
            this.cmbFirstType.Size = new System.Drawing.Size(164, 24);
            this.cmbFirstType.TabIndex = 4;
            this.cmbFirstType.SelectedIndexChanged += new System.EventHandler(this.cmbFirstType_SelectedIndexChanged);
            // 
            // cmbSecondType
            // 
            this.cmbSecondType.FormattingEnabled = true;
            this.cmbSecondType.Location = new System.Drawing.Point(284, 65);
            this.cmbSecondType.Name = "cmbSecondType";
            this.cmbSecondType.Size = new System.Drawing.Size(164, 24);
            this.cmbSecondType.TabIndex = 5;
            this.cmbSecondType.SelectedIndexChanged += new System.EventHandler(this.cmbSecondType_SelectedIndexChanged);
            // 
            // cmbResultType
            // 
            this.cmbResultType.FormattingEnabled = true;
            this.cmbResultType.Location = new System.Drawing.Point(284, 104);
            this.cmbResultType.Name = "cmbResultType";
            this.cmbResultType.Size = new System.Drawing.Size(164, 24);
            this.cmbResultType.TabIndex = 6;
            this.cmbResultType.SelectedIndexChanged += new System.EventHandler(this.cmbResultType_SelectedIndexChanged);
            // 
            // txtKf
            // 
            this.txtKf.Location = new System.Drawing.Point(39, 67);
            this.txtKf.Name = "txtKf";
            this.txtKf.Size = new System.Drawing.Size(69, 22);
            this.txtKf.TabIndex = 7;
            // 
            // txtKfFirst
            // 
            this.txtKfFirst.Location = new System.Drawing.Point(454, 30);
            this.txtKfFirst.Name = "txtKfFirst";
            this.txtKfFirst.Size = new System.Drawing.Size(114, 22);
            this.txtKfFirst.TabIndex = 8;
            this.txtKfFirst.TextChanged += new System.EventHandler(this.txtKfFirst_TextChanged);
            // 
            // txtKfSecond
            // 
            this.txtKfSecond.Location = new System.Drawing.Point(454, 65);
            this.txtKfSecond.Name = "txtKfSecond";
            this.txtKfSecond.Size = new System.Drawing.Size(114, 22);
            this.txtKfSecond.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(749, 175);
            this.Controls.Add(this.txtKfSecond);
            this.Controls.Add(this.txtKfFirst);
            this.Controls.Add(this.txtKf);
            this.Controls.Add(this.cmbResultType);
            this.Controls.Add(this.cmbSecondType);
            this.Controls.Add(this.cmbFirstType);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.cmbOperation);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox cmbFirstType;
        private System.Windows.Forms.ComboBox cmbSecondType;
        private System.Windows.Forms.ComboBox cmbResultType;
        private System.Windows.Forms.TextBox txtKf;
        private System.Windows.Forms.TextBox txtKfFirst;
        private System.Windows.Forms.TextBox txtKfSecond;
    }
}

