﻿namespace chp4_prob7
{
    partial class Form1
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
            this.incomeTextBox = new System.Windows.Forms.TextBox();
            this.taxPayableLabel = new System.Windows.Forms.Label();
            this.netIncomeLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.lbl_show_payabletax = new System.Windows.Forms.Label();
            this.lbl_show_netincome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your Taxable Income:";
            // 
            // incomeTextBox
            // 
            this.incomeTextBox.Location = new System.Drawing.Point(40, 51);
            this.incomeTextBox.Name = "incomeTextBox";
            this.incomeTextBox.Size = new System.Drawing.Size(168, 22);
            this.incomeTextBox.TabIndex = 1;
            // 
            // taxPayableLabel
            // 
            this.taxPayableLabel.AutoSize = true;
            this.taxPayableLabel.Location = new System.Drawing.Point(37, 98);
            this.taxPayableLabel.Name = "taxPayableLabel";
            this.taxPayableLabel.Size = new System.Drawing.Size(0, 12);
            this.taxPayableLabel.TabIndex = 2;
            // 
            // netIncomeLabel
            // 
            this.netIncomeLabel.AutoSize = true;
            this.netIncomeLabel.Location = new System.Drawing.Point(37, 130);
            this.netIncomeLabel.Name = "netIncomeLabel";
            this.netIncomeLabel.Size = new System.Drawing.Size(0, 12);
            this.netIncomeLabel.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(32, 179);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(114, 27);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate Tax";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(191, 180);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(58, 26);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // lbl_show_payabletax
            // 
            this.lbl_show_payabletax.Location = new System.Drawing.Point(39, 98);
            this.lbl_show_payabletax.Name = "lbl_show_payabletax";
            this.lbl_show_payabletax.Size = new System.Drawing.Size(169, 20);
            this.lbl_show_payabletax.TabIndex = 6;
            
            // 
            // lbl_show_netincome
            // 
            this.lbl_show_netincome.Location = new System.Drawing.Point(39, 130);
            this.lbl_show_netincome.Name = "lbl_show_netincome";
            this.lbl_show_netincome.Size = new System.Drawing.Size(169, 20);
            this.lbl_show_netincome.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 241);
            this.Controls.Add(this.lbl_show_netincome);
            this.Controls.Add(this.lbl_show_payabletax);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.netIncomeLabel);
            this.Controls.Add(this.taxPayableLabel);
            this.Controls.Add(this.incomeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Income Tax Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox incomeTextBox;
        private System.Windows.Forms.Label taxPayableLabel;
        private System.Windows.Forms.Label netIncomeLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label lbl_show_payabletax;
        private System.Windows.Forms.Label lbl_show_netincome;
    }
}

